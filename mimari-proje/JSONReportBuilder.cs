using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mimari_proje
{
    class JSONReportBuilder : IReportBuilder
    {
        private ProductJSON jsonRapor = new ProductJSON();

        public JSONReportBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this.jsonRapor = new ProductJSON();
        }
        public void BuildPartA(string ad, string soyad, string tcNo)
        {
            string part1 = "<RAPOR>\n<KIMLIK>\n<Ad-Soyad>"+ad+" "+soyad+ "</Ad-Soyad>\n<TcNo>" + tcNo + "</TcNo>\n</KIMLIK>\n<ULAŞIM>\n<Tipi>";
            this.jsonRapor.Add(part1);
        }
        public void BuildPartB(string ulasimTipi, string tarih, string lokasyon, string sirket)
        {
            string part2 = ulasimTipi + "</Tipi>\n<Tarihler>" + tarih + "</Tarihler>\n<Ülkeler>" + lokasyon + "</Ülkeler>\n<Firma>" + sirket + "</Firma>\n<Ücret>50 TL</Ücret>\n</ULAŞIM>\n";
            this.jsonRapor.Add(part2);

        }
        public void BuildPartC(string konaklamaTipi, string konaklamaBilgi)
        {
            string part3 = "<KONAKLAMA>\n<Tipi>" + konaklamaTipi + "</Tipi>\n<Check-In-Out>" + konaklamaBilgi + "</Check-In-Out>\n<Ücret>150 TL</Ücret>\n</KONAKLAMA>\n" + "</RAPOR>";
            this.jsonRapor.Add(part3);
        }
        public ProductJSON GetProduct()
        {
            ProductJSON sonuç = this.jsonRapor;

            this.Reset();

            return sonuç;
        }
    }
}
