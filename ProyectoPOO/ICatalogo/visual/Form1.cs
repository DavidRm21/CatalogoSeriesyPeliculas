using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ICatalogo
{
    public partial class FormPrincipal : Form
    {
        private Service service = new Service();
        private List<Movie> listMovies;
        private List<TVShow> listTVShows;
        private int pos = 0;
        private Formulario formulario;

        public FormPrincipal()
        {
            InitializeComponent();
            listMovies = service.getMovies();
            listTVShows= service.getTVShows();
            cboBox.Text = "Series";
            btnMore.Visible= false;
            showDataSerie(pos);
        }

        // Metodos de interacción de los botones
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            pos++;
            if (cboBox.Text == "Peliculas")
            {
                if (pos >= this.listMovies.Count) { pos = 0; }
                showDataMovie(pos); }
            else
            {
                if (pos >= this.listTVShows.Count) { pos = 0; }
                showDataSerie(pos);
            }
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            pos--;
            if (cboBox.Text == "Peliculas") {
                if (pos < 0) { pos = this.listMovies.Count - 1; }
                showDataMovie(pos);
            }
            else
            {
                if (pos < 0) { pos = this.listTVShows.Count - 1; }
                showDataSerie(pos);
            }
        }
        private void showDataMovie(int pos)
        {
            labelTitulo.Text = listMovies[pos].getTitle();
            labelCategoria.Text = listMovies[pos].getGenres();
            txtBox.Text = listMovies[pos].getSynopsis();
            labelEpisodio.Text = "";
            labelTemporada.Text = "";
            String root = listMovies[pos].getIcon();
            picBox.Image = Image.FromFile(root);
        }
        private void showDataSerie(int pos) 
        {
            labelTitulo.Text = listTVShows[pos].getTitle();
            labelCategoria.Text = listTVShows[pos].getGenres();
            labelEpisodio.Text = listTVShows[pos].getEpisode();
            labelTemporada.Text = listTVShows[pos].getSeason();
            txtBox.Text = listTVShows[pos].getSynopsis();
            String root = listTVShows[pos].getIcon();
            picBox.Image = Image.FromFile(root);
        }

        
        public String getCboBoxOption() { return this.cboBox.Text ; }

        private void btnMore_Click(object sender, EventArgs e)
        {
            formulario = new Formulario();
        }
    }
}
