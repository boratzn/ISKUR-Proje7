using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Dictionary<int, string> temp = new Dictionary<int, string>();
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            ButonKoordinatlariniAyarla();
        }

        private void ButonKoordinatlariniAyarla()
        {
            Random rnd = new Random();
            int genislik = rnd.Next(0, this.Width - btnBeniYakala.Width);
            int yükseklik = rnd.Next(0, this.Height - btnBeniYakala.Height);
            btnBeniYakala.Location = new Point(genislik, yükseklik);
        }

        private void btnBeniYakala_Click(object sender, EventArgs e)
        {
            temp.Add(sayac, "Başarılı");
            sayac++;
            if (sayac == 5)
            {
                oyunSonu();
            }
        }

        private void Form3_Click(object sender, EventArgs e)
        {
           
            temp.Add(sayac, "Başarısız");
            sayac++;
            if (sayac == 5)
            {
                oyunSonu();
            }
        }

        void oyunSonu()
        {
            int basarili = 0;
            foreach (var item in temp)
            {
                if (item.Value.Equals("Başarılı"))
                {
                    basarili++;
                }
            }

            if (basarili >= 3)
            {
                timer1.Stop();
                visibleSettings();
                MessageBox.Show("Oyunu Kazandınız!!!!");
            }
            else
            {
                timer1.Stop();
                visibleSettings();
                MessageBox.Show("Oyunu Kaybettiniz!!!");
            }

            sayac = 0;
            temp.Clear();
        }

        private void visibleSettings()
        {
            btnBeniYakala.Visible = false;
            btnBasla.Visible = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            btnBeniYakala.Visible = false;  
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            btnBasla.Visible = false;
            btnBeniYakala.Visible = true;   
            timer1.Start();

        }
    }
}
