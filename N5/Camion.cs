using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5
{
    class Camion : Véhicule
    {
        public Camion(int année_modèle, double prix)
            : base(année_modèle, prix)
        {
        }

        public override void accélérer()
        {
            Console.WriteLine("Le Camion Accélére");
        }

        public override void démarrer()
        {
            Console.WriteLine("Le Camion Démarre");
        }

        public override string ToString()
        {
            return "Camion_ " + base.ToString();
        }
    }
}
