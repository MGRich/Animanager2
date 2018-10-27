using AnimanagerFormat;
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Animanager2
{
    public partial class Main : Form
    {
        private AnimanagerFile openFile;
        private string openPath = null;
        private int ni = 0;

        //private Dictionary<string, Episode> epp = new Dictionary<string, Episode>();
        private Dictionary<Anime, Dictionary<string, Episode>> ase = new Dictionary<Anime, Dictionary<string, Episode>>();

        private Dictionary<Episode, TreeNode> ept = new Dictionary<Episode, TreeNode>();
        private Dictionary<string, Anime> app = new Dictionary<string, Anime>();

        public Main()
        {
            InitializeComponent();
        }

        private void nodeDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level == 2) toggle(e.Node);
            if (e.Node.Level == 0) openCompact(app[e.Node.Text]);
        }

        private void toggle(TreeNode node)
        {
            Episode ep = ase[app[node.Parent.Parent.Text]][node.Text];
            ep.watched ^= true;
            infoLabel3.Text = "Watched: " + (ep.watched ? "Yes" : "No");
            node.ForeColor = ep.watched ? Color.Green : Color.Red;
            progressBar3.Value = (int)ep.season.recalculateProgress();
            progressBar2.Value = (int)ep.anime.recalculateProgress();
            label4.Text = (int)ep.anime.progress + "%";
            label5.Text = (int)ep.season.progress + "%";
            Season y = ep.season;
            Anime x = ep.anime;
            double u = y.progress;
            u *= 2.55;
            u /= 2;
            u = 127 - u;
            node.Parent.ForeColor = Color.FromArgb((int)u, (int)u, (int)u);
            double r = x.progress;
            r *= 2.55;
            r /= 2;
            r = 127 - r;
            node.Parent.Parent.ForeColor = Color.FromArgb((int)r, (int)r, (int)r);
        }

        private void save(object sender, EventArgs e)
        {
            if (openPath == null) saveAs(sender, e); else openFile.write(openPath);
        }

        private void selectNode(object sender, TreeViewEventArgs e)
        {
            Episode ep = null;
            Season se = null;
            Anime a = null;
            int c = 0;
            switch (e.Node.Level)
            {
                case 2:
                    ep = ase[app[e.Node.Parent.Parent.Text]][e.Node.Text];
                    progressBar3.Value = (int)ep.season.recalculateProgress();
                    progressBar2.Value = (int)ep.anime.recalculateProgress();
                    label4.Text = (int)ep.anime.progress + "%";
                    label5.Text = (int)ep.season.progress + "%";
                    infoLabel1.Text = "Anime: " + ep.anime.name;
                    infoLabel2.Text = "Season: " + ep.season.name;
                    infoLabel3.Text = "Watched: " + (ep.watched ? "Yes" : "No");
                    c = 2;
                    break;

                case 1:
                    se = ase[app[e.Node.Parent.Text]][e.Node.Nodes[0].Text].season;
                    progressBar3.Value = (int)se.recalculateProgress();
                    progressBar2.Value = (int)se.anime.recalculateProgress();
                    label4.Text = (int)se.anime.progress + "%";
                    label5.Text = (int)se.progress + "%";
                    infoLabel1.Text = "Anime: " + se.anime.name;
                    infoLabel2.Text = "# of episodes: " + se.episodes.Count;
                    infoLabel3.Text = "Amount watched: " + (se.progress / 100) * se.episodes.Count + "/" + se.episodes.Count;
                    c = 1;
                    break;

                case 0:
                    a = app[e.Node.Text];
                    progressBar3.Value = 0;
                    progressBar2.Value = (int)a.recalculateProgress();
                    label4.Text = (int)a.progress + "%";
                    label5.Text = "0%";
                    infoLabel1.Text = "# of seasons: " + a.seasons.Length;
                    infoLabel2.Text = "# of episodes: " + a.episodes.Length;
                    infoLabel3.Text = "Amount watched: " + (a.progress / 100) * a.episodes.Length + "/" + a.episodes.Length;
                    break;
            }
            if (openPath != null)
            {
                {
                    imageBox.Visible = true;
                    if (imageBox.Image != null) imageBox.Image.Dispose();
                    imageText.Visible = true;
                    imageButton.Visible = true;
                    imageButton.Enabled = true;
                    imageIDNum.Visible = true;
                    imageIDButton.Visible = true;
                    imageIDButton.Enabled = true;
                    imageIDLabel.Visible = true;
                }
                string p = Path.GetDirectoryName(openPath) + @"\";
                string q = null;
                switch (c)
                {
                    case 2:
                        se = ep.season;
                        goto case 1;

                    case 1:
                        a = se.anime;
                        imageIDNum.Value = se.id;
                        q = p + a.imagePath + @"\" + se.id + ".png";
                        if (!File.Exists(q))
                        {
                            goto case 0;
                        }
                        break;

                    case 0:
                        q = p + a.imagePath + @"\a.png";
                        imageIDNum.Visible = false;
                        imageIDButton.Visible = false;
                        imageIDButton.Enabled = false;
                        imageIDLabel.Visible = false;
                        break;
                }
                Console.WriteLine(q);
                if (File.Exists(q))
                {
                    imageBox.Image = Image.FromFile(q);
                    imageText.Text = a.imagePath;
                }
                else
                {
                    imageBox.Image = null;
                }
            }
        }

        private void openCompact(Anime a)
        {
            CompactDisplay compact = new CompactDisplay(ase, a);
            Size = new Size(255, 39);
            Size q = Screen.FromControl(this).Bounds.Size;
            Point k = Location;
            Location = new Point(q.Width - 249, q.Height - 34);
            compact.ShowDialog();
            ase[a] = compact.se;
            foreach (Episode ep in ase[a].Values)
            {
                TreeNode node = ept[ep];
                node.ForeColor = ep.watched ? Color.Green : Color.Red;
                progressBar3.Value = (int)ep.season.recalculateProgress();
                progressBar2.Value = (int)ep.anime.recalculateProgress();
                label4.Text = (int)ep.anime.progress + "%";
                label5.Text = (int)ep.season.progress + "%";
                Season y = ep.season;
                Anime x = ep.anime;
                double u = y.progress;
                u *= 2.55;
                u /= 2;
                u = 127 - u;
                node.Parent.ForeColor = Color.FromArgb((int)u, (int)u, (int)u);
                double r = x.progress;
                r *= 2.55;
                r /= 2;
                r = 127 - r;
                node.Parent.Parent.ForeColor = Color.FromArgb((int)r, (int)r, (int)r);
            }
            Size = new Size(660, 501);
            Location = k;
        }

        private void saveAs(object sender, EventArgs e)
        {
            SaveFileDialog open = new SaveFileDialog();
            if (open.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            openFile = new AnimanagerFile(ase.Keys.ToArray());
            openFile.write(open.FileName);
        }

        private void open(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            openFile = new AnimanagerFile(open.FileName);
            openPath = open.FileName;
            fileTree.Nodes.Clear();
            app.Clear();
            ase.Clear();
            ni = 0;
            foreach (Anime x in openFile.animes)
            {
                Console.WriteLine(x.name);
                app.Add(x.name, x);
                TreeNode q = fileTree.Nodes.Add(x.name);
                double r = x.progress;
                r *= 2.55;
                r /= 2;
                r = 127 - r;
                q.ForeColor = Color.FromArgb((int)r, (int)r, (int)r);
                Dictionary<string, Episode> t2 = new Dictionary<string, Episode>();
                foreach (Season y in x.seasons)
                {
                    Console.WriteLine(y.name + "-");
                    TreeNode w = q.Nodes.Add(y.name);
                    double u = y.progress;
                    /*if (u == 0)
                    {
                        u = 1;
                    }*/
                    u *= 2.55;
                    u /= 2;
                    u = 127 - u;
                    Console.WriteLine((int)u);
                    //Console.WriteLine(127 - u);
                    w.ForeColor = Color.FromArgb((int)u, (int)u, (int)u);
                    foreach (Episode z in y.episodes)
                    {
                        Console.WriteLine(z.name + "--" + z.watched);
                        TreeNode i = w.Nodes.Add(z.name);
                        //epp.Add(z.name, z);
                        ept.Add(z, i);
                        t2.Add(z.name, z);
                        i.ForeColor = z.watched ? Color.Green : Color.Red;
                    }
                }
                ase.Add(x, t2);
            }
        }

        private void add(object sender, EventArgs e)
        {
            string n = addText.Text;
            if (n == "") return;
            string sel = addBox.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked).Text.Substring(0, 1);
            if (sel == "A")
            {
                Anime a = new Anime(n);
                Season b = new Season("New Season", a);
                Episode c = new Episode("New Episode " + ni++, b, a, true);
                b.setEpisodes(new Episode[1] { c });
                a.setSeasons(new Season[1] { b });
                Dictionary<string, Episode> t = new Dictionary<string, Episode>
                {
                    { c.name, c }
                };
                ase.Add(a, t);
                app.Add(a.name, a);
                TreeNode q = fileTree.Nodes.Add(a.name).Nodes.Add(b.name).Nodes.Add(c.name);
                toggle(q);
                ept.Add(c, q);
            }
            else if (sel == "S")
            {
                if (fileTree.SelectedNode == null) return;
                TreeNode node = fileTree.SelectedNode;
                if (node.Level != 0)
                {
                    if (node.Level == 1)
                    {
                        node = node.Parent;
                    }
                    if (node.Level == 2)
                    {
                        node = node.Parent.Parent;
                    }
                }
                Anime a = app[node.Text];
                Season b = new Season(n, a);
                Episode c = new Episode("New Episode " + ni++, b, a, true);
                b.setEpisodes(new Episode[1] { c });
                List<Season> d = a.seasons.ToList();
                d.Add(b);
                a.setSeasons(d.ToArray());
                List<Episode> h = a.episodes.ToList();
                h.Add(c);
                a.setEpisodes(h.ToArray());
                Dictionary<string, Episode> t = new Dictionary<string, Episode>
                {
                    { c.name, c }
                };
                Dictionary<string, Episode> f = ase[a];
                t.ToList().ForEach(x => f.Add(x.Key, x.Value));
                ase[a] = f;
                TreeNode q = node.Nodes.Add(b.name).Nodes.Add(c.name);
                toggle(q);
                ept.Add(c, q);
            }
            else if (sel == "E")
            {
                if (fileTree.SelectedNode == null) return;
                TreeNode node = fileTree.SelectedNode;
                if (node.Level != 1)
                {
                    if (node.Level == 2)
                        node = node.Parent;
                    else return;
                }
                Season b = ase[app[node.Parent.Text]][node.Nodes[0].Text].season;
                Anime a = ase[app[node.Parent.Text]][node.Nodes[0].Text].anime;
                if (ase[a].Keys.Contains(n)) return;
                Episode c = new Episode(n, b, a, true);
                List<Episode> g = b.episodes.ToList();
                g.Add(c);
                b.setEpisodes(g.ToArray());
                List<Episode> h = a.episodes.ToList();
                h.Add(c);
                a.setEpisodes(h.ToArray());
                Dictionary<string, Episode> t = new Dictionary<string, Episode>
                {
                    { c.name, c }
                };
                Dictionary<string, Episode> f = ase[a];
                t.ToList().ForEach(x => f.Add(x.Key, x.Value));
                ase[a] = f;
                TreeNode q = node.Nodes.Add(c.name);
                toggle(q);
                ept.Add(c, q);
            }
        }

        private void setImagePath(object sender, EventArgs e)
        {
            Anime a = null;
            TreeNode node = fileTree.SelectedNode;
            if (node == null) return;
            switch (node.Level)
            {
                case 2:
                    a = ase[app[node.Parent.Parent.Text]][node.Text].anime;
                    break;

                case 1:
                    a = ase[app[node.Parent.Text]][node.Nodes[0].Text].anime;
                    break;

                case 0:
                    a = app[node.Text];
                    break;
            }
            a.imagePath = imageText.Text;
            selectNode(sender, new TreeViewEventArgs(node));
        }

        private void setID(object sender, EventArgs e)
        {
            Season s = null;
            TreeNode node = fileTree.SelectedNode;
            if (node == null) return;
            switch (node.Level)
            {
                case 2:
                    s = ase[app[node.Parent.Parent.Text]][node.Text].season;
                    break;

                case 1:
                    s = ase[app[node.Parent.Text]][node.Nodes[0].Text].season;
                    break;

                case 0:
                    return;
            }
            s.id = (byte)imageIDNum.Value;
            selectNode(sender, new TreeViewEventArgs(node));
        }

        private void tests(object sender, EventArgs e)
        {
            Console.WriteLine(Size.Width + " " + Size.Height);
        }
    }
}