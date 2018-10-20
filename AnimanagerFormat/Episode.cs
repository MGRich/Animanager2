namespace AnimanagerFormat
{
    public class Episode
    {
        public string name;
        public Season season;
        public Anime anime;
        public bool watched = false;

        public Episode(string n)
        {
            name = n;
            season = new Season(this);
        }

        public Episode(string n, Season s)
        {
            name = n;
            season = s;
        }

        public Episode(string n, Season s, Anime a)
        {
            name = n;
            season = s;
            anime = a;
        }

        public Episode(string n, Season s, Anime a, bool w)
        {
            name = n;
            season = s;
            anime = a;
            watched = w;
        }
    }
}