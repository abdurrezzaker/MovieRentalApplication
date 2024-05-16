using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmKiralamaFormUygulamasi
{
    public class Kiralanan
    {
        private Kisi kisi;
        private int filmIndex;
        private DateTime baslangic;
        private DateTime bitis;
        private string fileKiralananlar = "C:\\Users\\abdur\\source\\repos\\FilmKiralamaFormUygulamasi\\Kiralananlar.txt";
        private string fileFilimler = "C:\\Users\\abdur\\source\\repos\\FilmKiralamaFormUygulamasi\\Filmler.txt";

        public Kiralanan(Kisi kisi,int filmIndex,DateTime baslangic,DateTime bitis)
        {
            this.kisi = kisi;
            this.filmIndex = filmIndex;
            this.baslangic = baslangic;
            this.bitis = bitis;
        }

        public DateTime Baslangic {
            get {  return baslangic; } }
        public DateTime Bitis { 
            get {  return bitis; } }
            
        public void Ekle(Kiralanan kiralanan,int bedel)
        {
            FileInfo file = new FileInfo(fileKiralananlar);

            if(!file.Exists)
                using (file.Create()) { }
            StreamReader streamRead = new StreamReader(fileKiralananlar);
            string filmLine = streamRead.ReadToEnd();
            int sayac = 0;
            while(sayac != filmIndex)
            {
                filmLine = streamRead.ReadLine();
                sayac++;
            }
            streamRead.Close();
            StreamWriter streamWrtier = new StreamWriter(fileKiralananlar,true);
            streamWrtier.WriteLine("{0}-{1}-{2}-{3}-{4}-{5}", kiralanan.kisi.IsimSoyisim, kiralanan.kisi.TelNo,filmLine, kiralanan.Baslangic, kiralanan.Bitis, bedel);

            streamWrtier.Close();
        }
       
    }
}
