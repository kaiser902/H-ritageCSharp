using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisme
{
    class Employé : Personne
    {
        private double salaire;
        public double Salaire
        {
            get { return salaire; }
            set { salaire = value; }
        }

        public Employé(string nom, string prenom, DateTime ddn, double salaire)
            : base(nom, prenom, ddn)
        {
            this.salaire = salaire;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.Write(" Salaire : " + Salaire);
        }

    }
}
