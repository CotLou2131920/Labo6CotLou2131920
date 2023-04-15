using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFilm
{
    partial class Film
    {
        public string Titre { get; set; }
        string directeur;
        int annee;
        public List<string> Acteur { get; set; }

        public Film(string titre, string directeur, int annee, string synopsis)
        {
            this.Titre = titre;
            this.directeur = directeur;
            this.annee = annee;
            this.synopsis = synopsis;
            Acteur= new List<string>();
            genres = new List<string>();

        }
        

        public string AfficheActeur(string info)
        {
            foreach (string act in Acteur)
            {
                info += "acteur : " + act;
            }
            return info;
        }


        public override string ToString()
        {
            string info = $"Titre : {Titre}\n" +
                $"Directeur :  {directeur}\n" +
                $"Année de sortie : {annee} \n" +
                $"Synopsis : {synopsis} \n";
            info = AfficherGenre(info);
            info = AfficheActeur(info);
            return info;
        }
    }

    partial class Film
    {
        string synopsis;
        List<string> genres;

        public Film()
        {
            genres = new List<string>();
            Acteur = new List<string>();

        }

        public string AfficherGenre(string info)
        {
            foreach (string genre in genres)
            {
                info += "Gemre : " + genre;
            }
            return info;
        }

        public void AjouterGenre(string genre)
        {
            genres.Add(genre);
        }

    }
}
