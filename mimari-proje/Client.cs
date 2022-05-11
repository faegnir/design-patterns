﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mimari_proje
{
    class Client
    {
        private IAbstractFactory _abstractFactory;
        private IAbstractKonaklama _konaklama;
        private IAbstractUlasim _ulasim;

        public Client(IAbstractFactory abstractFactory)
        {
            _abstractFactory = abstractFactory;
            _ulasim = _abstractFactory.UlasimBilgiDoldur();
            _konaklama = _abstractFactory.KonaklamaBilgiDoldur();
        }
        public string HTML_Rapor(string ad,string soyad,int tcNo)
        {
            string part1 = "<!DOCTYPE html><html><style>table, th, td {border: 1px solid black;}</style><body><h2> Seyehat Bilgileri </h2><table style = \"width:100%\"><tr><th> Kişisel Bilgiler </th><th> Ulaşım </th><th> Konaklama </th></tr><tr>";
            string part2 = "<td>" +ad+" "+soyad+" "+tcNo+"</td><td><table style = \"width:100%\"><tr><th> Ulaşım Tipi </th><th> Gidiş - Dönüş Tarihleri </th><th> Nereden Nereye </th><th> Şirket Adı </th></tr><tr><td> " + _ulasim.GetType().Name+ " </td> <td> "+ _ulasim.GetUlasimTarihBilgi()+" </td><td> "+ _ulasim.GetUlasimLokasyonBilgi()+" </td><td> "+_ulasim.GetUlasimSirketBilgi()+" </td></tr> ";
            string part3 = "</table></td><td><table style = \"width:100%\"><tr><th> Konaklama Tipi </th><th> Check In - Check Out Tarihleri</th></tr><tr><td> " + _konaklama.GetType().Name + " </td><td> " + _konaklama.GetKonaklamaBilgi() + "</td></tr></table></td></table><p> Bizi tercih ettiğiniz için teşekkür ederiz.</p></body></html>";
            string receiptContent = part1 + part2 + part3;
            return receiptContent;
        }
        public string XML_Rapor(string ad, string soyad, int tcNo)
        {
            string part1 = "<RAPOR>\n<KIMLIK>\n<Ad-Soyad>"+ad+" "+soyad+ "</Ad-Soyad>\n<TcNo>" + tcNo + "</TcNo>\n</KIMLIK>\n<ULAŞIM>\n<Tipi>" + _ulasim.GetType().Name + "</Tipi>\n<Tarihler>" + _ulasim.GetUlasimTarihBilgi() + "</Tarihler>\n<Ülkeler>" + _ulasim.GetUlasimLokasyonBilgi() + "</Ülkeler>\n<Firma>" + _ulasim.GetUlasimSirketBilgi() + "</Firma>\n</ULAŞIM>\n";
            string part2 = "<KONAKLAMA>\n<Tipi>" + _konaklama.GetType().Name + "</Tipi>\n<Check-In-Out>" + _konaklama.GetKonaklamaBilgi() + "</Check-In-Out>\n</KONAKLAMA>\n" + "</RAPOR>";
            string xmlReceipt = part1 + part2;
            return xmlReceipt;
        }
        public void JSON_Rapor()
        {
           
        }
        
    }
}
