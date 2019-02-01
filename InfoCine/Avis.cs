using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoCine
{
    class Avis
    {
        private int score;
        private int filmId;
        private int personneId;
        private string text;

        public int Score { get => score; set => score = value; }
        public int FilmId { get => filmId; set => filmId = value; }
        public int PersonneId { get => personneId; set => personneId = value; }
        public string Text { get => text; set => text = value; }

        public Avis()
        {
        }

        public Avis(int score, int filmId, int personneId, string text)
        {
            Score = score;
            FilmId = filmId;
            PersonneId = personneId;
            Text = text;
        }
    }
}
