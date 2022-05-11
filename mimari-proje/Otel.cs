using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mimari_proje
{
    class Otel:IAbstractKonaklama
    {
        
        private DateTime baslangicTarihi;
        private DateTime bitisTarihi;

        public Otel(DateTime baslangicTarihi,DateTime bitisTarihi)
        {
            this.baslangicTarihi = baslangicTarihi;
            this.bitisTarihi = bitisTarihi;
        }
        public string GetKonaklamaBilgi()
        {
            return baslangicTarihi.ToShortDateString() +" "+ bitisTarihi.ToShortDateString();
        }
    }
}
