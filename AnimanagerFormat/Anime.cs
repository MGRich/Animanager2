using System.Collections.Generic;

namespace AnimanagerFormat
{
    public class Anime
    {
        public string name;
        public int[] amounts = new int[2];
        public Season[] seasons;
        public Episode[] episodes;
        public bool manga = false;
        public float progress = 0;
        public string imagePath = null;

        public Anime(string n)
        {
            name = n;
            amounts = new int[2] { 0, 0 };
            seasons = new Season[0];
            episodes = new Episode[0];
        }

        public Anime(string n, Season[] s, Episode[] e)
        {
            name = n;
            amounts = new int[2] { s.Length, e.Length };
            seasons = s;
            episodes = e;
            recalculateProgress();
        }

        public Anime(string n, Season[] s, Episode[] e, bool m)
        {
            name = n;
            amounts = new int[2] { s.Length, e.Length };
            seasons = s;
            episodes = e;
            manga = m;
            recalculateProgress();
        }

        public void setSeasons(Season[] s)
        {
            seasons = s;
            List<Episode> x = new List<Episode>();
            foreach (Season z in s)
            {
                foreach (Episode y in z.episodes)
                {
                    x.Add(y);
                }
            }
            episodes = x.ToArray();
            recalculateProgress();
        }

        public float recalculateProgress()
        {
            float p = 0;
            foreach (Episode z in episodes)
            {
                p += z.watched ? 1 : 0;
            }
            progress = (p / episodes.Length) * 100;
            return progress;
        }

        public void setEpisodes(Episode[] e)
        {
            episodes = e;
            recalculateProgress();
        }
    }
}