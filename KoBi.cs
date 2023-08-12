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
    public partial class KoBi : Form
    {
        public KoBi()
        {
            InitializeComponent();
        }
        DataContext db=new DataContext();
        Müşteriler m=new Müşteriler();
        private void btn_kredi_hesapla_Click(object sender, EventArgs e)
        {
            string müşteri=txt_TC.Text;

            var müş=db.Set<Müşteriler>().Where(i=>i.TC==müşteri).FirstOrDefault();

            if(müş!=null)
            {
                Random r=new Random();

                int sayı=r.Next(10000,500000);
                lbl_ekran.Text = sayı.ToString();
                txt_TC.Clear();

            }
            else
            {
                txt_TC.Clear();
                MessageBox.Show("Müşteri bulunamadı!");
            }
        }
    }
}
