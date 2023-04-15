using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lagence
{
    internal class Planet
    {
        string nom;
        int taille;
        public int distanceTerre { get; set; }
        bool vivable;
        bool explorer;
        public bool attitre { get; set; }
        static int countPlanet;

        public Planet(int taille, int distanceTerre, bool vivable, bool explorer)
        {
            this.nom = "Planet " + ++countPlanet;
            this.taille = taille;
            this.distanceTerre = distanceTerre;
            this.vivable = vivable;
            this.explorer = explorer;
            attitre = false;
        }

        public void VerifieSiExplorer()
        {
            try
            {
                if (explorer)
                    throw new Exception("La planet est déjà explorer");
                else
                {
                    explorer = true;
                    Console.WriteLine($"la planet : {nom} a été explorer");
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public override string ToString()
        {
            string info = $"{nom}\n" +
                $"Taille : {taille}\n" +
                $"Distance depuis la Terre : {distanceTerre}\n";
            return info;
        }
    }
}
