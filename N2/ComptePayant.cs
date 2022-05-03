using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2
{
    class ComptePayant : Compte
    {
        public ComptePayant()
            : base()
        {
        }

        public ComptePayant(double solde)
            : base(solde)
        {
        }

        public override string ToString()
        {
            return "Compte Payant : " + base.ToString();
        }

        public override void Deposer(double d)
        {
            base.Deposer(d);
        }

        public override void retirer(double r)
        {
            base.retirer(r);
            base.retirer(5);
        }
    }
}
