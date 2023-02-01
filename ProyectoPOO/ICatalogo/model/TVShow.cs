using System;

namespace ICatalogo
{
    public class TVShow : Info
    {
        private int episode;
        private int season;

        public TVShow(string title, string synopsis, string icon, string genres, int episode, int season) : base(title, synopsis, icon, genres)
        {
            this.episode = episode;
            this.season = season;
        }

        public String getEpisode() { return $"Episodios: {episode}"; }
        public void setEpisode(int episode) { this.episode = episode ; }
        public String getSeason() { return $"Temporadas: {season}";}
        public void setSeason(int season) { this.season = season; }

    }
}
