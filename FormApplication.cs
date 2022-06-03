using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Steganografii
{
    public partial class FormApplication : Form
    {
        public Bitmap image;
        public FormApplication()
        {
            InitializeComponent();
        }

        private void btnDosyaSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                txtDosyaYolu.Text = openDialog.FileName.ToString();
                pictureBox1.ImageLocation = txtDosyaYolu.Text;
            }
        }
        private void btnCode_Click(object sender, EventArgs e) //Şifrele
        {
            image = new Bitmap(txtDosyaYolu.Text); //Bitmap , piksel verileriyle tanımlanan görüntülerle çalışmak için kullanılan bir nesnedir.

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color pixel = image.GetPixel(i, j);

                    if (i < 1 && j < txtMessage.TextLength)
                    {

                        char letter = Convert.ToChar(txtMessage.Text.Substring(j, 1));
                        int value = Convert.ToInt32(letter);
                        image.SetPixel(i, j, Color.FromArgb(value, pixel.G, pixel.B));
                    }

                    if (i == image.Width - 1 && j == image.Height - 1)
                    {
                        image.SetPixel(i, j, Color.FromArgb(txtMessage.TextLength, pixel.G, pixel.B ));
                    }

                }
            }
            pictureBox1.Image = image;       
        }
        private void btnDecode_Click(object sender, EventArgs e)
        {

            Bitmap image = new Bitmap(pictureBox1.Image);
            string message = "";

            Color lastpixel = image.GetPixel(image.Width - 1, image.Height - 1);
            int msgLength = lastpixel.R;

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color pixel = image.GetPixel(i, j);

                    if (i < 1 && j < msgLength)
                    {
                        int value = pixel.R;
                        char c = Convert.ToChar(value);
                        string letter = System.Text.Encoding.ASCII.GetString(new byte[] { Convert.ToByte(c) });

                        message = message + letter;
                    }
                }
            }
            MessageBox.Show(message);
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            IPEndPoint ipendpoint = new IPEndPoint(IPAddress.Parse("-"), 13000);   //  Mesajı gönderen kişi -  Mesajı Alan kişi ,IP 13000-TCPIP portu
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(ipendpoint);
            server.Listen(10);
                
            using (Socket client = server.Accept())     // karşı taraf ortama bağlandığında
            {
                ImageConverter converter = new ImageConverter();
                byte[] buffer = (byte[])converter.ConvertTo(image, typeof(byte[]));
                client.Send(buffer, buffer.Length, SocketFlags.None);
            }
                server.Close();
        }

        public Image getImage(byte[] byteArrayIn)
        {
            MemoryStream memoryStream = new MemoryStream(byteArrayIn); //fotoyu buffer da tutmak içn oluşturulur
            Image encryptedImage = Image.FromStream(memoryStream); //image buffera yazılır
            return encryptedImage;
        }

        private void btnAl_Click(object sender, EventArgs e)
        {
            IPEndPoint ipendpoint = new IPEndPoint(IPAddress.Parse("-"), 13000); //Mesajı göndereceğimiz kişi-Mesajı Alacağımız kişi
            using (Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {//TCP üzerinden veri göndermek için socket oluşturur.

                client.Connect(ipendpoint);        // eğer birinin locaine bağlanılırsa	
                byte[] buffer = new byte[100000000];
                client.Receive(buffer, buffer.Length, SocketFlags.None);    // fotoğraf kabul edilir

                pictureBox1.Image = getImage(buffer);
            }
        }

    }
}
