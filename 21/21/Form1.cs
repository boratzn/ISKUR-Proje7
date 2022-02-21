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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Eğer metodun parametresine zorunlu değer atanmasını istemiyorsak kullanılabilecek bir yöntemdir.
            //standartMetot(1,2);
            //opsiyonelMetot();
            int sonuc = toplam(5,10,"*");
            MessageBox.Show(sonuc.ToString());
        }

        void standartMetot(int x, int y)
        {
            MessageBox.Show("Zorunlu parametreler");
        }

        void opsiyonelMetot(int x = 0, int y = 0)
        {
            MessageBox.Show($"Parametreler opsiyoneldir.{x} ve {y}");
        }

        int toplam(int a, int b, string islem = "+")
        {
            int toplam = 0;
            if (islem == "+")
            {
                toplam = a + b;
            }else if(islem == "-")
            {
                toplam = a - b;
            }
            else if (islem == "*")
            {
                toplam = a * b;
            }
            else
            {
                toplam = a / b;
            }
            
            return toplam;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Parametrelerin adları belirtilerek yapılan metot işlemidir. Buradaki avantaj parametreleri sırasız bir şekilde isimlerini belirterek verilmesidir.
            sirasizParametreMetot(dogumYeri: "İstanbul", isim: "Bora", yas: 27);
        }

        public void sirasizParametreMetot(string isim, int yas, string dogumYeri)
        {
            string ad = isim;
            int yasi = yas;
            string dogumYer = dogumYeri;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //in keywordu sadece okunabilir yapar, metoda bir değer gönderilir bu değer metot içerisinde kullanılamaz
            inMetot(Math.PI, 3);
        }

        void inMetot(in double pi, int r)
        {
            //pi = 3  Bunu yapamayız başında in keywordu olduğu için değiştirilemez
            double sonuc = 2*pi* r;
            MessageBox.Show(sonuc.ToString());
        }
    }
}
