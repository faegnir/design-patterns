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
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
        }

        private void htmlButton_Click(object sender, EventArgs e)
        {
            FormHTML formHTML = new FormHTML();
            this.Hide();
            formHTML.Show();
        }

        private void xmlButton_Click(object sender, EventArgs e)
        {
            FormXML formXML = new FormXML();
            this.Hide();
            formXML.Show();
        }

        private void jsonButton_Click(object sender, EventArgs e)
        {

        }
    }
}
