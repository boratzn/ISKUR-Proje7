using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.DepoIslemleri
{
    public class Depo
    {
        public int depoNo { get; set; }
        public string depoAdi { get; set; }
        public string depoAdres { get; set; }
        public string telNo { get; set; }

        public Depo depoGetir(Depo dp)
        {
            Depo depo = new Depo();
            depo.depoNo = dp.depoNo;
            depo.depoAdi = dp.depoAdi;
            depo.depoAdres = dp.depoAdres;
            depo.telNo = dp.telNo;

            return depo;
        }
        
        public void depoKaydet(Depo dp)
        {
            this.depoNo = dp.depoNo;
            this.depoAdi=dp.depoAdi;
            this.telNo = dp.telNo;
            this.depoAdres=dp.depoAdres;
        }
    }
}
