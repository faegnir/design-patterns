using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mimari_proje
{
    class Otel:IAbstractKonaklama
    {
        private int odaNo;
        public string Konaklama()
        {
            return "Otel";
        }
        public int OdaNo()
        {
            return odaNo;
        }
    }
}
