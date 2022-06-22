using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Net.Http;
using Newtonsoft.Json;

namespace WebServicePartieClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_click(object sender, EventArgs e)
        {
            textBox1.BackColor= Color.White;
            panel3.BackColor= Color.White;
            panel4.BackColor = SystemColors.Control;
            textBox2.BackColor=SystemColors.Control;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel3.BackColor = SystemColors.Control;
            textBox1.BackColor = SystemColors.Control;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fenetrePrincipal f=new fenetrePrincipal();
            f.ShowDialog();
        }
        private static readonly string baseUrl = "http://localhost:1997/";
        public static async Task<string> Inscription(Utilisateur utilisateur)
        {
          
            using (HttpClient client = new HttpClient())
            {
                var u = new Dictionary<string, dynamic>
                {
                   
                    {"prenom",utilisateur.prenom},
                    {"nom",utilisateur.nom},
                    {"tel",utilisateur.tel},
                    {"login",utilisateur.login},
                    {"mdp",utilisateur.mdp}

                };
                var json = JsonConvert.SerializeObject(u);
                var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");

                using (HttpResponseMessage res = await client.PostAsync(baseUrl + "utilisateurs/AjouterUser", stringContent))

                {


                    using (HttpContent content = res.Content)
                    {
                        Console.WriteLine("éééééééééé:::: " + res);




                        String data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }
        private void button2_Click(object sender, EventArgs e)
        {

            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
