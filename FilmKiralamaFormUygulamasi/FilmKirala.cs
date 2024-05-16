using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmKiralamaFormUygulamasi
{
    public partial class FilmKirala : Form
    {
        private string isimSoyisim;
        private string telNo;
        private int filmIndex;
        private DateTime baslangic;
        private DateTime bitis;
        string[] satirlar;
        private string fileFilimler;
        private string fileKisi;
        private string fileKiralananlar;
        private FilmDukkani filmDukkani;
        public FilmKirala(string sahipAdSoyadDukkan, FilmDukkani dukkan)
        {
            InitializeComponent();
            this.filmDukkani = dukkan;        
            fileFilimler = "C:\\Users\\abdur\\source\\repos\\FilmKiralamaFormUygulamasi\\Filmler"+ sahipAdSoyadDukkan + ".txt";
            fileKisi = "C:\\Users\\abdur\\source\\repos\\FilmKiralamaFormUygulamasi\\Kisi"+ sahipAdSoyadDukkan + ".txt";
            fileKiralananlar = "C:\\Users\\abdur\\source\\repos\\FilmKiralamaFormUygulamasi\\Kiralananlar"+ sahipAdSoyadDukkan + ".txt";
            FilmListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(filmDukkani);
            menu.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            filmIndex = dataGridView1.CurrentCell.RowIndex;

            if ((textBox1.Text) != "" && (textBox2.Text.ToString().Length) == 11)
            {
                telNo = (textBox2.Text);
                baslangic = dateTimePicker1.Value;
                bitis = dateTimePicker2.Value;
                isimSoyisim = textBox1.Text;
                if (!(filmIndex >= 0))
                {
                    MessageBox.Show("Kiralamak istediğniz filmi seçiniz!!!");
                }
                else
                {
                    Kisi kisi = new Kisi(isimSoyisim, telNo);
                    Kiralanan kiralanan = new Kiralanan(kisi, filmIndex, baslangic, bitis);
                    FileInfo fileinfo = new FileInfo(fileKisi);
                    if (!fileinfo.Exists)
                    {
                        using (fileinfo.Create()) { }
                    }
                    StreamWriter streamWriter = new StreamWriter(fileKisi, true);
                    streamWriter.WriteLine("{0}-{1}", kisi.IsimSoyisim, kisi.TelNo);
                    streamWriter.Close();

                    satirlar = File.ReadAllLines(fileFilimler);
                    string[] kelimler = satirlar[filmIndex].Split("-");
                    if (kelimler[3] == "True")
                    {
                        kelimler[3] = "False";
                        satirlar[filmIndex] = kelimler[0] + "-" + kelimler[1] + "-" + kelimler[2] + "-" + kelimler[3];

                        File.WriteAllLines(fileFilimler, satirlar);
                        int günSayisi = (int)(bitis - baslangic).TotalDays + 2;

                        dataGridView1.Columns.Clear();
                        dataGridView1.Rows.Clear();
                        FilmListele();
                        kiralanan.Ekle(kiralanan, günSayisi * 8);
                        MessageBox.Show(kelimler[0] + " filmi " + kisi.IsimSoyisim + " tarafından " + günSayisi +
                            " gün kiralanmıştır. (Günlük ücert 8TL) Toplam bedel: " + (günSayisi * 8) + "TL");
                    }
                    else
                    {
                        MessageBox.Show("Mevcut olan bir filim seçiniz.!!!!");
                    }
                }
            }
            else
            { MessageBox.Show("İstenilen bilgileri eksiksiz bir şekilde doldurunuz."); }
        }
        public void FilmListele()
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Film Adı";
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Name = "Tür";
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Name = "Yönetmen";
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Name = "Durum";
            dataGridView1.Columns[3].Width = 100;

            if (File.Exists(fileFilimler))
            {
                StreamReader readFile = new StreamReader(fileFilimler);
                string line = readFile.ReadLine();
                while (line != null)
                {
                    string[] datas = line.Split("-");

                    if (datas[3] == "True")
                    {
                        datas[3] = "Mevcut";
                    }
                    else
                    {
                        datas[3] = "Kiralık";
                    }

                    dataGridView1.Rows.Add(datas[0], datas[1], datas[2], datas[3]);
                    line = readFile.ReadLine();
                }
                readFile.Close();
            }
            else
            { FileInfo fileInfo = new FileInfo(fileFilimler);
                fileInfo.Create();  }


            
        }
    }
}
