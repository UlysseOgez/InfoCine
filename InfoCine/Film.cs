using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoCine
{
    // La clase film est dédié à stocker les informations sur un film
    class Film
    {
        // Les champs privés qui vont contenir les informations sur le film
        private string titreFilm;
        private DateTime dateSortie;

    // Les propri"tés publiques qui permettent d'acceder à nos champs
        public string Titre { get => titreFilm; set => titreFilm = value; }
        public DateTime DateSortie { get => dateSortie; set => dateSortie = value; }

        //Les constructeurs de l'objet champs
        public Film()
        {
        }

        public Film(string titre, DateTime dateSortie)
        {
            Titre = titre;
            DateSortie = dateSortie;
        }

        // Les méthodes

        // Cette methode nous permet de recuperer la liste de tous les films
        //public static List<Film> getAllFilms()
        //{
        //    return new List<Film>
        //}
    }
}
