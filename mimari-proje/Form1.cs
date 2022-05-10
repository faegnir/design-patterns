using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mimari_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            IAbstractKonaklama konaklama;
            IAbstractUlasim ulaşım;
            if (Uçak.Checked && otel.Checked)
            {
                IAbstractFactory factory = new Uçak_Otel();
                konaklama = factory.Konaklama();
                ulaşım = factory.Ulasim();
                // MessageBox.Show(konaklama.Konaklama() + " " + ulaşım.Ulasim());
            }
            else if (Uçak.Checked && cadir.Checked)
            {
                IAbstractFactory factory = new Uçak_Çadır();
                konaklama = factory.Konaklama();
                ulaşım = factory.Ulasim();
            }
            else if (otobus.Checked && otel.Checked)
            {
                IAbstractFactory factory = new Otobüs_Otel();
                konaklama = factory.Konaklama();
                ulaşım = factory.Ulasim();
            }
            else
            {
                IAbstractFactory factory = new Otobüs_Çadır();
                konaklama = factory.Konaklama();
                ulaşım = factory.Ulasim();
            }
            string ad = adTxt.Text;
            string soyad = soyadTxt.Text;
            string tcNo = tcNoTxt.Text;
            var UlasimStartDate = UlasimGidisDate.Value.ToShortDateString();
            var UlasimEndDate = UlasimDonusDate.Value.ToShortDateString();
            var KonaklamaStartDate = KonakStartDate.Value.ToShortDateString();
            var KonaklamaEndDate = KonakEndDate.Value.ToShortDateString();

            // String checkedUlasim = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            //String checkedKonaklama = groupBox2.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            MessageBox.Show(UlasimStartDate + " " + UlasimEndDate + "\n" + ulaşım.Ulasim() + " " + konaklama.Konaklama());
            printHTML(ulaşım.Ulasim(), konaklama.Konaklama(), UlasimStartDate, UlasimEndDate, KonaklamaStartDate, KonaklamaEndDate, ad, soyad, tcNo);
        }
        void printHTML(string ulasim, string konaklama, string ulasimStart, string ulasimEnd, string konaklamaStart, string konaklamaEnd, string ad, string soyad, string tcNo)
        {
            string part1 = "<!DOCTYPE html><html><head><style>table {border-collapse: collapse;}table, td, th {border: 1px solid black;}</style></head><body style='font-family:cambria;font-size:12px'><div  style='border-style:solid;border-width:1px;height:400px;text-align:center'><header style='bottom-border-style:solid;bottom-border-width:1px;bottom-border-color:#333'><span style='font-size:13px'>";
            string part2 = ulasim + "<br></span>";
            string part3 = konaklama + "<hr style='color:#333'></header><div><table><tr ><td><b>Başlangıç Tarihi</b></td><td>" + konaklamaStart + "</td><td> <label style='padding-right:5%'><b>Bitiş Tarihi</b></label></td><td><label style='padding-right:20%'>" + konaklamaEnd + " </label></td></tr><tr><td><b> GST ID</b></td><td colspan='3'><p style='text-align:left'>";
            string receiptContent = part1 + part2 + part3;
            //richTextBox1.Text = receiptContent;
            webBrowser1.DocumentText = receiptContent;
        }
    }
}
