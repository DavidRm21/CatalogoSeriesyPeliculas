using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ICatalogo
{
    public partial class Formulario : Form
    {
        private FormPrincipal vistaPrincipal = new FormPrincipal();
        private Service service;
        private List<Movie> listMovies;
        private List<TVShow> listTVShows;

        public Formulario()
        {
            InitializeComponent();
            service = new Service();
            listMovies = service.getMovies();
            listTVShows = service.getTVShows();
            defaultini(FormPrincipal.optionSelect);
        }

        public void inserMovie() {
            String title = this.txtBoxTitulo.Text;
            String synopsys = this.txtBoxSynopsis.Text;
            String cover = this.txtBoxCover.Text;
            String genres = this.txtBoxGenero.Text;
            service.addMovie(new Movie(title, synopsys, cover, genres));
            MessageBox.Show($"Se ha agregado {title}, correctamente");
            emptyForm();
        }
        public void inserTVShow() {
            String title = this.txtBoxTitulo.Text;
            String synopsys = this.txtBoxSynopsis.Text;
            String cover = this.txtBoxCover.Text;
            String genres = this.txtBoxGenero.Text;
            int season = Convert.ToInt16(this.txtBoxTemporadas.Text);
            int episode = Convert.ToInt16(this.txtBoxEpisodios.Text);
            service.addTVShow(new TVShow(title, synopsys, cover, genres, episode, season));
            MessageBox.Show($"Se ha agregado {title}, correctamente");
            emptyForm();
        }
        public void emptyForm() { 
            this.txtBoxCover.Text = "";
            this.txtBoxEpisodios.Text = "0";
            this.txtBoxGenero.Text = "";
            this.txtBoxTitulo.Text = "";
            this.txtBoxSynopsis.Text = "";
            this.txtBoxTemporadas.Text = "0";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            vistaPrincipal.Visible =  true;
            this.Close();
        }
        private void defaultini(String comboBox)
        {
            emptyForm();
            if (comboBox == "Peliculas")
            {
                labelHead.Text = "Ingrese Peliculas";
                txtBoxTemporadas.Enabled = false;
                txtBoxTemporadas.Text = "";
                txtBoxEpisodios.Text= "";
                txtBoxEpisodios.Enabled = false;
            }
            if (comboBox == "Series") 
            { 
                labelHead.Text = "Ingrese Series";
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (FormPrincipal.optionSelect == "Peliculas") {
                inserMovie();    
            }
            if (FormPrincipal.optionSelect == "Series") {
                inserTVShow();
            }
        }
    }
}
