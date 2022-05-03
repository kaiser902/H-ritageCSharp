using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1
{
    class Program
    {
        static void Main(string[] args)
        {
            Batiment B = new Batiment("Agadir");
            Console.WriteLine(B.ToString());

            Maison M1 = new Maison("Agadir", 7);
            Console.WriteLine(M1.ToString());

            Maison M2 = new Maison();
            M2.Adresse = "Casa";
            M2.NbPiece = 2;
            Console.WriteLine(M2.ToString());

            Console.ReadKey();
        }
    }
}
