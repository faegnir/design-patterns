using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace mimari_proje
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string ulasim,konaklama;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 1)
            {
                if (ucakButton.Checked && otelButton.Checked)
                {
                    ulasim = ucakButton.Text;
                    konaklama = otelButton.Text;
                }
                else if (ucakButton.Checked && cadirButton.Checked)
                {
                    ulasim = ucakButton.Text;
                    konaklama = cadirButton.Text;
                }
                else if (otoButton.Checked && otelButton.Checked)
                {
                    ulasim = otoButton.Text;
                    konaklama = otelButton.Text;
                }
                else if (otoButton.Checked && cadirButton.Checked)
                {
                    ulasim = otoButton.Text;
                    konaklama =cadirButton.Text;
                }
            }
           
            if (textBox1.Text.Length > 1 && ulasim != null && konaklama != null)
            {
                string search_text = textBox1.Text;
                string old;
                string n = "";
                string d = "";
                StreamReader sr = File.OpenText(ulasim + ".txt");
                if (File.ReadAllText(ulasim + ".txt").Contains(search_text))
                {
                    while ((old = sr.ReadLine()) != null)
                    {
                        if (!old.Contains(search_text))
                        {
                            n += old + Environment.NewLine;
                        }
                    }
                    sr.Close();
                    File.WriteAllText(ulasim + ".txt", n);
                    MessageBox.Show(ulasim + " rezervasyonunuz iptal edildi.");
                }
                else
                {
                    MessageBox.Show(ulasim + " için kayıt bulunamadı.");
                }
                StreamReader kr = File.OpenText(konaklama + ".txt");
                if (File.ReadAllText(konaklama + ".txt").Contains(search_text))
                {
                    while ((old = kr.ReadLine()) != null)
                    {
                        if (!old.Contains(search_text))
                        {
                            d += old + Environment.NewLine;
                        }
                    }
                    kr.Close();
                    File.WriteAllText(konaklama + ".txt", d);
                    MessageBox.Show(konaklama + " rezervasyonunuz iptal edildi.");
                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.Show();
                }
                else
                {
                    MessageBox.Show(konaklama + " için kayıt bulunamadı.");
                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.Show();
                }
            }
            else
                MessageBox.Show("HATA, HATA");
        }
    }
}
