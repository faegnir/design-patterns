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
        public string Ulasim()
        {
            return "Uçak";
        }
        public string Nereden()
        {
            return nereden;
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
