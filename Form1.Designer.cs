
namespace _18YaşDoğrulamasıIleKayıt
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.btnKayıt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDogumyılı = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIsım = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(20, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Kayıt için 18 yaşından büyük olmalısınız";
            // 
            // btnKayıt
            // 
            this.btnKayıt.Font = new System.Drawing.Font("Yu Gothic", 9.75F);
            this.btnKayıt.Location = new System.Drawing.Point(23, 370);
            this.btnKayıt.Name = "btnKayıt";
            this.btnKayıt.Size = new System.Drawing.Size(103, 25);
            this.btnKayıt.TabIndex = 20;
            this.btnKayıt.Text = "Kayıt ";
            this.btnKayıt.UseVisualStyleBackColor = true;
            this.btnKayıt.Click += new System.EventHandler(this.btnKayıt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(19, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "DoğuyumYılı:";
            // 
            // txtDogumyılı
            // 
            this.txtDogumyılı.Location = new System.Drawing.Point(142, 263);
            this.txtDogumyılı.Name = "txtDogumyılı";
            this.txtDogumyılı.Size = new System.Drawing.Size(163, 20);
            this.txtDogumyılı.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(19, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "TCKN:";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(142, 226);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(163, 20);
            this.txtTC.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(19, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Soyisim:";
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(142, 179);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(163, 20);
            this.txtSoyisim.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(19, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "İsim:";
            // 
            // txtIsım
            // 
            this.txtIsım.Location = new System.Drawing.Point(142, 134);
            this.txtIsım.Name = "txtIsım";
            this.txtIsım.Size = new System.Drawing.Size(163, 20);
            this.txtIsım.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(102, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "KAYIT OL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 517);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnKayıt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDogumyılı);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoyisim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIsım);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKayıt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDogumyılı;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIsım;
        private System.Windows.Forms.Label label1;
    }
}

