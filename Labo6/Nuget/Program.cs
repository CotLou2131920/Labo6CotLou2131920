using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Humanizer;
using System.Drawing;
using Console = Colorful.Console;

namespace Nuget
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "JeTestDesNugetPourVincent";
            string nom = "Vincent";
            Console.WriteLine("text au debut : "+ text);
            Console.WriteLine("text espacé : " + text.Humanize(LetterCasing.Title));
            Console.WriteLine("text ave... : " + text.Truncate(22,"...", Truncator.FixedLength));
            Console.WriteLine("La date d'aujourd'hui " +DateTime.Now);
            Console.WriteLine("La date dans 1 mois " + DateTime.Now.AddMonths(1));
            Console.WriteLine("text espacé avec du turquoise " + text.Humanize(LetterCasing.Title), System.Drawing.Color.Cyan);
            int r = 225;
            int g = 255;
            int b = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteAscii(nom, Color.FromArgb(r, g, b));
                g -= 15;
                r -= 15;
                b += 15;
            }
            Console.WriteWithGradient(text, Color.Cyan, Color.Yellow, 14);
            

        }
    }
}