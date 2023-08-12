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
    public partial class Bireysel : Form
    {
        public Bireysel()
        {
            InitializeComponent();
        }
        DataContext db=new DataContext();
        Müşteriler m=new Müşteriler();

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            string tc = txt_tc.Text;
            string Email = txt_email.Text;
            
            var test = db.Set<Müşteriler>().Where(i => i.TC == tc && i.email == Email).FirstOrDefault();
            if (test == null)
            {
                m.name = txt_Ad.Text;
                m.surname = txt_soyad.Text;
                m.GSM = txt_gsm.Text;
                m.TC = txt_tc.Text;
                m.email = txt_email.Text;
                m.adres = txt_adres.Text;
                m.password = txt_şifre.Text;
                db.Set<Müşteriler>().Add(m);
                db.SaveChanges();
                silme();
                dataGridView1.DataSource = db.Set<Müşteriler>().ToList();
                MessageBox.Show("Kayıt tamamlandı!");

            }
            else
            {
                silme();
                dataGridView1.DataSource = db.Set<Müşteriler>().ToList();
                MessageBox.Show("Hata!! Aynı TC veye email..!");

            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            string sil = txt_tc.Text;
            var delete = db.Set<Müşteriler>().Where(i => i.TC == sil).FirstOrDefault();
            if (delete != null)
            {

                db.Set<Müşteriler>().Remove( delete);
                db.SaveChanges();
                silme();
                dataGridView1.DataSource = db.Set<Müşteriler>().ToList();
                MessageBox.Show("Veri Silindi!");
                
            }
            else
            {
                dataGridView1.DataSource = db.Set<Müşteriler>().ToList();
                MessageBox.Show("Hata!");
                silme();
            }
        }

        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            string tc = txt_tc.Text;
            

            var test = db.Set<Müşteriler>().Where(i => i.TC == tc).FirstOrDefault();
            if (test != null)
            {
                m.name = txt_Ad.Text;
                m.surname = txt_soyad.Text;
                m.GSM = txt_gsm.Text;
                m.TC = txt_tc.Text;
                m.email = txt_email.Text;
                m.adres = txt_adres.Text;
                m.password = txt_şifre.Text;
                
                db.SaveChanges();
                silme();
                dataGridView1.DataSource = db.Set<Müşteriler>().ToList();
                MessageBox.Show("Kayıt tamamlandı!");

            }
            else
            {
                silme();
                dataGridView1.DataSource = db.Set<Müşteriler>().ToList();
                MessageBox.Show("Hata!! Aynı TC veye email..!");

            }
        }
        private void silme()
        {
            
            txt_Ad.Clear();
            txt_adres.Clear();
            txt_email.Clear();
            txt_gsm.Clear();
            txt_soyad.Clear();
            txt_tc.Clear();
            txt_şifre.Clear();
        }
    }
}
