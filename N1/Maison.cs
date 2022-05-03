using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1
{
    class Maison : Batiment
    {
        private int nbPiece;
        public int NbPiece
        {
            get { return nbPiece; }
            set { nbPiece = value; }
        }

        public Maison()
            : base()
        {
        }

        public Maison(string adresse, int nbPiece)
            : base(adresse)
        {
            this.nbPiece = nbPiece;
        }

        public override string ToString()
        {
            return base.ToString() + "   Nombre de piéces : " + nbPiece;
        }
    }
}
