﻿using AnimanagerFormat;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Animanager2
{
    public partial class Main : Form
    {
        private string openPath = null;
        private int ni = 0;

        private Dictionary<Anime, Dictionary<string, Episode>> ase = new Dictionary<Anime, Dictionary<string, Episode>>();

        private Dictionary<Episode, TreeNode> ept = new Dictionary<Episode, TreeNode>();
        private Dictionary<string, Anime> app = new Dictionary<string, Anime>();

        private TreeNode rcl = null;

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
            calculate(node, ep);
            infoLabel3.Text = "Watched: " + (ep.watched ? "Yes" : "No");
        }

        private void calculate(TreeNode node, Episode ep)
        {
            node.ForeColor = ep.watched ? Color.Green : Color.Red;
            calcBars(ep);
            Season y = ep.season;
            Anime x = ep.anime;
            double u = y.progress;
            u = 127 - (u * 2.55 / 2);
            node.Parent.ForeColor = Color.FromArgb((int)u, (int)u, (int)u);
            double r = x.progress;
            r = 127 - (r * 2.55 / 2);
            node.Parent.Parent.ForeColor = Color.FromArgb((int)r, (int)r, (int)r);
        }

        private void calcBars(Episode ep)
        {
            seasonBar.Value = (int)ep.season.recalculateProgress();
            animeBar.Value = (int)ep.anime.recalculateProgress();
            animePercent.Text = (int)ep.anime.progress + "%";
            seasonPercent.Text = (int)ep.season.progress + "%";
        }

        private void calcBars(Season se)
        {
            seasonBar.Value = (int)se.recalculateProgress();
            animeBar.Value = (int)se.anime.recalculateProgress();
            animePercent.Text = (int)se.anime.progress + "%";
            seasonPercent.Text = (int)se.progress + "%";
        }

        private void save(object sender, EventArgs e)
        {
            if (openPath == null) saveAs(sender, e);
            else new AnimanagerFile(ase.Keys.ToArray()).write(openPath);
        }

        private void selectNode(object sender, TreeViewEventArgs e)
        {
            Episode ep = null;
            Season se = null;
            Anime a = null;
            int c = 0;
            if (e.Node.Level == 2)
            {
                ep = ase[app[e.Node.Parent.Parent.Text]][e.Node.Text];
                calcBars(ep);
                infoLabel1.Text = "Anime: " + ep.anime.name;
                infoLabel2.Text = "Season: " + ep.season.name;
                infoLabel3.Text = "Watched: " + (ep.watched ? "Yes" : "No");
                c = 2;
            }
            else if (e.Node.Level == 1)
            {
                se = ase[app[e.Node.Parent.Text]][e.Node.Nodes[0].Text].season;
                calcBars(se);
                infoLabel1.Text = "Anime: " + se.anime.name;
                infoLabel2.Text = "# of episodes: " + se.episodes.Length;
                infoLabel3.Text = "Amount watched: " + (se.progress / 100) * se.episodes.Length + "/" + se.episodes.Length;
                c = 1;
            }
            else
            {
                a = app[e.Node.Text];
                seasonBar.Value = 0;
                animeBar.Value = (int)a.recalculateProgress();
                animePercent.Text = (int)a.progress + "%";
                seasonPercent.Text = "0%";
                infoLabel1.Text = "# of seasons: " + a.seasons.Length;
                infoLabel2.Text = "# of episodes: " + a.episodes.Length;
                infoLabel3.Text = "Amount watched: " + (a.progress / 100) * a.episodes.Length + "/" + a.episodes.Length;
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
            CompactDisplay compact = new CompactDisplay(ase, a)
            {
                Text = a.name
            };
            Size = new Size(255, 39);
            Size q = Screen.FromControl(this).Bounds.Size;
            Point k = Location;
            Location = new Point(q.Width - 249, q.Height - 34);
            Visible = false;
            compact.ShowDialog();
            Visible = true;
            ase[a] = compact.se;
            foreach (Episode ep in ase[a].Values)
            {
                TreeNode node = ept[ep];
                calculate(node, ep);
            }
            Size = new Size(660, 501);
            Location = k;
        }

        private void saveAs(object sender, EventArgs e)
        {
            SaveFileDialog open = new SaveFileDialog()
            {
                Filter = "Animanager File|*.amg"
            };
            if (open.ShowDialog() != DialogResult.OK) return;
            new AnimanagerFile(ase.Keys.ToArray()).write(open.FileName);
        }

        private void parse(AnimanagerFile file)
        {
            foreach (Anime x in file.animes)
            {
                Console.WriteLine(x.name);
                app.Add(x.name, x);
                TreeNode q = fileTree.Nodes.Add(x.name);
                double r = x.progress;
                r = 127 - (r * 2.55 / 2);
                q.ForeColor = Color.FromArgb((int)r, (int)r, (int)r);
                Dictionary<string, Episode> t2 = new Dictionary<string, Episode>();
                foreach (Season y in x.seasons)
                {
                    Console.WriteLine(y.name + "-");
                    TreeNode w = q.Nodes.Add(y.name);
                    double u = y.progress;
                    u = 127 - (u * 2.55 / 2);
                    Console.WriteLine((int)u);
                    w.ForeColor = Color.FromArgb((int)u, (int)u, (int)u);
                    foreach (Episode z in y.episodes)
                    {
                        Console.WriteLine(z.name + "--" + z.watched);
                        TreeNode i = w.Nodes.Add(z.name);
                        ept.Add(z, i);
                        t2.Add(z.name, z);
                        i.ForeColor = z.watched ? Color.Green : Color.Red;
                    }
                }
                ase.Add(x, t2);
            }
        }

        private void open(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog()
            {
                Filter = "Animanager File|*.amg"
            };
            if (open.ShowDialog() != DialogResult.OK) return;
            openPath = open.FileName;
            fileTree.Nodes.Clear();
            app.Clear();
            ase.Clear();
            ni = 0;
            parse(new AnimanagerFile(open.FileName));
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

        private void nodeContextMenu(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            rcl = e.Node;
            delete(sender, e);
        }

        private void delete(object sender, EventArgs q)
        {
            if (rcl.Parent != null) if (rcl.Parent.Nodes.Count == 1) return;
            if (MessageBox.Show("Are you sure you want to delete this anime, season, or episode?\nThis action cannot be undone.",
                "Delete Conformation", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            if (rcl.Level == 0)
            {
                Anime a = app[rcl.Text];
                Season[] sl = a.seasons;
                Episode[] el = a.episodes;
                foreach (Episode e in el)
                {
                    ept[e].Remove();
                    ept.Remove(e);
                }
                TreeNode[] rn = rcl.Nodes.Cast<TreeNode>().ToArray();
                foreach (TreeNode sn in rn)
                {
                    sn.Remove();
                }
                ase.Remove(a);
                app.Remove(rcl.Text);
                rcl.Remove();
            }
            else if (rcl.Level == 1)
            {
                Anime a = app[rcl.Parent.Text];
                Season s = ase[a][rcl.Nodes[0].Text].season;
                List<Episode> el2 = a.episodes.ToList();
                foreach (Episode e in s.episodes)
                {
                    ase[a].Remove(e.name);
                    ept[e].Remove();
                    ept.Remove(e);
                    el2.Remove(e);
                }
                a.setEpisodes(el2.ToArray());
                List<Season> sl2 = a.seasons.ToList();
                sl2.Remove(s);
                rcl.Remove();
                a.setSeasons(sl2.ToArray());
            }
            else
            {
                Anime a = app[rcl.Parent.Parent.Text];
                Episode e = ase[a][rcl.Text];
                Season s = e.season;
                List<Episode> el3 = a.episodes.ToList();
                List<Episode> el4 = s.episodes.ToList();
                ase[a].Remove(e.name);
                ept[e].Remove();
                ept.Remove(e);
                el3.Remove(e);
                el4.Remove(e);
                a.setEpisodes(el3.ToArray());
                s.setEpisodes(el4.ToArray());
                rcl.Remove();
            }
        }

        private void rename(object sender, NodeLabelEditEventArgs q)
        {
            if (q.CancelEdit) return;
            rcl = q.Node;
            if (q.Label == null) return;
            if (rcl.Level == 0)
            {
                Anime a = app[rcl.Text];
                a.name = q.Label;
                app.Remove(rcl.Text);
                app.Add(q.Label, a);
            }
            else if (rcl.Level == 1)
            {
                Anime a = app[rcl.Parent.Text];
                Season s = ase[app[rcl.Parent.Text]][rcl.Nodes[0].Text].season;
                List<Season> sl = a.seasons.ToList();
                sl.Remove(s);
                s.name = q.Label;
                sl.Add(s);
                foreach (Episode e in s.episodes) e.season = s;
            }
            else
            {
                Anime a = app[rcl.Parent.Parent.Text];
                Episode e = ase[a][rcl.Text];
                Season s = e.season;
                List<Episode> el3 = a.episodes.ToList();
                List<Episode> el4 = s.episodes.ToList();
                ase[a].Remove(e.name);
                ept.Remove(e);
                el3.Remove(e);
                el4.Remove(e);
                e.name = q.Label;
                ase[a].Add(e.name, e);
                ept.Add(e, rcl);
                el3.Add(e);
                el4.Add(e);
            }
        }

        private void aboutClick(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        private void merge(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog()
            {
                Filter = "Animanager File|*.amg"
            };
            open.Multiselect = true;
            if (open.ShowDialog() != DialogResult.OK) return;
            foreach (string x in open.FileNames)
            {
                parse(new AnimanagerFile(x));
            }
        }
    }
}