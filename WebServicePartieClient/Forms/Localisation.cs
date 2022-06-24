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

        private void btnCherche_Click(object sender, EventArgs e)
        {
            string structure = textS.Text; 
            StringBuilder queryAdress = new StringBuilder();
            queryAdress.Append("http://google.com/maps?q=");
            if (structure != string.Empty)
            {
                queryAdress.Append(structure);
            }
            
           //  WebBrowser1.Navigate(queryAdress.ToString());
        }
    }
}
