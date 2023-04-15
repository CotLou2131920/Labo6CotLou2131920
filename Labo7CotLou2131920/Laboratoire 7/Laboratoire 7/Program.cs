using Laboratoire_7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Labo7
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbDiviser = 0;
            int nbQuiDivise = 0;
            double reponse = 0;
            int nbAMultiplier = 0;
            int nbQuiMultiplie = 0;
            Calculateur cal = new Calculateur();
            Console.WriteLine("Division");
            Console.WriteLine("Entrer un nombre a divisé");
            nbDiviser = Division(nbDiviser);
            Console.WriteLine("Entrer un nombre qui divise");
            nbQuiDivise = Division(nbQuiDivise);    
            reponse = cal.Diviser(nbDiviser, nbQuiDivise);
            Console.WriteLine(reponse);
            Console.WriteLine("Multiplication");
            Console.WriteLine("Entrer un nombre a multiplié");
            nbAMultiplier = Multiplication(nbAMultiplier);
            Console.WriteLine("Entrer un nombre qui multiplie");
            nbQuiMultiplie = Multiplication(nbQuiMultiplie);
            reponse = cal.Multiplier(nbAMultiplier, nbQuiMultiplie);
            Console.WriteLine(reponse);



        }
        public static int Division(int i)
        {
            try
            {
                i = Convert.ToInt16(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Incorect ! \nRéessayer");
                Console.WriteLine(ex.Message);
                Division(i);
            }
            return i;
        }
        public static int Multiplication(int i)
        {
            try
            {   
                i = Convert.ToInt16(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Incorect ! \nRéessayer");
                Console.WriteLine(ex.Message);
                Multiplication(i);
            }
            return i;
        }
    }
}