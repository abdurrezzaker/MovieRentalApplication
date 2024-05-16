using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmKiralamaFormUygulamasi
{
    public class Kisi
    {
        private string isimSoyisim;
        private string telNo;
        
        public Kisi(string isimSoyisim, string telNo)
        {
            this.isimSoyisim = isimSoyisim;
            this.telNo = telNo;
        }
        public string IsimSoyisim
        {
            get { return isimSoyisim; }
            set { isimSoyisim = value; }
        }
        public string TelNo
        {
            get { return telNo; }
            set { if((value.ToString()).Length == 11)
                    telNo = value;
            }
        }
    }
}
