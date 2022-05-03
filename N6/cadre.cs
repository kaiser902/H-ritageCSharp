using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N6
{
    class Cadre : Employé
    {
        private int indice;
        
        public int Indice
        {
            get { return indice; }
            set { indice = value; }
        }
 
        public Cadre(int matricule, string nom, string prenom, DateTime dn, int indice)
            : base(matricule, nom, prenom, dn)
        {
            this.indice = indice;
        }

        public override string ToString()
        {
            return "Cadre: " + base.ToString() + " Indice: " + indice;
        }

        public override double GetSalaire()
        {
            switch (indice)
            {
                case 1:
                    return 13000;
                case 2:
                    return 15000;
                case 3:
                    return 17000;
                case 4:
                    return 20000;
                default:
                    return -1;
            }
        }
    }
}
