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
using System.Xml.Linq;

namespace Banka
{
    public partial class İ_K : Form
    {
        public İ_K()
        {
            InitializeComponent();
        }

        DataContext db= new DataContext();
        Çalışanlar çalı = new Çalışanlar();
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            string tc = txt_TC.Text;
            string Email=txt_email.Text;
            
            var test = db.Set<Çalışanlar>().Where(i => i.TC==tc&&i.email==Email).FirstOrDefault();
            if (test == null)
            {
                çalı.name=txt_ad.Text;
                çalı.surname=txt_soyad.Text;
                çalı.GSM=txt_GSM.Text;
                çalı.TC=txt_TC.Text;
                çalı.email=txt_email.Text;
                çalı.adres=txt_adres.Text;
                çalı.bölümü=txt_bölüm.Text;
                çalı.password=txt_şifre.Text;
                db.Set<Çalışanlar>().Add(çalı);
                db.SaveChanges();
                silme();
                dataGridView1.DataSource = db.Set<Çalışanlar>().ToList();
                MessageBox.Show("Kayıt tamamlandı!");
                
            }
            else
            {
                dataGridView1.DataSource = db.Set<Çalışanlar>().ToList();
                MessageBox.Show("Hata!! Aynı TC veye email..!");
                silme();
            }
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            string sil = txt_TC.Text;
            var delete = db.Set<Çalışanlar>().Where(i=>i.TC==sil).FirstOrDefault();
            if (delete != null)
            {
                
                db.Set<Çalışanlar>().Remove(delete);
                db.SaveChanges();
                
                dataGridView1.DataSource = db.Set<Çalışanlar>().ToList();
                MessageBox.Show("Veri Silindi!");
                silme();
            }
            else
            {
                dataGridView1.DataSource = db.Set<Çalışanlar>().ToList();
                MessageBox.Show("Hata!");
                silme();
            }
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            string tc = txt_TC.Text;


            var güncel = db.Set<Çalışanlar>().Where(i => i.TC == tc).FirstOrDefault();
            if (güncel != null)
            {
                güncel.name = txt_ad.Text;
                güncel.surname=txt_soyad.Text;
                güncel.GSM=txt_GSM.Text;
                güncel.TC=txt_TC.Text;
                güncel.email=txt_email.Text;
                güncel.adres = txt_adres.Text;
                güncel.bölümü=txt_bölüm.Text;
                güncel.password=txt_şifre.Text;
                
                db.SaveChanges();
                silme();

                MessageBox.Show("Güncelleme gerçekleşti!");
                dataGridView1.DataSource = db.Set<Çalışanlar>().ToList();
            }
            else
            {
                MessageBox.Show("Hata!");
            }
        }
        private void btn_Liste_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=db.Set<Çalışanlar>().ToList();
        }

        private void silme()
        {
            
            txt_ad.Clear() ;
            txt_adres.Clear() ;
            txt_email.Clear() ;
            txt_GSM.Clear() ;
            txt_soyad.Clear() ;
            txt_TC.Clear() ;
            txt_şifre.Clear() ;
        }

        private void btn_çıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
