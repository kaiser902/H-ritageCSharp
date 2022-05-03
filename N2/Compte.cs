using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2
{
    class Compte
    {
        private int code;
        private double solde;
        private static int nb_compte = 0;

        public int Code
        {
            get { return code; }
        }

        public double Solde
        {
            get { return solde; }
        }

        public static int NbCompte
        {
            get { return nb_compte; }
        }


        public Compte()
        {
            nb_compte++;
            code = nb_compte;
            solde = 0;
        }

        public Compte(double solde)
        {
            nb_compte++;
            code = nb_compte;
            this.solde = solde;
        }

        public virtual void Deposer(double d)
        {
            solde += d;
        }

        public virtual void retirer(double r)
        {
            if (solde >= r)
            {
                solde -= r;
            }
        }

        public override string ToString()
        {
            return "Code : " + Code.ToString() + "  Solde : " + Solde.ToString();
        }
    }
}
