using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisme
{
    class Personne
    {
        private string nom, prenom;
        private DateTime date_de_naissance;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public DateTime DateDeNaissance
        {
            get { return date_de_naissance; }
            set { date_de_naissance = value; }
        }

        public Personne(string nom, string prenom, DateTime ddn)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.date_de_naissance = ddn;
        }

        public virtual void Afficher()
        {
            Console.Write("Nom : " + Nom + "Prénom : " + Prenom + "Date de naissance" + DateDeNaissance);
        }

    }
}
