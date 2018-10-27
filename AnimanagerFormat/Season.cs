using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimanagerFormat
{
    public class Season
    {
        public string name;
        public List<Episode> episodes = new List<Episode>();
        public Anime anime;
        public float progress = 0;
        public byte id = 0;

        public Season(Episode e)
        {
            episodes.Add(e);
        }

        public Season(string n)
        {
            name = n;
        }

        public Season(string n, Episode[] e)
        {
            name = n;
            episodes = e.ToList();
            recalculateProgress();
        }

        public Season(string n, Episode[] e, Anime a)
        {
            name = n;
            episodes = e.ToList();
            anime = a;
            recalculateProgress();
        }

        public float recalculateProgress()
        {
            float p = 0;
            foreach (Episode z in episodes)
            {
                if (z.watched)
                {
                    p++;
                }
            }
            progress = (p / episodes.Count) * 100;
            return progress;
        }

        public Season(string n, Anime a)
        {
            name = n;
            anime = a;
        }

        public void setEpisodes(Episode[] e)
        {
            episodes = e.ToList();
            recalculateProgress();
        }

        public void setEpisodes(List<Episode> e)
        {
            setEpisodes(e.ToArray());
        }
    }
}