using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace N3
{
    class Vecteurs2D
    {
        private double x, y;
        private static int nb_Vecteur2D;

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public static double Nb_Vecteur2D
        { 
            get { return nb_Vecteur2D; }
        }

        
        public Vecteurs2D()
        {
            nb_Vecteur2D ++;
        }

        public Vecteurs2D(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
            nb_Vecteur2D ++;
        }

        public Vecteurs2D(Vecteurs2D V)
        {
            this.X = V.X;
            this.Y = V.Y;
            nb_Vecteur2D ++;
        }

        public override string ToString()
        {
            return "X = " + X + "- Y = " + Y;
        }

        public override bool Equals(object obj)
        {
            return ((((Vecteurs2D)obj).X == X) && (((Vecteurs2D)obj).Y == Y));
        }

        public virtual double Norme(double Z = 0)
        {
            return Math.Sqrt((X * X) + (Y * Y) + (Z * Z));
        }

    }
}
