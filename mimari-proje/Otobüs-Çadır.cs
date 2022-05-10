using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mimari_proje
{
    class Otobüs_Çadır:IAbstractFactory
    {
        Otobüs otobüs;
        public IAbstractUlasim Ulasim()
        {
            //otobüs.Nereden()
            return new Otobüs();
        }
        public IAbstractKonaklama Konaklama()
        {
            return new Çadır();
        }
    }
}
