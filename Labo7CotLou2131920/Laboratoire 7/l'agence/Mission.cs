using Humanizer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace lagence
{
    enum Etat
    {
        disponible,
        planifiee,
        enCours,
        terminee
    }

    partial class Mission
    {
        string nom;
        public Planet planet { get; set; }
        public int dateDepart { get; set; }
        int datePrevue;
        public Etat etat { get; set; }
        static int countMission;

        public Mission(Planet planet, Etat etat)
        {

            this.nom = "Mission " + ++countMission;
            this.planet = planet;
            this.etat = etat;
        }
    }

    partial class Mission
    {

        public void CompleterMission(int position)
        {
            if (planet.distanceTerre <= position)
            {
                etat = Etat.terminee;
                Console.WriteLine($"La Mission : {nom} à été effectuer avec succèes");
            }

        }

        public override string ToString()
        {
            string info = $"{planet}" +
                $"{etat.Humanize()}\n";

            return info;
        }
    }


}
