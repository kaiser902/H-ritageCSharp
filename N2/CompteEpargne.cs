using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2
{
    class CompteEpargne : Compte
    {
        private double tauxinteret = 6;
        public double Tauxinteret
        {
            get { return tauxinteret; }
        }

        public CompteEpargne() : base()
        {
        }

        public CompteEpargne(double solde)
            : base(solde)
        {
        }

        public void CalculerInteret()
        {
            Deposer((Solde * (1 + (tauxinteret / 100))));
        }

        public override string ToString()
        {
            return "Compte Epargne : " + base.ToString() + " Taux interet : " + tauxinteret;
        }
    }
}
