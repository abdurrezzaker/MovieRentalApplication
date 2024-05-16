using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmKiralamaFormUygulamasi
{
    public partial class FilmEkle : Form
    {
        private string sahipAdSoyadDukkan;
        private string filmAdi, filmTur, yonetmen;
        private string fileFilimler;
        private FilmDukkani filmDukkani;
        private Film film;

        public FilmEkle(string sahipAdSoyadDukkan,FilmDukkani dukkani)
        {

            InitializeComponent();
            this.filmDukkani = dukkani;
            this.sahipAdSoyadDukkan = sahipAdSoyadDukkan;
            fileFilimler = "C:\\Users\\abdur\\source\\repos\\FilmKiralamaFormUygulamasi\\Filmler"+ sahipAdSoyadDukkan +".txt";

        }

    private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(filmDukkani);
            menu.Show();
            this.Hide();
        }
        private void Ekle_Click(object sender, EventArgs e)
        {
            filmAdi = textBox1.Text;
            filmTur = textBox2.Text;
            yonetmen = textBox3.Text;

            film = new Film(filmAdi, filmTur, yonetmen);
            if (File.Exists(fileFilimler))
            {
                StreamWriter writeFile = new StreamWriter(fileFilimler, true);
                writeFile.WriteLine("{0}-{1}-{2}-{3}", film.Adi, film.Tur, film.Yonetmen, film.FilmDurum.ToString());
                MessageBox.Show("Ekleme başarılı.");
                writeFile.Close();
            }
            else
            {
                FileInfo fileInfo = new FileInfo(fileFilimler);
                using (fileInfo.Create()) { }
                
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
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
            }else
            {
                FileInfo fileInfo = new FileInfo(fileFilimler);
                if (!fileInfo.Exists)
                {
                    using (fileInfo.Create()) { }
                }
                MessageBox.Show("Stokta film bulunmamaktadır.");
            }
        }

        private void FilmEkle_Load(object sender, EventArgs e)
        {
        }
    }
}
