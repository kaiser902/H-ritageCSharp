using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N6
{
    abstract class Employé
    {
        //• Matricule • Nom • Prénom • Date de naissance

        private int matricule;
        private string nom;
        private string prénom;
        private DateTime dateNaissance;

        public int Matricule
        {
            get { return matricule; }
            set { matricule = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prénom
        {
            get { return prénom; }
            set { prénom = value; }
        }

        public DateTime DateNaissance
        {
            get { return dateNaissance; }
            set { dateNaissance = value; }
        }

        public Employé(int matricule, string nom, string prénom, DateTime dateNaissance)
        {
            this.matricule = matricule;
            this.nom = nom;
            this.prénom = prénom;
            this.dateNaissance = dateNaissance;
        }

        public override string ToString()
        {
            return "Matricule : " + Matricule + " Nom : " + Nom + " Prénom : " + Prénom + " DateNaissance : " + DateNaissance.ToShortDateString() ;
        }

        public abstract double GetSalaire();
    }
}
