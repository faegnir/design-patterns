using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mimari_proje
{
    public partial class FormHTML : Form
    {
       
        public FormHTML()
        {
            InitializeComponent();
            
        }

        private void FormHTML_Load(object sender, EventArgs e)
        {

            //webBrowser1.DocumentText = ;
            using (StreamReader read = new StreamReader("HtmlRapor.txt"))
            {
                while (true)
                {
                    string line = read.ReadLine();
                    if (line == null)
                        break;
                    webBrowser1.DocumentText = line;
                }

            }


        }
    }
}
