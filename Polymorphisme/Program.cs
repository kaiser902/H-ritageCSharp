using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisme
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne[] Per = new Personne[8];
            Per[0] = new Employé("NOM1", "PRENOM1", new DateTime(1985, 3, 4), 9000);
            Per[1] = new Employé("NOM2", "PRENOM2", new DateTime(1984, 3, 4), 10000);
            Per[2] = new Employé("NOM3", "PRENOM3", new DateTime(1983, 3, 4), 8000);
            Per[3] = new Employé("NOM4", "PRENOM4", new DateTime(1982, 3, 4), 11000);
            Per[4] = new Employé("NOM5", "PRENOM5", new DateTime(1981, 3, 4), 7000);
            Per[5] = new Chef("NOM6", "PRENOM6", new DateTime(1988, 7, 6), 9000, "SERVICE1");
            Per[6] = new Chef("NOM7", "PRENOM7", new DateTime(1984, 7, 6), 9000, "SERVICE2");
            Per[7] = new Directeur("NOM8", "PRENOM8", new DateTime(1988, 7, 6), 9000, "SERVICE3", "SOCIETE1");

            for (int i = 0; i < 8; i++)
            {
                Per[i].Afficher();
                Console.WriteLine("\n");
            }

            Console.WriteLine("\n\n\n");

            foreach (Personne p in Per)
            {
                p.Afficher();
                Console.WriteLine("\n");
            }
            Console.ReadKey();

        }
    }
}
