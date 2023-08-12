namespace Banka
{
    partial class Giriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giriş));
            this.txt_şifre = new System.Windows.Forms.TextBox();
            this.btn_giriş = new System.Windows.Forms.Button();
            this.txt_Bölümler = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ana_sayfa = new System.Windows.Forms.Button();
            this.btn_hakkımızda = new System.Windows.Forms.Button();
            this.btn_iletişim = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_şifre
            // 
            this.txt_şifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_şifre.Location = new System.Drawing.Point(212, 196);
            this.txt_şifre.Name = "txt_şifre";
            this.txt_şifre.Size = new System.Drawing.Size(171, 32);
            this.txt_şifre.TabIndex = 0;
            // 
            // btn_giriş
            // 
            this.btn_giriş.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_giriş.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giriş.Location = new System.Drawing.Point(126, 270);
            this.btn_giriş.Name = "btn_giriş";
            this.btn_giriş.Size = new System.Drawing.Size(257, 45);
            this.btn_giriş.TabIndex = 1;
            this.btn_giriş.Text = "GİRİŞ";
            this.btn_giriş.UseVisualStyleBackColor = false;
            this.btn_giriş.Click += new System.EventHandler(this.btn_giriş_Click);
            // 
            // txt_Bölümler
            // 
            this.txt_Bölümler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Bölümler.FormattingEnabled = true;
            this.txt_Bölümler.Items.AddRange(new object[] {
            "Bireysel Bankacılık",
            "KOBİ Bankacılığı",
            "Kurumsal ve Ticari Bankacılık",
            "Dış Ticaret ve Yatırım Bankacılığı",
            "Özel Bankacılık",
            "Bilgi Teknolojileri",
            "İnsan Kaynakları",
            "İletişim",
            "Mali Kontrol ve Planlama",
            "Satın Alma ve Teknik Hizmetler Bölümü",
            "İç Kontrol Merkezi"});
            this.txt_Bölümler.Location = new System.Drawing.Point(212, 154);
            this.txt_Bölümler.Name = "txt_Bölümler";
            this.txt_Bölümler.Size = new System.Drawing.Size(171, 28);
            this.txt_Bölümler.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btn_iletişim);
            this.groupBox1.Controls.Add(this.btn_hakkımızda);
            this.groupBox1.Controls.Add(this.btn_ana_sayfa);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(506, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 513);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btn_ana_sayfa
            // 
            this.btn_ana_sayfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ana_sayfa.Location = new System.Drawing.Point(92, 85);
            this.btn_ana_sayfa.Name = "btn_ana_sayfa";
            this.btn_ana_sayfa.Size = new System.Drawing.Size(91, 39);
            this.btn_ana_sayfa.TabIndex = 0;
            this.btn_ana_sayfa.Text = "AnaSayfa";
            this.btn_ana_sayfa.UseVisualStyleBackColor = false;
            // 
            // btn_hakkımızda
            // 
            this.btn_hakkımızda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_hakkımızda.Location = new System.Drawing.Point(92, 145);
            this.btn_hakkımızda.Name = "btn_hakkımızda";
            this.btn_hakkımızda.Size = new System.Drawing.Size(91, 39);
            this.btn_hakkımızda.TabIndex = 0;
            this.btn_hakkımızda.Text = "Hakkımızda";
            this.btn_hakkımızda.UseVisualStyleBackColor = false;
            // 
            // btn_iletişim
            // 
            this.btn_iletişim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_iletişim.Location = new System.Drawing.Point(92, 205);
            this.btn_iletişim.Name = "btn_iletişim";
            this.btn_iletişim.Size = new System.Drawing.Size(91, 39);
            this.btn_iletişim.TabIndex = 0;
            this.btn_iletişim.Text = "İletişim";
            this.btn_iletişim.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 299);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bölümler:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre:";
            // 
            // Giriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(777, 509);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_Bölümler);
            this.Controls.Add(this.btn_giriş);
            this.Controls.Add(this.txt_şifre);
            this.Name = "Giriş";
            this.Text = "Giriş";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_şifre;
        private System.Windows.Forms.Button btn_giriş;
        private System.Windows.Forms.ComboBox txt_Bölümler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_iletişim;
        private System.Windows.Forms.Button btn_hakkımızda;
        private System.Windows.Forms.Button btn_ana_sayfa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}