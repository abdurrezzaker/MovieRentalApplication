using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmKiralamaFormUygulamasi
{
    
     class Film
    {
        private string adi;
        private string tur;
        private string yonetmen;
        private bool filmDurum;
        public Film(string Adi,string tur, string yonetmen)
        {
            this.adi = Adi;
            this.tur = tur;
            this.yonetmen = yonetmen;
            this.filmDurum = true;
        }
        public string Adi
        {
            get { return adi; }
            set { adi = value; }
        }
        public string Tur
        {
            get { return tur; }
            set { tur = value; }

        }
        public string Yonetmen
        {
            get { return yonetmen; }
            set { yonetmen = value; }
        }
        public bool FilmDurum
        {
            get { return filmDurum; }
            set { filmDurum = value; }
        }
    }
}
