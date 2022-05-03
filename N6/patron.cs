using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N6
{
    class Patron : Employé
    {
        private double pourcentage;
        private static double ca;

        public static double Ca
        {
            get { return ca; }
            set { ca = value; }
        }

        public double Pourcentage
        {
            get { return pourcentage; }
            set { pourcentage = value; }
        }


        public Patron(int matricule, string nom, string prenom, DateTime dn, double p)
            : base(matricule, nom, prenom, dn)
        {
            this.pourcentage = p;
        }
 
        public override string ToString()
        {
            return "Patron: " + base.ToString() + " Pourcentage: " + pourcentage + "%";
        }
 
        public override double GetSalaire()
        {
            return (ca * pourcentage / 100);
        }
    }
}
