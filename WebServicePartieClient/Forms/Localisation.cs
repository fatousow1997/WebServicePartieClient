using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebServicePartieClient.Forms
{
    public partial class Localisation : Form
    {
        public Localisation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


           
        }

     

        private void TextS_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string structure = Tsearch.Text;
            StringBuilder queryAdress = new StringBuilder();
            queryAdress.Append("http://google.com/maps?q=");
            if (structure != string.Empty)
            {
                queryAdress.Append(structure);
            }
            //WebBrowser.Navigate(queryAdress.ToString());
        }
    }
}
