using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisme
{
    class Directeur : Chef
    {

        private string société;
        public string Société
        {
            get { return société; }
            set { société = value; }
        }

        public Directeur(string nom, string prenom, DateTime ddn, double salaire, string service, string société)
            : base(nom, prenom, ddn, salaire, service)
        {
            this.société = société;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.Write(" Société : " + Société);
        }

    }
}
