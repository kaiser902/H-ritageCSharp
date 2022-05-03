using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Vecteur 2D****");
            Vecteurs2D V1 = new Vecteurs2D();
            Console.Write("Donner X: ");
            V1.X = Convert.ToDouble(Console.ReadLine());
            Console.Write("Donner Y: ");
            V1.Y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(V1);
            Console.WriteLine("La norme est : " + V1.Norme());

            Vecteurs2D V2 = new Vecteurs2D();
            Console.Write("Donner X: ");
            V2.X = Convert.ToDouble(Console.ReadLine());
            Console.Write("Donner Y: ");
            V2.Y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(V2);
            Console.WriteLine("La norme est : " + V2.Norme());

            if (V1.Equals(V2))
                Console.WriteLine("Les deux vecteurs sont identiques");
            else
                Console.WriteLine("Non identiques");

            Console.WriteLine("****Vecteur 3D****");
            Vecteurs3D V3 = new Vecteurs3D();
            Console.Write("Donner X: ");
            V3.X = Convert.ToDouble(Console.ReadLine());
            Console.Write("Donner Y: ");
            V3.Y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Donner Z: ");
            V3.Z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(V3);
            Console.WriteLine("La norme est : " + V3.Norme());

            Vecteurs3D V4 = new Vecteurs3D();
            Console.Write("Donner X: ");
            V4.X = Convert.ToDouble(Console.ReadLine());
            Console.Write("Donner Y: ");
            V4.Y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Donner Z: ");
            V4.Z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(V4);
            Console.WriteLine("La norme est : " + V4.Norme());

            if (V3.Equals(V4))
                Console.WriteLine("Les deux vecteurs sont identiques");
            else
                Console.WriteLine("Non identiques");

            Console.Out.WriteLine("Le nombre de vecteurs crées est: " + Vecteurs2D.Nb_Vecteur2D);
            Console.ReadKey();

        }
    }
}
