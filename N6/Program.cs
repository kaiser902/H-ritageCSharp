using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N6
{
    class Program
    {
        static void Main(string[] args)
        {
            Ouvrier o = new Ouvrier(1, "Nom1", "Prenom1", new DateTime(1980, 2, 3), new DateTime(2000, 4, 5));
            Console.WriteLine(o);
            Console.WriteLine("Salaire de l'employé: " + o.GetSalaire());
            Console.WriteLine("***********************************");
            Cadre c = new Cadre(2, "Nom2", "Prenom2", new DateTime(1986, 4, 3), 3);
            Console.WriteLine(c);
            Console.WriteLine("Le salaire du cadre est: " + c.GetSalaire());
            Console.WriteLine("***********************************");
            Patron.Ca = 17000000;
            Patron p = new Patron(3, "Nom3", "Prenom3", new DateTime(1970, 6, 6), 3);
            Console.WriteLine(p);
            Console.WriteLine("Le salaire du patron est: " + p.GetSalaire());
            Console.ReadKey();
        }
    }
}
