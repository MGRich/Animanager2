using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimanagerFormat
{
    public class AnimanagerFile
    {
        public Anime[] animes;

        public AnimanagerFile(string s)
        {
            Load(File.OpenRead(s));
        }

        public AnimanagerFile(Stream s)
        {
            Load(s);
        }

        public AnimanagerFile(Anime[] a)
        {
            animes = a;
        }

        private void Load(Stream s)
        {
            string rs()
            {
                List<byte> c = new List<byte>();
                while (true)
                {
                    int d = s.ReadByte();
                    if (d == 0 || d == 17 || d == 1)
                    {
                        return Encoding.Default.GetString(c.ToArray());
                    }
                    c.Add((byte)d);
                }
            }
            List<Anime> z = new List<Anime>();
            while (s.Position != s.Length)
            {
                while (true)
                {
                    string b = rs();
                    string t = rs();
                    Anime q = new Anime(b)
                    {
                        imagePath = t
                    };
                    List<Season> x = new List<Season>();
                    while (true)
                    {
                        string c = rs();
                        Season w = new Season(c, q)
                        {
                            id = (byte)s.ReadByte()
                        };
                        List<Episode> y = new List<Episode>();
                        while (true)
                        {
                            string d = rs();
                            s.Position--;
                            bool e = Convert.ToBoolean(s.ReadByte());
                            y.Add(new Episode(d, w, q, e));
                            if (s.ReadByte() == 17)
                            {
                                break;
                            }
                            else s.Position--;
                        }
                        w.setEpisodes(y.ToArray());
                        x.Add(w);
                        if (s.ReadByte() == 34)
                        {
                            break;
                        }
                        else s.Position--;
                    }
                    q.setSeasons(x.ToArray());
                    z.Add(q);
                    break;
                }
                animes = z.ToArray();
            }
            s.Close();
        }

        public void write(string p)
        {
            if (File.Exists(p)) write(File.Open(p, FileMode.Truncate));
            else write(File.Open(p, FileMode.CreateNew));
        }

        public void write(Stream s)
        {
            List<byte> a = new List<byte>();
            foreach (Anime x in animes)
            {
                a.AddRange(Encoding.Default.GetBytes(x.name));
                a.Add(0);
                if (x.imagePath != null) a.AddRange(Encoding.Default.GetBytes(x.imagePath)); else a.Add(0);
                a.Add(0);
                foreach (Season y in x.seasons)
                {
                    a.AddRange(Encoding.Default.GetBytes(y.name));
                    a.AddRange(new byte[2] { 0, y.id });
                    foreach (Episode z in y.episodes)
                    {
                        a.AddRange(Encoding.Default.GetBytes(z.name));
                        a.Add((byte)(z.watched ? 1 : 0));
                    }
                    a.Add(0x11);
                }
                a.Add(0x22);
            }
            s.Write(a.ToArray(), 0, a.Count);
            s.Close();
        }
    }
}