using System;

namespace ICatalogo
{
    public abstract class Info
    {
        private int id=0;
        private String title;
        private String synopsis;
        private String icon;
        private String genres;

        protected Info(string title, string synopsis, string icon, string genres)
        {
            id++;
            this.title = title;
            this.synopsis = synopsis;
            this.icon = icon;
            this.genres = genres;
        }

        public int getId() { return id; }
        public string getTitle() { return title; }
        public void setTitle(string title) { this.title = title;}
        public string getSynopsis() { return synopsis; }
        public void setSynopsis(string synopsis) { this.synopsis = synopsis;}
        public string getIcon() { return icon; }
        public void setIcon(string icon) { this.icon = icon;}
        public String getGenres() { return genres; }
       
    }
}
