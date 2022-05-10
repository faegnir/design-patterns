using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mimari_proje
{
    class Uçak_Otel:IAbstractFactory
    {
        public IAbstractUlasim Ulasim()
        {
            return new Uçak();
        }
        public IAbstractKonaklama Konaklama()
        {
            return new Otel();
        }
    }
}
