using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ICatalogo
{
    public partial class FormPrincipal : Form
    {
        private Controller controller;
        private Service service;
        private int pos = 0;
        public static String optionSelect = "Peliculas";

        public FormPrincipal()
        {
            InitializeComponent();
            controller= new Controller();
            service= new Service();
            cboBox.Text= optionSelect;
            showDataSerie(pos);
        }

        // Metodos de interacción de los botones
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            pos++;
            if (cboBox.Text == "Peliculas")
            {
                if (pos >= controller.getMovies().Count) { pos = 0; }
                showDataMovie(pos); }
            else
            {
                if (pos >= controller.getTVShows().Count) { pos = 0; }
                showDataSerie(pos);
            }
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            pos--;
            if (cboBox.Text == "Peliculas") {
                if (pos < 0) { pos = controller.getMovies().Count - 1; }
                showDataMovie(pos);
            }
            else
            {
                if (pos < 0) { pos = controller.getTVShows().Count - 1; }
                showDataSerie(pos);
            }
        }
        private void showDataMovie(int pos)
        {
            labelTitulo.Text = controller.getMovies()[pos].getTitle();
            labelCategoria.Text = controller.getMovies()[pos].getGenres();
            txtBox.Text = controller.getMovies()[pos].getSynopsis();
            labelEpisodio.Text = "";
            labelTemporada.Text = "";
            String root = controller.getMovies()[pos].getIcon();
            picBox.Image = Image.FromFile(root);
        }
        private void showDataSerie(int pos) 
        {
            labelTitulo.Text = controller.getTVShows()[pos].getTitle();
            labelCategoria.Text = controller.getTVShows()[pos].getGenres();
            labelEpisodio.Text = controller.getTVShows()[pos].getEpisode();
            labelTemporada.Text = controller.getTVShows()[pos].getSeason();
            txtBox.Text = controller.getTVShows()[pos].getSynopsis();
            String root = controller.getTVShows()[pos].getIcon();
            picBox.Image = Image.FromFile(root);
        }
        private void btnMore_Click(object sender, EventArgs e)
        {
            optionSelect = cboBox.Text;
            Formulario formulario= new Formulario();
            formulario.Show();
            this.Hide();
        }
        
        public ComboBox GetComboBox() { return this.cboBox; }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            int pos = 0;
            if (cboBox.Text == "Peliculas")
            {
                labelTitulo.Text = controller.getMovies()[pos].getTitle();
                labelCategoria.Text = controller.getMovies()[pos].getGenres();
                txtBox.Text = controller.getMovies()[pos].getSynopsis();
                labelEpisodio.Text = "";
                labelTemporada.Text = "";
                String root = controller.getMovies()[pos].getIcon();
                picBox.Image = Image.FromFile(root);
            }
            else {
                labelTitulo.Text = controller.getTVShows()[pos].getTitle();
                labelCategoria.Text = controller.getTVShows()[pos].getGenres();
                labelEpisodio.Text = controller.getTVShows()[pos].getEpisode();
                labelTemporada.Text = controller.getTVShows()[pos].getSeason();
                txtBox.Text = controller.getTVShows()[pos].getSynopsis();
                String root = controller.getTVShows()[pos].getIcon();
                picBox.Image = Image.FromFile(root);
            }
        }
    }
}
