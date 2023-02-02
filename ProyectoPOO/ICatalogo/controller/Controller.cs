using System;
using System.Collections.Generic;

namespace ICatalogo
{
    public class Controller
    {
        private Service service = new Service();
        private List<Movie> listMovies;
        private List<TVShow> listTVShows;
        public Controller()
        {
            this.listMovies = service.getMovies();
            this.listTVShows = service.getTVShows();
        }

        public List<Movie> getMovies() { return listMovies; }
        public List<TVShow> getTVShows() { return listTVShows; }
        
    }
}
