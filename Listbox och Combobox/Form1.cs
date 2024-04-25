using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listbox_och_Combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Konverterar det i textboxen till ett URl och kollar om URL:et är valid
            string url = textBox1.Text;
            Uri uriresults;
            if (Uri.TryCreate(url, UriKind.Absolute, out uriresults) && (uriresults.Scheme == Uri.UriSchemeHttp || uriresults.Scheme == Uri.UriSchemeHttps))
            {
                webBrowser1.Url = uriresults;
            }
            else
            {
                MessageBox.Show("Invalid URL");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // skickar dig till google.com
            string url = "https://google.com";
            Uri uriresults;
            if (Uri.TryCreate(url,UriKind.Absolute, out uriresults) && (uriresults.Scheme == Uri.UriSchemeHttp || uriresults.Scheme == Uri.UriSchemeHttps))
            {
                webBrowser1.Url = uriresults;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Refreshar browsern
            webBrowser1.Refresh();
        }
    }
}
