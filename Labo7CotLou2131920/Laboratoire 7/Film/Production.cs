using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFilm
{
    class Production
    {
        public void TestCatalogue()
        {
            Film[] film = new Film[6];
            film[0] = new Film("terminator", "George Lucas", 2006, "Une inteligence arificiel qui veux detruire l'humanité");
            film[1] = new Film("mission impossible", "stephen king", 2000, "Une agence secret qui sauve le monde");
            film[2] = new Film("Avatar", "steven spilberg", 2016, "Une planet extraterste ou vis des être spéciales");
            film[3] = new Film("Predator", "Jerome Bilodeau", 1996, "Un extraterste qui vien chasser sur terre");
            film[4] = new Film("interstelar", "Vincent Morin", 2030, "une histoire d'espace et de temps");
            film[5] = new Film("Indiana Jones", "Max", 2022, "un professeur par a la chasse au tresor");
            Catalogue cat = new Catalogue();
            for(int i = 0; i  < film.Length; i++)
                cat.Ajoutefilm(film[i]);
            cat.AfficherFilms();

            
        }
       
       
    }
}
