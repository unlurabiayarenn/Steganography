
namespace Steganografii
{
    partial class FormApplication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDosyaSec = new System.Windows.Forms.Button();
            this.btnGonder = new System.Windows.Forms.Button();
            this.btnCode = new System.Windows.Forms.Button();
            this.btnAl = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtDosyaYolu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDosyaSec
            // 
            this.btnDosyaSec.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnDosyaSec.Location = new System.Drawing.Point(12, 369);
            this.btnDosyaSec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDosyaSec.Name = "btnDosyaSec";
            this.btnDosyaSec.Size = new System.Drawing.Size(108, 42);
            this.btnDosyaSec.TabIndex = 0;
            this.btnDosyaSec.Text = "Dosya Seç";
            this.btnDosyaSec.UseVisualStyleBackColor = true;
            this.btnDosyaSec.Click += new System.EventHandler(this.btnDosyaSec_Click);
            // 
            // btnGonder
            // 
            this.btnGonder.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnGonder.Location = new System.Drawing.Point(331, 370);
            this.btnGonder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(94, 41);
            this.btnGonder.TabIndex = 1;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // btnCode
            // 
            this.btnCode.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnCode.Location = new System.Drawing.Point(334, 475);
            this.btnCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(94, 41);
            this.btnCode.TabIndex = 2;
            this.btnCode.Text = "Şifrele";
            this.btnCode.UseVisualStyleBackColor = true;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // btnAl
            // 
            this.btnAl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnAl.Location = new System.Drawing.Point(434, 369);
            this.btnAl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAl.Name = "btnAl";
            this.btnAl.Size = new System.Drawing.Size(93, 41);
            this.btnAl.TabIndex = 3;
            this.btnAl.Text = "Al";
            this.btnAl.UseVisualStyleBackColor = true;
            this.btnAl.Click += new System.EventHandler(this.btnAl_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnDecode.Location = new System.Drawing.Point(434, 475);
            this.btnDecode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(93, 41);
            this.btnDecode.TabIndex = 4;
            this.btnDecode.Text = "Çöz";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(515, 328);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(24, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mesajı giriniz:";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(126, 485);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(187, 27);
            this.txtMessage.TabIndex = 7;
            // 
            // txtDosyaYolu
            // 
            this.txtDosyaYolu.Location = new System.Drawing.Point(126, 376);
            this.txtDosyaYolu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDosyaYolu.Name = "txtDosyaYolu";
            this.txtDosyaYolu.Size = new System.Drawing.Size(187, 27);
            this.txtDosyaYolu.TabIndex = 8;
            // 
            // FormApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(546, 609);
            this.Controls.Add(this.txtDosyaYolu);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.btnAl);
            this.Controls.Add(this.btnCode);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.btnDosyaSec);
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormApplication";
            this.Text = "Steganografii";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDosyaSec;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Button btnCode;
        private System.Windows.Forms.Button btnAl;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtDosyaYolu;
    }
}