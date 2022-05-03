using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisme
{
    class Chef : Employé
    {
        private string service;
        public string Service
        {
            get { return service; }
            set { service = value; }
        }

        public Chef(string nom, string prenom, DateTime ddn, double salaire, string service)
            : base(nom, prenom, ddn, salaire)
        {
            this.service = service;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.Write(" Service : " + Service);
        }
    }
}
