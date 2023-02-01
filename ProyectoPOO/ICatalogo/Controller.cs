using System;
using System.Collections.Generic;

namespace ICatalogo
{
    internal class Controller
    {
        private Formulario formulario;
        private FormPrincipal formPrincipal;
        private Service service = new Service();
        private List<Movie> listMovies;
        private List<TVShow> listTVShows;
        public Controller()
        {
            formPrincipal= new FormPrincipal();
            this.listMovies = service.getMovies();
            this.listTVShows = service.getTVShows();
        }

        public List<Movie> getListMovies() { return this.listMovies; }
        public List<TVShow> getListTVShows() { return this.listTVShows; }

        public void clearScreen() { 
            formulario.getCover().Text = null;
            formulario.getTitulo().Text = null;
            formulario.getSynopsis().Text = null;
            formulario.getGenero().Text = null;
            formulario.getTemporada().Text = "0";
            formulario.getEpisodio().Text = "0";
        }

        public void saveInfo(){
            String titulo = formulario.getTitulo().Text;
            String descripcion = formulario.getSynopsis().Text;
            String cover = formulario.getCover().Text;
            String genero = formulario.getGenero().Text;
            int episodio = Convert.ToInt16(formulario.getEpisodio().Text);
            int temporada = Convert.ToInt16(formulario.getTemporada());
            if (formPrincipal.getCboBoxOption() == "Peliculas")
            {
                Movie movie = new Movie(titulo, descripcion, cover, genero);
                clearScreen();
            }
            else { 
                TVShow tvShow = new TVShow(titulo, descripcion, cover, genero, episodio, temporada);
                clearScreen();
            }

        }
        public void addInfo()
        {
            formulario.Visible= true;
            if (formPrincipal.getCboBoxOption() == "Peliculas")
            {
                formulario.setLabelHead("Pelicula");
                formulario.getTemporada().Enabled = false;
                formulario.getEpisodio().Enabled = false;
            }
            else
            {
                formulario.setLabelHead("Serie");
            }

        }
    }
}
