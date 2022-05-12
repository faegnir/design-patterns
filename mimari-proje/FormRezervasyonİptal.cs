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
    public partial class FormRezervasyonİptal : Form
    {
        public FormRezervasyonİptal()
        {
            InitializeComponent();
        }
        string ulasim,konaklama;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 1)
            {
                if (ucakButton.Checked )
                {
                    ulasim = ucakButton.Text;
                }
                else if (cadirButton.Checked)
                {
                    konaklama = cadirButton.Text;
                }
                else if ( otelButton.Checked)
                {
                    konaklama = otelButton.Text;
                }
                else if (otoButton.Checked)
                {
                    ulasim = otoButton.Text;
                }
            }
            if (ulasim != null && textBox1.Text.Length > 1)
            {
                if (cadirButton.Checked)
                {
                    konaklama = cadirButton.Text;
                }
                else if (otelButton.Checked)
                {
                    konaklama = otelButton.Text;
                }
            }
            else if (konaklama != null && textBox1.Text.Length > 1)
            {
                if (ucakButton.Checked)
                {
                    ulasim = ucakButton.Text;
                }
                else if (otoButton.Checked)
                {
                    ulasim = otoButton.Text;
                }
            }
           
            if (textBox1.Text.Length > 1 && ulasim != null)
            {
                txte();
            }
            else if (textBox1.Text.Length > 1 && konaklama != null)
            {
                txte();
            }
            else if (textBox1.Text.Length > 1 && ulasim != null && konaklama != null)
            {
                txte();
            }
            else
                MessageBox.Show("Alanlar boş bırakılamaz!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRezervasyon formRezervasyon = new FormRezervasyon();
            this.Hide();
            formRezervasyon.Show();
        }

        void txte()
        {
            string search_text = textBox1.Text;
            string old;
            string n = "";
            string d = "";
            if (ulasim != null)
            {
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
            }
            if (konaklama != null)
            {
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
                    //this.Hide();
                    //FormRezervasyon FormRezervasyon = new FormRezervasyon();
                    //FormRezervasyon.Show();
                }
                else
                {
                    MessageBox.Show(konaklama + " için kayıt bulunamadı.");
                    //this.Hide();
                    //FormRezervasyon FormRezervasyon = new FormRezervasyon();
                    //FormRezervasyon.Show();
                }
            }
            this.Hide();
            FormRezervasyon FormRezervasyon = new FormRezervasyon();
            FormRezervasyon.Show();
        }
    }
}
