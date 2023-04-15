using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lagence
{
    partial class Vaisseau
    {
        string nom;
        int capacite;
        int vitesseActuel;
        int vitesseMax;
        bool enOrbite;
        public int position { get; set; }
        List<Mission> mission;

        public Vaisseau(string nom, int capacite, int vitesseActuel, int vitesseMax, bool enOrbite)
        {
            this.nom = nom;
            this.capacite = capacite;
            this.vitesseActuel = vitesseActuel;
            this.vitesseMax = vitesseMax;
            this.enOrbite = enOrbite;
            mission = new List<Mission>();

        }

        public void Decollage(Mission mission)
        {
            try
            {
                if (enOrbite)
                    throw new Exception("Le vaisseau est déjà en orbite");
                else
                {
                    enOrbite = true;
                    this.mission.Add(mission);
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


    }

    partial class Vaisseau
    {
        public void ChangerVitesse(int vitesseDemande)
        {
            try
            {
                if (vitesseDemande > vitesseMax)
                    throw new Exception("La  vitesse  demandée  dépasse  la  vitesse  maximale  du vaisseau");
                else
                    vitesseActuel = vitesseDemande;
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
