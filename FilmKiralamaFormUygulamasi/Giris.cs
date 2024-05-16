using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmKiralamaFormUygulamasi
{
    public partial class Giris : Form
    {
        private string fileKisi;
        public Giris()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sahipAdSoyad = textBox1.Text;
            string sahipTelNo = textBox2.Text;
            string dukkanIsmi = textBox3.Text;
            fileKisi = "C:\\Users\\abdur\\source\\repos\\FilmKiralamaFormUygulamasi\\Kisi" + sahipAdSoyad + "" + dukkanIsmi + ".txt";
            bool mevcut = false;
            if (sahipTelNo.Length == 11 && sahipAdSoyad != "" && dukkanIsmi != "")
            {
                Kisi sahip = new Kisi(sahipAdSoyad, sahipTelNo);
                FilmDukkani dukkan = new FilmDukkani(sahip, dukkanIsmi);
                FileInfo fileinfo = new FileInfo(fileKisi);
                if (fileinfo.Exists)
                {
                    StreamReader read = new StreamReader(fileKisi);
                    String nameLastnameTel = read.ReadLine();

                    string yonetici = sahip.IsimSoyisim + "-" + sahip.TelNo;
                    while (nameLastnameTel != null)
                    {
                        if (nameLastnameTel.Equals(yonetici))
                        {
                            mevcut = true;
                            break;
                        }
                        nameLastnameTel = read.ReadLine();
                    }
                    read.Close();
                }
                else
                {                       
                    using (fileinfo.Create()) { }
                }
                if (!mevcut)
                {
                    StreamWriter streamWriter = new StreamWriter(fileKisi, true);
                    streamWriter.WriteLine("{0}-{1}", sahip.IsimSoyisim, sahip.TelNo);
                    streamWriter.Close();
                }
                MessageBox.Show(mevcut.ToString());
                Menu menu = new Menu(dukkan);
                menu.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Eksik veya yanlış bilgi girdiniz!!!");
        }
    }
}
