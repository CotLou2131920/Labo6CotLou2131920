using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using AnimalNamespace;
using ChienNamespace;
using ChatNamespace;

namespace AmitieNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal chat = new Chat();
            Animal Chien1 = new Chien("Dog");
            Animal Chien2 = new Chien("Doggy");

            if (chat.Humeur)
            {
                chat.MeilleureAmi = "Dog";
                Chien1.MeilleureAmi = "Cat";
            }
            if (chat.MeilleureAmi == "")
            {
                Chien2.MeilleureAmi = "Cat";
                chat.MeilleureAmi = "Doggy";
            }
            else
            {
                Chien1.Humeur = false;
                Chien1.MeilleureAmi = "Doggy";
                Chien2.MeilleureAmi = "Dog";
                chat.MeilleureAmi = "";

            }
            Console.WriteLine(chat.nom + ", " + (chat.Humeur ? "est de bonne humeur" : "est de mauvaise humeur") + " sont ami est " + chat.MeilleureAmi);
            Console.WriteLine(Chien1.nom + ", " + (Chien1.Humeur ? "est de bonne humeur" : "est de mauvaise humeur") + " sont ami est " + Chien1.MeilleureAmi);
            Console.WriteLine(Chien2.nom + ", " + (Chien2.Humeur ? "est de bonne humeur" : "est de mauvaise humeur") + " sont ami est " + Chien2.MeilleureAmi);





        }
    }

}