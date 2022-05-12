using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mimari_proje
{
    class JSONclass
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Konaklama
        {
            public string tipi { get; set; }
            public string inOutTarih { get; set; }
        }

        public class Root
        {
            public string ad { get; set; }
            public string soyad { get; set; }
            public int tcNo { get; set; }
            public Ulaşım Ulaşım { get; set; }
            public Konaklama Konaklama { get; set; }
        }

        public class Ulaşım
        {
            public string tipi { get; set; }
            public string tarihi { get; set; }
            public string ülkeler { get; set; }
            public string firma { get; set; }
        }


    }
}
