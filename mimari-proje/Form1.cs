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
            if (adTxt.Text.Length > 0 || soyadTxt.Text.Length > 0 || tcNoTxt.Text.Length > 0)
            {
                if (Uçak.Checked && otel.Checked)
                {
                    Client rezervasyonYap = new Client(new Uçak_Otel(neredenTxt.Text, nereyeTxt.Text, comboBox1.SelectedItem.ToString(), UlasimGidisDate.Value, UlasimDonusDate.Value, KonakStartDate.Value, KonakEndDate.Value));
                    webBrowser1.DocumentText = rezervasyonYap.HTML_Rapor(adTxt.Text, soyadTxt.Text, Convert.ToInt32(tcNoTxt.Text));
                    kaydet(Uçak.Text, otel.Text, Convert.ToInt32(tcNoTxt.Text));
                }
                else if (Uçak.Checked && cadir.Checked)
                {
                    Client rezervasyonYap = new Client(new Uçak_Çadır(neredenTxt.Text, nereyeTxt.Text, comboBox1.SelectedItem.ToString(), UlasimGidisDate.Value, UlasimDonusDate.Value, KonakStartDate.Value, KonakEndDate.Value));
                    webBrowser1.DocumentText = rezervasyonYap.HTML_Rapor(adTxt.Text, soyadTxt.Text, Convert.ToInt32(tcNoTxt.Text));
                    kaydet(Uçak.Text, cadir.Text, Convert.ToInt32(tcNoTxt.Text));
                }
                else if (otobus.Checked && otel.Checked)
                {
                    Client rezervasyonYap = new Client(new Otobüs_Otel(neredenTxt.Text, nereyeTxt.Text, comboBox1.SelectedItem.ToString(), UlasimGidisDate.Value, UlasimDonusDate.Value, KonakStartDate.Value, KonakEndDate.Value));
                    webBrowser1.DocumentText = rezervasyonYap.HTML_Rapor(adTxt.Text, soyadTxt.Text, Convert.ToInt32(tcNoTxt.Text));
                    kaydet(otobus.Text, otel.Text, Convert.ToInt32(tcNoTxt.Text));
                }
                else if (otobus.Checked && cadir.Checked)
                {
                    Client rezervasyonYap = new Client(new Otobüs_Çadır(neredenTxt.Text, nereyeTxt.Text, comboBox1.SelectedItem.ToString(), UlasimGidisDate.Value, UlasimDonusDate.Value, KonakStartDate.Value, KonakEndDate.Value));
                    webBrowser1.DocumentText = rezervasyonYap.HTML_Rapor(adTxt.Text, soyadTxt.Text, Convert.ToInt32(tcNoTxt.Text));
                    kaydet(otobus.Text, cadir.Text, Convert.ToInt32(tcNoTxt.Text));
                }
                else
                    MessageBox.Show("Hata!", "Hata!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Kişisel verilerinizi girin.");

        }
        void kaydet(string ulasim, string konaklama,int tcNo)
        {
           // File.AppendAllText((ulasim + ".txt"), "aaaaaaaaaaaa" + Environment.NewLine);
            using (StreamWriter writer = new StreamWriter(ulasim +".txt", append: true))
            {
                writer.WriteLine(tcNoTxt.Text + " / " + neredenTxt.Text + " - " + nereyeTxt.Text + " / " + comboBox1.SelectedItem.ToString());
            }
            using (StreamWriter writer2 = new StreamWriter(konaklama + ".txt", append: true))
            {
                writer2.WriteLine(tcNoTxt.Text + " / " + KonakStartDate.Value.ToShortDateString() + " - " + KonakEndDate.Value.ToShortDateString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }
    }
}
            //string fileName = @"KonaklamaData.txt";
            //string[] lines = File.ReadAllLines(fileName);
             //foreach (string satır in lines)
