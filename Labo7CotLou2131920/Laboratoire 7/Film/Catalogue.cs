using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFilm
{
    partial class Catalogue
    {
        List<Film> Films;

        public Catalogue()
        {
            Films = new List<Film>();
        }
        public void Ajoutefilm(Film film)
        {
            Films.Add(film);
        }

        public void SuprimmerFilm(Film film)
        {
            Films.Remove(film);
        }
        
        public void AfficherFilms()
        {
            foreach (Film f in Films)
                Console.WriteLine(f);
        }
    }

    partial class Catalogue
    {
        public Film RechercherParTitre(string titre)
        {
            Film filmRechercher = new Film();
            for(int i = 0; i < Films.Count; i++) 
            {
                if (Films[i].Titre == titre)
                {
                    filmRechercher = Films[i];
                }
            }
            return filmRechercher;
        }

        public Film RechercherParActeur(string acteur)
        {
            Film filmRechercher = new Film();
            for (int i = 0; i < Films.Count; i++)
            {
                foreach (string a in Films[i].Acteur)
                if (a == acteur)
                {
                    filmRechercher = Films[i];
                }
            }
            return filmRechercher;
        }
    }

}
