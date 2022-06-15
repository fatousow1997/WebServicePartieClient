using System;
using System.Windows.Forms;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;

namespace WebServicePartieClient.Forms
{
    public partial class Acceuil : Form
    {
        public Acceuil()
        {
            InitializeComponent();
          HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:1997/");
            HttpResponseMessage response = client.GetAsync("structures/AllStructures").Result;
 
            dataGridView1.DataSource = response.Content.ReadAsAsync<List<Structures>>().Result;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Acceuil_Load(object sender, EventArgs e)
        {

        }
    }
}
