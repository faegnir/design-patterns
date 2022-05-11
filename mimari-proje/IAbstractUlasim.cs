using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mimari_proje
{
    public interface IAbstractUlasim
    {
        string GetUlasimTarihBilgi();
        string GetUlasimLokasyonBilgi();
        string GetUlasimSirketBilgi();
    }
}
