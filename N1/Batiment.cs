using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1
{
    class Batiment
    {
        private string adresse;

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        public Batiment()
        {
        }

        public Batiment(string adresse)
        {
            this.adresse = adresse;
        }

        public override string ToString()
        {
            return "Adresse : " + adresse;
        }

    }
}
