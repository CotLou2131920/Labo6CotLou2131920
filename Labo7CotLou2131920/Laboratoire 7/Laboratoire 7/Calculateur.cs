using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire_7
{
    internal class Calculateur
    {




        public double Diviser(int nbDiviser, int nbQuiDivise)
        {
            try
            {
                double resultat = nbDiviser / nbQuiDivise;
                return resultat;
            }
            catch (DivideByZeroException ex) 
            {
                return nbDiviser;
            }

        }

        public double Multiplier(int nbMultiplier, int nbQuiMultipie)
        {
            double resultat = nbMultiplier * nbQuiMultipie;
            return resultat;
        }
    }
}
