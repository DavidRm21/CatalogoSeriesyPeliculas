using System.Collections.Generic;

namespace ICatalogo
{
    public class Service
    {
        private List<Movie> movieList = new List<Movie>();
        private List<TVShow> tvShowList = new List<TVShow>();

        public Service()
        {
            movieList.Add(new Movie(
                "Drive My Car", 
                "Pese a no ser capaz de recuperarse de un drama personal, Yusuke Kafuku, actor y director de teatro, acepta montar la obra Tío Vania en un festival de " +
                "Hiroshima. Allí, conoce a Misaki, una joven reservada que le han asignado como chófer. A medida" +
                " que pasan los trayectos, la sinceridad creciente de sus conversaciones les obliga a enfrentarse" +
                " a su pasado.",
                @"C:\Users\crisd\source\repos\ProyectoPOO\imagenes\drivercar.jpg", 
                "Drama"));
            movieList.Add(new Movie( 
                "Les choses humaines", 
                "Los Farel son una pareja poderosa: Jean es un destacado experto " +
                "francés y su esposa Claire una ensayista conocida por su feminismo radical. Juntos tienen un hijo ejemplar, " +
                "Alexandre, que estudia en una prestigiosa universidad estadounidense.",
                @"C:\Users\crisd\source\repos\ProyectoPOO\imagenes\les.jpg", 
                "Drama"));
            movieList.Add(new Movie( 
                "La ley de Teherán", 
                "La ley de Teherán nos cuenta la feroz persecución de un policía para " +
                "atrapar a un escurridizo narcotraficante. El aumento de toxicómanos y su deplorable situación es el motor que lleva " +
                "al protagonista también a una encarnizada lucha con un sistema legal que ofrece muy pocas garantías.",
                @"C:\Users\crisd\source\repos\ProyectoPOO\imagenes\teheran.jpg", 
                "Thriller"));
            movieList.Add(new Movie(
                "¡Nop!",
                "Dos residentes de un solitario barranco en el interior de California realizan un descubrimiento tan insólito como escalofriante. ",
                @"C:\Users\crisd\source\repos\ProyectoPOO\imagenes\nop.jpg",
                "Terror"));
            tvShowList.Add(new TVShow(
                "Pachinko", 
                "Narra la historia épica e íntima que comienza con un amor prohibido y va " +
                "creciendo hasta convertirse en una saga que viaja entre Corea, Japón y Estados Unidos para " +
                "contar un relato de guerra y paz, amor y pérdida, triunfo y ajuste de cuentas.",
                @"C:\Users\crisd\source\repos\ProyectoPOO\imagenes\pachinko.jpg",
                "Acción", 
                8, 
                2));
            tvShowList.Add(new TVShow(
                "Stranger Things 4",
                "La historia se retoma seis meses después de la batalla en el centro comercial Starcourt, que trajo terror y destrucción a Hawkins. "
                        + "Luchando contra las secuelas, nuestro grupo de amigos está separado por primera vez y tiene que afrontar las complejidades "
                        + "del instituto, lo que no les pone las cosas nada fáciles. ",
                @"C:\Users\crisd\source\repos\ProyectoPOO\imagenes\stranger.jpg",
                "Aventura",
                42,
                5));
            tvShowList.Add(new TVShow( 
                "The Walking Dead", "Tras un apocalipsis zombie, un grupo de supervivientes, dirigidos por el" +
                " policía Rick Grimes, recorre los Estados Unidos para ponerse a salvo. ",
                @"C:\Users\crisd\source\repos\ProyectoPOO\imagenes\walking.jpg", 
                "Ciencia ficción",
                77,
                11));
            tvShowList.Add(new TVShow( 
                "Separación", 
                "Mark Scout (Adam Scott) dirige un equipo en Lumon Industries, cuyos empleados se " +
                "han sometido a un procedimiento quirúrgico que separa sus recuerdos entre su ámbito laboral y su vida personal. ",
                @"C:\Users\crisd\source\repos\ProyectoPOO\imagenes\separacion.jpg", 
                "Thriller", 
                9, 
                2));

        }

        public List<Movie> getMovies() { return movieList; }
        public List<TVShow> getTVShows() { return tvShowList; }

        public void addMovie(Movie movie) { movieList.Add(movie); }
        public void removeMovie(Movie movie) { movieList.Remove(movie); }
        public void addTVShow(TVShow tvShow) { tvShowList.Add(tvShow); }
        public void removeTVShow(TVShow tvShow) { tvShowList.Remove(tvShow); }


    }
}
