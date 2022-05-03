using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2
{
    class Program
    {
        static void Main(string[] args)
        {
            Compte C1 = new Compte();
            CompteEpargne C2 = new CompteEpargne();
            ComptePayant C3 = new ComptePayant();

            C1.Deposer(10000);
            C2.Deposer(2000);
            C3.Deposer(3000);

            C1.retirer(2000);
            C2.retirer(500);
            C3.retirer(400);

            C2.CalculerInteret();

            Console.WriteLine(C1.ToString());
            Console.WriteLine(C2.ToString());
            Console.WriteLine(C3.ToString());

            Console.ReadKey();
        }
    }
}
