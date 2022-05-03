using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5
{
    class Program
    {
        static void Main(string[] args)
        {

            Voiture v = new Voiture(2005, 200000);
            Console.WriteLine(v);
            v.démarrer();
            v.accélérer();
            Camion c = new Camion(2003, 4560000);
            Console.WriteLine(c);
            c.démarrer();
            c.accélérer();
            Console.ReadKey();

        }
    }
}
