using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _21.DepoIslemleri;

namespace _21
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Depo depo = new Depo();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            depo.depoNo = int.Parse(tbDepoNo.Text);
            depo.depoAdi = tbDepoAdi.Text;
            depo.depoAdres = tbDepoAdres.Text;
            depo.telNo = tbDepoTel.Text;
            depo.depoKaydet(depo);
            Temizle();
        }

        private void Temizle()
        {
            tbDepoAdi.Clear();
            tbDepoAdres.Clear();
            tbDepoNo.Clear();
            tbDepoTel.Clear();
        }

        private void btnDepoyuGetir_Click(object sender, EventArgs e)
        {
            depo.depoGetir(depo);
            tbDepoNo.Text = depo.depoNo.ToString();
            tbDepoAdi.Text = depo.depoAdi;
            tbDepoAdres.Text = depo.depoAdres;
            tbDepoTel.Text = depo.telNo;
        }
    }
}
