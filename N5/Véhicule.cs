using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5
{
    abstract class Véhicule
    {
        //matricule, l’année de son modèle, son prix.

        private int matricule;
        private int année_modèle;
        private double prix;
        private static int nb_Véhicule = 0;


        public int Matricule
        {
            get { return matricule; }
        }

        public int Année_Modèle
        {
            get { return année_modèle; }
            set { année_modèle = value; }
        }

        public double Prix
        {
            get { return prix; }
            set { prix = value; }
        }

        public static int Nb_Véhicule
        {
            get { return nb_Véhicule; }
        }

        public Véhicule(int année_modèle, double prix)
        {
            nb_Véhicule++;
            this.matricule = Nb_Véhicule;
            this.année_modèle = année_modèle;
            this.prix = prix;
        }

        public abstract void démarrer();
        public abstract void accélérer();

        public override string ToString()
        {
            return "Matricule : " + Matricule + " Année de Modèle : " + Année_Modèle + " Prix : " + Prix;
        }


    }
}
