using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N6
{
    class Ouvrier : Employé
    {
        private DateTime dateentrée;
        private static int sMIG = 2500;


        public static double SMIG
        {
            get { return sMIG; }

        }

        public DateTime Dateentree
        {
            get { return dateentrée; }
            set { dateentrée = value; }
        }


        public Ouvrier(int m, string n, string p, DateTime dn, DateTime de)
            : base(m, n, p, dn)
        {
            dateentrée = de;
        }


        public override double GetSalaire()
        {
            if (sMIG + (dateentrée.Year - DateTime.Now.Year) * 100 <= 2 * sMIG)
                return sMIG + (dateentrée.Year - DateTime.Now.Year) * 100;
            else
                return sMIG * 2;
        }

        public override string ToString()
        {
            return "Employé: " + base.ToString() + " Date d'entrée: " + dateentrée.ToShortDateString();
        }
    }
}
