using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mimari_proje
{
    class Otobüs:IAbstractUlasim
    {
        private string nereden;
        private string nereye;
        private string sirketAd;
        public string Ulasim()
        {
            return "Otobüs";
        }
        public string Nereden(string nereden)
        {
            return this.nereden = nereden;
        }
        public string Nereye()
        {
            return nereye;
        }
        public string SirketAd()
        {
            return sirketAd;
        }
    }
}
