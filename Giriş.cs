using Bank_Entity;
using Bnk_DAL.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka
{
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }
        DataContext db = new DataContext();
        Çalışanlar çalı = new Çalışanlar();
        private void btn_giriş_Click(object sender, EventArgs e)
        {
            string ş=txt_şifre.Text;
            var şifre=db.Set<Çalışanlar>().Where(i=>i.password==ş).FirstOrDefault();
            if (txt_şifre.Text=="1" && txt_Bölümler.Text== "İnsan Kaynakları")
            {
                İ_K form= new İ_K();
                form.Show();
                this.Hide();
            }
            else if (şifre!=null && txt_Bölümler.Text == "Bireysel Bankacılık")
            {
                Bireysel bireysel= new Bireysel();
                bireysel.Show();
                this.Hide();
            }
            else if (şifre != null && txt_Bölümler.Text == "KOBİ Bankacılığı")
            {
                KoBi k=new KoBi();
                k.Show();
                this.Hide();
            }
            else if (şifre != null && txt_Bölümler.Text == "Kurumsal ve Ticari Bankacılık")
            {

            }
            else if (şifre != null && txt_Bölümler.Text == "Dış Ticaret ve Yatırım Bankacılığı")
            {

            }
            else if (şifre != null && txt_Bölümler.Text == "Özel Bankacılık")
            {

            } 
            else if (şifre != null && txt_Bölümler.Text == "İletişim")
            {

            }
            else if (şifre != null && txt_Bölümler.Text == "Mali Kontrol ve Planlama")
            {

            }
            else if (şifre != null && txt_Bölümler.Text == "Satın Alma ve Teknik Hizmetler Bölümü")
            {

            }
            else if (şifre != null && txt_Bölümler.Text == "İç Kontrol Merkezi")
            {

            }
            else
            {
                MessageBox.Show("Bölüm bulunamadı veya yanlış şifre!");
            }
           
        }
    }
}
