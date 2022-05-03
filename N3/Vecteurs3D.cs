using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N3
{
    class Vecteurs3D : Vecteurs2D
    {
        double z;

        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        public Vecteurs3D() 
            : base()
        {

        }

        public Vecteurs3D(double X, double Y, double Z)
            : base(X, Y)
        {
            this.Z = Z;
        }

        public Vecteurs3D(Vecteurs3D V)
            : base(new Vecteurs2D(V.X, V.Y))
        {
            this.Z = V.Z;
        }

        public override string ToString()
        {
            return base.ToString() + "-  Z = " + Z;
        }

        public override bool Equals(object obj)
        {
            return ((((Vecteurs3D)obj).X == X) && (((Vecteurs3D)obj).Y == Y) && (((Vecteurs3D)obj).Z == Z));                
        } 

        public override double Norme(double Z = 0)
        {
            return base.Norme(this.Z);
        }
    }
}
