using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction
{
    class Ville
    {
        Random random = new Random();
        public Batiment[] bati;


        public Ville(int nbBatiment)
        {
            bati = new Batiment[nbBatiment];
            CreerBatiment();
        }


        public void CreerBatiment()
        {
            for (int i = 0; i < bati.Length; i++)
            {
                int resourceDemande = random.Next(1, 6);
                int statut;
                int priorite;
                int x = random.Next(1, 11);
                int y = random.Next(1, 11);
                if (resourceDemande == 1)
                {
                    resourceDemande -= 1;
                    statut = 0;
                    priorite = 1;
                }
                else if (resourceDemande == 5)
                {
                    statut = 2;
                    priorite = 5;
                }
                else
                {
                    statut = 1;
                    priorite = resourceDemande;
                }
                bati[i] = new Batiment(x, y, (Statut)statut, resourceDemande, priorite);
                
            }
            VerifieCoordoneeBati();

        }

        public void VerifieCoordoneeBati()
        {
            for (int i = 0; i < bati.Length; i++)
            {
                for (int y = i + 1; y < bati.Length; y++)
                {
                    if (bati[i].PositionX == bati[y].PositionX && bati[i].PositionY == bati[y].PositionY)
                        ++bati[i].PositionX;
                }
            }
        }

        public void AfficheVille() { foreach (Batiment b in bati) Console.WriteLine(b); }
    }


}
