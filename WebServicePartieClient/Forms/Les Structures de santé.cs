using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Collections.Generic;
namespace WebServicePartieClient.Forms
{
    public partial class Les_Structures_de_santé : Form
    {
        public Les_Structures_de_santé()
        {
            InitializeComponent();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:1997/");
            HttpResponseMessage response = client.GetAsync("structures/AllStructures").Result;
            // dgvStruct.DataSource =response.Content.ReadAsAsync<IEnumerable<WebServicePartieClient.Structures>>().Result;
            List<Structures> st = response.Content.ReadAsAsync<List<Structures>>().Result;
            dgvStruct.DataSource = st;

            MessageBox.Show(st[0].nbrVaccinDispo);
        }
        

        private void Les_Structures_de_santé_Load(object sender, EventArgs e)
        {

        }

        private void dgvStruct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
