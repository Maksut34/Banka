namespace Banka
{
    partial class KoBi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KoBi));
            this.btn_kredi_hesapla = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_TC = new System.Windows.Forms.TextBox();
            this.lbl_ekran = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kredi_hesapla
            // 
            this.btn_kredi_hesapla.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_kredi_hesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kredi_hesapla.Location = new System.Drawing.Point(447, 270);
            this.btn_kredi_hesapla.Name = "btn_kredi_hesapla";
            this.btn_kredi_hesapla.Size = new System.Drawing.Size(220, 44);
            this.btn_kredi_hesapla.TabIndex = 0;
            this.btn_kredi_hesapla.Text = "Müşteri Kredi Hesaplama";
            this.btn_kredi_hesapla.UseVisualStyleBackColor = false;
            this.btn_kredi_hesapla.Click += new System.EventHandler(this.btn_kredi_hesapla_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txt_TC
            // 
            this.txt_TC.BackColor = System.Drawing.Color.Black;
            this.txt_TC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_TC.ForeColor = System.Drawing.Color.White;
            this.txt_TC.Location = new System.Drawing.Point(474, 213);
            this.txt_TC.Name = "txt_TC";
            this.txt_TC.Size = new System.Drawing.Size(193, 29);
            this.txt_TC.TabIndex = 2;
            // 
            // lbl_ekran
            // 
            this.lbl_ekran.BackColor = System.Drawing.Color.Black;
            this.lbl_ekran.ForeColor = System.Drawing.Color.White;
            this.lbl_ekran.Location = new System.Drawing.Point(424, 82);
            this.lbl_ekran.Name = "lbl_ekran";
            this.lbl_ekran.Size = new System.Drawing.Size(278, 94);
            this.lbl_ekran.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "TC:";
            // 
            // KoBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(760, 444);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_ekran);
            this.Controls.Add(this.txt_TC);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_kredi_hesapla);
            this.Name = "KoBi";
            this.Text = "KoBi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kredi_hesapla;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_TC;
        private System.Windows.Forms.Label lbl_ekran;
        private System.Windows.Forms.Label label2;
    }
}