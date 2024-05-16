using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmKiralamaFormUygulamasi
{
    public class FilmDukkani
    {
        private Kisi sahip;
        private string dukkanIsmi;

        public FilmDukkani(Kisi sahip, string dukkanIsmi) { 
            
            this.sahip = sahip;
            this.dukkanIsmi = dukkanIsmi;
            
        }
        public Kisi Sahip
        {
            get { return sahip; }
            set { sahip = value; }
        }
        public string DukkanIsmi
        {
            get { return dukkanIsmi; }
            set { dukkanIsmi = value; }

        }
    }
}
