
namespace KayitOl1
{
    partial class Form1
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
            this.lbl_kAdi = new System.Windows.Forms.Label();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.txt_kAdi = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.btn_kayitOl = new System.Windows.Forms.Button();
            this.lbl_minKarakter = new System.Windows.Forms.Label();
            this.lbl_buyukHarf = new System.Windows.Forms.Label();
            this.lbl_kucukHarf = new System.Windows.Forms.Label();
            this.lbl_rakam = new System.Windows.Forms.Label();
            this.lbl_sembol = new System.Windows.Forms.Label();
            this.lstBox_puan = new System.Windows.Forms.ListBox();
            this.lstBox_mesaj = new System.Windows.Forms.ListBox();
            this.lstBox_genelPuan = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_kAdi
            // 
            this.lbl_kAdi.AutoSize = true;
            this.lbl_kAdi.Location = new System.Drawing.Point(9, 39);
            this.lbl_kAdi.Name = "lbl_kAdi";
            this.lbl_kAdi.Size = new System.Drawing.Size(166, 29);
            this.lbl_kAdi.TabIndex = 0;
            this.lbl_kAdi.Text = "Kullanıcı Adı: ";
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Location = new System.Drawing.Point(12, 113);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(71, 29);
            this.lbl_sifre.TabIndex = 0;
            this.lbl_sifre.Text = "Şifre:";
            // 
            // txt_kAdi
            // 
            this.txt_kAdi.Location = new System.Drawing.Point(215, 36);
            this.txt_kAdi.Name = "txt_kAdi";
            this.txt_kAdi.Size = new System.Drawing.Size(224, 35);
            this.txt_kAdi.TabIndex = 1;
            this.txt_kAdi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(215, 113);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(224, 35);
            this.txt_sifre.TabIndex = 2;
            this.txt_sifre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_kayitOl
            // 
            this.btn_kayitOl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_kayitOl.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitOl.ForeColor = System.Drawing.Color.Yellow;
            this.btn_kayitOl.Location = new System.Drawing.Point(78, 177);
            this.btn_kayitOl.Name = "btn_kayitOl";
            this.btn_kayitOl.Size = new System.Drawing.Size(232, 72);
            this.btn_kayitOl.TabIndex = 3;
            this.btn_kayitOl.Text = "KAYIT OL";
            this.btn_kayitOl.UseVisualStyleBackColor = false;
            this.btn_kayitOl.Click += new System.EventHandler(this.btn_kayitOl_Click);
            // 
            // lbl_minKarakter
            // 
            this.lbl_minKarakter.AutoSize = true;
            this.lbl_minKarakter.ForeColor = System.Drawing.Color.Red;
            this.lbl_minKarakter.Location = new System.Drawing.Point(11, 269);
            this.lbl_minKarakter.Name = "lbl_minKarakter";
            this.lbl_minKarakter.Size = new System.Drawing.Size(330, 29);
            this.lbl_minKarakter.TabIndex = 3;
            this.lbl_minKarakter.Text = "En az 9 karakter olmalı. (10p)";
            // 
            // lbl_buyukHarf
            // 
            this.lbl_buyukHarf.AutoSize = true;
            this.lbl_buyukHarf.ForeColor = System.Drawing.Color.Red;
            this.lbl_buyukHarf.Location = new System.Drawing.Point(13, 313);
            this.lbl_buyukHarf.Name = "lbl_buyukHarf";
            this.lbl_buyukHarf.Size = new System.Drawing.Size(355, 29);
            this.lbl_buyukHarf.TabIndex = 3;
            this.lbl_buyukHarf.Text = "Büyük harf bulunmalı. (10/20p)";
            // 
            // lbl_kucukHarf
            // 
            this.lbl_kucukHarf.AutoSize = true;
            this.lbl_kucukHarf.ForeColor = System.Drawing.Color.Red;
            this.lbl_kucukHarf.Location = new System.Drawing.Point(13, 357);
            this.lbl_kucukHarf.Name = "lbl_kucukHarf";
            this.lbl_kucukHarf.Size = new System.Drawing.Size(355, 29);
            this.lbl_kucukHarf.TabIndex = 3;
            this.lbl_kucukHarf.Text = "Küçük harf bulunmalı. (10/20p)";
            // 
            // lbl_rakam
            // 
            this.lbl_rakam.AutoSize = true;
            this.lbl_rakam.ForeColor = System.Drawing.Color.Red;
            this.lbl_rakam.Location = new System.Drawing.Point(13, 396);
            this.lbl_rakam.Name = "lbl_rakam";
            this.lbl_rakam.Size = new System.Drawing.Size(311, 29);
            this.lbl_rakam.TabIndex = 3;
            this.lbl_rakam.Text = "Rakam bulunmalı. (10/20p)";
            // 
            // lbl_sembol
            // 
            this.lbl_sembol.AutoSize = true;
            this.lbl_sembol.ForeColor = System.Drawing.Color.Red;
            this.lbl_sembol.Location = new System.Drawing.Point(13, 436);
            this.lbl_sembol.Name = "lbl_sembol";
            this.lbl_sembol.Size = new System.Drawing.Size(276, 29);
            this.lbl_sembol.TabIndex = 3;
            this.lbl_sembol.Text = "Sembol bulunmalı. (10p)";
            // 
            // lstBox_puan
            // 
            this.lstBox_puan.BackColor = System.Drawing.Color.Black;
            this.lstBox_puan.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstBox_puan.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstBox_puan.ForeColor = System.Drawing.Color.White;
            this.lstBox_puan.FormattingEnabled = true;
            this.lstBox_puan.ItemHeight = 39;
            this.lstBox_puan.Location = new System.Drawing.Point(385, 301);
            this.lstBox_puan.Name = "lstBox_puan";
            this.lstBox_puan.Size = new System.Drawing.Size(286, 121);
            this.lstBox_puan.TabIndex = 4;
            this.lstBox_puan.SelectedIndexChanged += new System.EventHandler(this.lstBox_puan_SelectedIndexChanged);
            // 
            // lstBox_mesaj
            // 
            this.lstBox_mesaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lstBox_mesaj.FormattingEnabled = true;
            this.lstBox_mesaj.ItemHeight = 29;
            this.lstBox_mesaj.Location = new System.Drawing.Point(41, 488);
            this.lstBox_mesaj.Name = "lstBox_mesaj";
            this.lstBox_mesaj.Size = new System.Drawing.Size(651, 91);
            this.lstBox_mesaj.TabIndex = 5;
            // 
            // lstBox_genelPuan
            // 
            this.lstBox_genelPuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lstBox_genelPuan.FormattingEnabled = true;
            this.lstBox_genelPuan.ItemHeight = 29;
            this.lstBox_genelPuan.Location = new System.Drawing.Point(41, 610);
            this.lstBox_genelPuan.Name = "lstBox_genelPuan";
            this.lstBox_genelPuan.Size = new System.Drawing.Size(651, 62);
            this.lstBox_genelPuan.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(748, 764);
            this.Controls.Add(this.lstBox_genelPuan);
            this.Controls.Add(this.lstBox_mesaj);
            this.Controls.Add(this.lstBox_puan);
            this.Controls.Add(this.lbl_sembol);
            this.Controls.Add(this.lbl_rakam);
            this.Controls.Add(this.lbl_kucukHarf);
            this.Controls.Add(this.lbl_buyukHarf);
            this.Controls.Add(this.lbl_minKarakter);
            this.Controls.Add(this.btn_kayitOl);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kAdi);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_kAdi);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Kayit Ol";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_kAdi;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.TextBox txt_kAdi;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Button btn_kayitOl;
        private System.Windows.Forms.Label lbl_minKarakter;
        private System.Windows.Forms.Label lbl_buyukHarf;
        private System.Windows.Forms.Label lbl_kucukHarf;
        private System.Windows.Forms.Label lbl_rakam;
        private System.Windows.Forms.Label lbl_sembol;
        private System.Windows.Forms.ListBox lstBox_puan;
        private System.Windows.Forms.ListBox lstBox_mesaj;
        private System.Windows.Forms.ListBox lstBox_genelPuan;
    }
}

