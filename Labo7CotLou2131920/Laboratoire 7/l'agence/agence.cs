using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;

namespace lagence
{

    class Agence
    {
        Planet[] planet;
        Vaisseau vaisseau;
        Random rand = new Random();
        Mission[] mission;
        string date;
        int jourPasser;
        int missionFini;

        public Agence()
        {
            planet = new Planet[rand.Next(5, 1000)];
            vaisseau = new Vaisseau("Stars Poutine", 100, 0, 100, false);
            for (int i = 0; i < planet.Length; i++)
            {
                planet[i] = new Planet(rand.Next(1000, 250000), rand.Next(100, 10000), Convert.ToBoolean(rand.Next(0, 2)), Convert.ToBoolean(rand.Next(0, 2)));
            }
            this.mission = new Mission[planet.Length];
            for (int i = 0; i < planet.Length; i++)
            {
                int minNonAttire = TrouveMinNonAttitre();
                mission[i] = new Mission(planet[minNonAttire], Etat.disponible);
                planet[minNonAttire].attitre = true;

            }
            date = DateTime.Now.ToString();
        }


        

        public void Affichage()
        {
            Console.WriteLine($"Bivenue dans le menu du Jeu / Jour passer : {date}\n" +
                "Vous pouver selectioné le Menu Mission pour planifé un départ (M)\n" +
                // "Vous pouver selectiné le Magazin du vaisseau (V)\n" +
                "Vous pouver passer une journé (J)");
            try
            {
                string choix = Console.ReadLine();
                if (choix.ToUpper() == "M")
                    AffichageMission();
                else if (choix.ToUpper() == "J")
                {
                    date = DateTime.Now.AddDays(++jourPasser).ToString();
                    for (int i = 0; i < mission.Length; i++)
                    {
                        if (mission[i].etat == Etat.planifiee)
                            mission[i].etat = Etat.enCours;
                        if (mission[i].etat == Etat.enCours)
                            vaisseau.position += 100;
                        if (mission[i].planet.distanceTerre <= vaisseau.position)
                        {
                            mission[i].etat = Etat.terminee;
                            missionFini++;
                        }
                    }
                }

            }
            catch
            {
                Console.WriteLine("Errreur veiler selectioné seulement une des options indiqué");
                Thread.Sleep(5000);
                Console.Clear();
                Affichage();
            }
        }

        public void AffichageMission()
        {
            Console.WriteLine($"{missionFini} Misssion fini || Voilà les 5 mission les plus proche de vous :");
            int[] planetProche = TrouvePlusProche();
            for (int i = 0; i < planetProche.Length; i++)
                Console.WriteLine(mission[planetProche[i]]);
            Console.WriteLine("selectioné disponible pour planifié le départ (1 / 2 / 3 / 4  5 )\n" +
                "pour quiter (0)");
            int choix = 0;
            try
            {
                choix = Convert.ToInt32(Console.ReadLine());
                if (choix < 0)
                    throw new Exception();
                string option = "";
                if (mission[planetProche[choix]].etat == Etat.disponible)
                    option = "Vous avez planifé un départ !";
                else if (mission[planetProche[choix]].etat == Etat.enCours)
                    option = $"Vous êtes en cours de route il reste :  {mission[planetProche[choix]].planet.distanceTerre - vaisseau.position / jourPasser}  ";
                else if (choix == 0)
                    AffichageMission();
                else
                    option = "Le départ est demain !";
                Console.WriteLine(option);

            }
            catch
            {
                Console.WriteLine("Errreur veiler selectioné seulement un des 5 chiffre");
                Thread.Sleep(5000);
                Console.Clear();
            }
            finally
            {
                AffichageMission();
            }
        }

        

        public int[] TrouvePlusProche()
        {
            int[] planetProche = new int[5];
            int y = 0;
            for (int i = 0; y < 5; i++)
            {
                if (mission[i].etat != Etat.terminee)
                {
                    planetProche[y] = i;
                    y++;
                }

            }
            return planetProche;
        }


        public int TrouveMinNonAttitre()
        {
            int reference = 10000000;
            int planetMin = 0;
            for (int i = 0; i < planet.Length; i++)
            {
                if (!planet[i].attitre && planet[i].distanceTerre < reference)
                {
                    reference = planet[i].distanceTerre;
                    planetMin = i;
                }
            }
            return planetMin;
        }
    }
}
