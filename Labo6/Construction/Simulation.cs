using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;

namespace Construction
{
    internal class Simulation
    {
        Ville ville;
        Usine usi;


        public Simulation()
        {
            this.ville = new Ville(5);
            this.usi = new Usine();

        }

        public void LanceSimulation()
        {
            AffichageDeJeu();
            
            

        }

        public void AffichageDeJeu()
        {
            int nbTour = 1;
            Console.WriteLine("Bienvenue, Nous avont du travail a faire ! ! \n");
            bool JeuFini = false;
            while (!JeuFini)
            {
                Console.WriteAscii($"Tour {nbTour}");
                ville.AfficheVille();
                Console.WriteLine($"tu as des batiments de ta ville a reconstruire tu es dans le menu des options\n" +
                    "Voici les robots mis a ta disposition = Robot de destruction : "+ (usi.robot[0].disponible ? "disponible " : "indisponible ") + "|| Robot de transport : "+ (usi.robot[1].disponible ? "disponible " : "indisponible ")+ "|| Robot de construction : "+ (usi.robot[2].disponible ? "disponible " : "indisponible ")+"  \n" +
                    "Commence par choisir parmis les 5 Batiment lequel veut-tu réparer ? ( 1 / 2 / 3 / 4 / 5 ) \n" +
                    "Passer un tour (0) <-- Permet de rendre les robots envoyer à nouveau \n");
                int choix = Convert.ToInt16(Console.ReadLine());
                if (choix == 0)
                {
                    for (int i = 0; i < 3; i++)
                        usi.robot[i].disponible = true;
                    Thread.Sleep(5000);
                    Console.Clear();
                    nbTour++;
                }
                else
                    MenuBatiment(ville.bati[choix-1]);
                if (ville.bati[0].etatBatiment ==  Statut.parfait && ville.bati[1].etatBatiment == Statut.parfait  && ville.bati[2].etatBatiment == Statut.parfait && ville.bati[3].etatBatiment == Statut.parfait && ville.bati[4].etatBatiment == Statut.parfait) 
                {
                    Console.WriteLine("Bravo la ville est reconstruite !!!");
                    JeuFini = true;
                    Thread.Sleep(5000);
                    Console.Clear();
                }
            }
        }

        public void MenuBatiment(Batiment batiment)
        {
            bool action = false;
            while (!action)
            {
                Console.WriteLine("Voici tes posibilité : \n" +
                    "Envoyer un Robot pour démolire le batiment (1) \n" +
                    "Envoyer un Robot de resource au batiment (2) \n" +
                    "Envoyer un Robot de construction (3) <-- notez que le robots ne pouras rien faire sans les ressource nécéssaire \n" +
                    "Quitter le batiment (0) \n");

                string choix = Console.ReadLine();
                Console.WriteLine();
                if (choix == "0")
                    action = true;
                else if (choix == "1" && usi.robot[0].disponible == true && batiment.etatBatiment == Statut.demoli)
                {
                    usi.robot[0].disponible = false;
                    batiment.etatBatiment = Statut.reparation;
                    batiment.priorite--;
                    batiment.resource--;
                    Console.WriteLine(batiment);
                    action = true;
                }
                else if (choix == "2" && usi.robot[1].disponible == true && batiment.etatBatiment == Statut.reparation)
                {
                    usi.robot[1].disponible = false;
                    batiment.resource = 1;
                    action = true;
                }
                else if (choix == "3" && usi.robot[2].disponible == true && batiment.etatBatiment == Statut.reparation)
                {
                    usi.robot[2].disponible = false;
                    if (batiment.resource < batiment.priorite)
                        batiment.priorite = batiment.resource;
                    if (batiment.priorite == 1 && batiment.resource == 1)
                        batiment.etatBatiment = Statut.parfait;
                    action = true;
                }
                else
                {
                    Console.WriteLine("Erreur sur votre requête !! robot indisponible, batiment déjà réparer, resource manquante ou etc... ");
                    Thread.Sleep(5000);
                }
                Console.Clear();
            }
        }

    }
}
