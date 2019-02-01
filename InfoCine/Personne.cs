using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoCine
{
    class Personne
    {
        private string prenom;
        private string nom;
        private DateTime dateNaissance;
        private string email;

        public string Prenom { get => prenom; set => prenom = value; }
        public string Nom { get => nom; set => nom = value; }
        public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }
        public string Email { get => email; set => email = value; }
        public string NomComplet { get => Prenom + " " + Nom; }

        public Personne()
        {
        }

        public Personne(string prenom, string nom)
        {
            Prenom = prenom;
            Nom = nom;
        }

        public Personne(string prenom, string nom, DateTime dateNaissance, string email) : this(prenom, nom)
        {
            DateNaissance = dateNaissance;
            Email = email;
        }
         
    }
}
