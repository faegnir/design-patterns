using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mimari_proje
{
    class Otobüs_Otel:IAbstractFactory
    {

        private DateTime baslangicTarihi;
        private DateTime bitisTarihi;

        private DateTime gidisTarihi;
        private DateTime donusTarihi;
        private string nereden;
        private string nereye;
        private string sirketAd;
        public Otobüs_Otel(string nereden, string nereye, string sirket, DateTime baslangicTarihi, DateTime bitisTarihi, DateTime gidis, DateTime donus)
        {
            this.nereden = nereden;
            this.nereye = nereye;
            this.sirketAd = sirket;
            this.baslangicTarihi = baslangicTarihi;
            this.bitisTarihi = bitisTarihi;
            this.gidisTarihi = gidis;
            this.donusTarihi = donus;
        }
        public IAbstractUlasim UlasimBilgiDoldur()
        {
            return new Otobüs(this.nereden, this.nereye, this.sirketAd, this.gidisTarihi, this.donusTarihi);
        }
        public IAbstractKonaklama KonaklamaBilgiDoldur()
        {
            return new Otel(this.baslangicTarihi, this.bitisTarihi);
        }
    }
}
