namespace FilmKiralamaFormUygulamasi
{
    public partial class Menu : Form
    {

        private FilmDukkani dukkan;
        public Menu(FilmDukkani dukkan)
        {

            InitializeComponent();
            this.dukkan = dukkan;
            label1.Text = dukkan.DukkanIsmi;


        }
        public Menu()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FilmEkle filmEkle = new FilmEkle(dukkan.Sahip.IsimSoyisim + dukkan.DukkanIsmi, dukkan);
            filmEkle.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FilmKirala filmKirala = new FilmKirala(dukkan.Sahip.IsimSoyisim + dukkan.DukkanIsmi, dukkan);
            filmKirala.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
