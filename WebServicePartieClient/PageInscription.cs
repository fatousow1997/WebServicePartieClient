using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebServicePartieClient
{
    public partial class PageInscription : Form
    {
        public PageInscription()
        {
            InitializeComponent();
        }

        private void textlogin_TextChanged(object sender, EventArgs e)
        {

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
       

        private void PageInscription_Load(object sender, EventArgs e)
        {

        }

        private async void btnInscrire_Click(object sender, EventArgs e)
        {
            

        }

        private async void btnInscrire_Click_1(object sender, EventArgs e)
        {
            Utilisateur user = new Utilisateur(textPrenom.Text, textN.Text, int.Parse(textTel.Text), textlogin.Text, textpassword.Text);
            //MessageBox.Show("ok" + user.login);

            var response = await Inscription(user);
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
