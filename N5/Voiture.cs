using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5
{
    class Voiture : Véhicule
    {
        public Voiture(int année_modèle, double prix)
            : base(année_modèle, prix)
        {
        }

        public override void accélérer()
        {
            Console.WriteLine("La voiture Accélére");
        }

        public override void démarrer()
        {
            Console.WriteLine("La voiture Démarre");
        }

        public override string ToString()
        {
            return "Voiture_ " + base.ToString();
        }
    }
}
