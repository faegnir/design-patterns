using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mimari_proje
{
    class Uçak:IAbstractUlasim
    {
        private string nereden;
        private string nereye;
        private string sirketAd;
        private DateTime gidisTarih;
        private DateTime donusTarih;
        public Uçak(string nereden,string nereye,string sirketAd, DateTime gidisTarih,DateTime donusTarih)
        {
            this.nereden = nereden;
            this.nereye = nereye;
            this.sirketAd = sirketAd;
            this.gidisTarih = gidisTarih;
            this.donusTarih = donusTarih;
        }
        public string GetUlasimTarihBilgi()
        {
            return gidisTarih.ToShortDateString()+" - "+ donusTarih.ToShortDateString();
        }
        public string GetUlasimLokasyonBilgi()
        {
            return nereden + " - " + nereye;
        }
        public string GetUlasimSirketBilgi()
        {
            return sirketAd;
        }
    }
}
