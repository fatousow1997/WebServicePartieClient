using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServicePartieClient
{
  public  class Utilisateur
    {
     
      

        public String prenom { get; set; }
        public String nom { get; set; }
        public int tel { get; set; }
        public String login { get; set; }
        public String mdp { get; set; }
        public Utilisateur(string log, string pass)
        {
            this.login = log;
            this.mdp = pass;
        }

        public Utilisateur(string prenom, string nom, int tel, string login, string password)
        {
            this.prenom = prenom;
            this.nom = nom;
            this.tel = tel;
            this.login = login;
            this.mdp = password;

        }

        
    }
}
