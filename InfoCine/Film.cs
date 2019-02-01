using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoCine
{
    class Film
    {
        private string titre;
        private DateTime dateSortie;

        public string Titre { get => titre; set => titre = value; }
        public DateTime DateSortie { get => dateSortie; set => dateSortie = value; }

        public Film()
        {
        }

        public Film(string titre, DateTime dateSortie)
        {
            Titre = titre;
            DateSortie = dateSortie;
        }
    }
}
