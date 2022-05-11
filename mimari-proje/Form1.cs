using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            bool uygunUlasim = UygunUlasimRezervasyon(textBox1.Text,textBox2.Text,comboBox1.SelectedItem.ToString(),UlasimGidisDate.Value.ToShortDateString(),UlasimDonusDate.Value.ToShortDateString());
            bool uygunKonaklama = UygunKonaklamaRezervasyon(KonakStartDate.Value.ToShortDateString(),KonakEndDate.Value.ToShortDateString());

            if (Uçak.Checked && otel.Checked && uygunKonaklama && uygunUlasim)
            {
                Client rezervasyonYap = new Client(new Uçak_Otel(textBox1.Text, textBox2.Text, comboBox1.SelectedItem.ToString(), UlasimGidisDate.Value, UlasimDonusDate.Value, KonakStartDate.Value, KonakEndDate.Value));
                webBrowser1.DocumentText = rezervasyonYap.HTML_Rapor(adTxt.Text, soyadTxt.Text, Convert.ToInt32(tcNoTxt.Text));
            }
            else if (Uçak.Checked && cadir.Checked && uygunKonaklama && uygunUlasim)
            {
                Client rezervasyonYap = new Client(new Uçak_Çadır(textBox1.Text, textBox2.Text, comboBox1.SelectedItem.ToString(), UlasimGidisDate.Value, UlasimDonusDate.Value, KonakStartDate.Value, KonakEndDate.Value));
                webBrowser1.DocumentText = rezervasyonYap.HTML_Rapor(adTxt.Text, soyadTxt.Text, Convert.ToInt32(tcNoTxt.Text));
            }
            else if (otobus.Checked && otel.Checked && uygunKonaklama && uygunUlasim)
            {
                Client rezervasyonYap = new Client(new Otobüs_Otel(textBox1.Text, textBox2.Text, comboBox1.SelectedItem.ToString(), UlasimGidisDate.Value, UlasimDonusDate.Value, KonakStartDate.Value, KonakEndDate.Value));
                webBrowser1.DocumentText = rezervasyonYap.HTML_Rapor(adTxt.Text, soyadTxt.Text, Convert.ToInt32(tcNoTxt.Text));
            }
            else if (otobus.Checked&&cadir.Checked && uygunKonaklama && uygunUlasim)
            {
                Client rezervasyonYap = new Client(new Otobüs_Çadır(textBox1.Text, textBox2.Text, comboBox1.SelectedItem.ToString(), UlasimGidisDate.Value, UlasimDonusDate.Value, KonakStartDate.Value, KonakEndDate.Value));
                webBrowser1.DocumentText = rezervasyonYap.HTML_Rapor(adTxt.Text, soyadTxt.Text, Convert.ToInt32(tcNoTxt.Text));
            }
            else
                MessageBox.Show("Hata!", "Hata!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

        }
        private bool UygunUlasimRezervasyon(string nereden, string nereye, string sirket, string gidisTarih, string donusTarih)
        {
            string fileName = @"UlasimData.txt";

            string[] lines = File.ReadAllLines(fileName);
            foreach (string satır in lines)
            {
                if (satır.Contains(nereden + " " + nereye + " " + sirket + " " + gidisTarih + " " + donusTarih))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Uygun rezervasyon bulunamadı.", "Hata!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return false;
                }
            }
            return false;
        }
        private bool UygunKonaklamaRezervasyon(string baslangicTarih, string bitisTarih)
        {
            string fileName = @"KonaklamaData.txt";
            string[] lines = File.ReadAllLines(fileName);
            foreach (string satır in lines)
            {
                if (satır.Contains(baslangicTarih + " " + bitisTarih))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Uygun rezervasyon bulunamadı.", "Hata!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return false;

                }
            }
            return false;    
        }
    }
}
