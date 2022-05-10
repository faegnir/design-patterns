using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mimari_proje
{
    class Uçak:IAbstractUlasim
    {
        private string nereye;
        private string nereden;
        public string Ulasim()
        {
            return "Uçak";
        }
        public string Nereye()
        {
            return nereye;
        }
        public string Nereden()
        {
            return nereden;
        }
    }
}
