using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mimari_proje
{
    public interface IAbstractFactory
    {
        IAbstractUlasim UlasimBilgiDoldur();
        IAbstractKonaklama KonaklamaBilgiDoldur();
    }
}
