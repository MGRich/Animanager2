using AnimanagerFormat;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Animanager2
{
    public partial class CompactDisplay : Form
    {
        public Dictionary<string, Episode> se;
        public Dictionary<string, Episode> so;
        public Anime anime;
        public List<Episode> completed = new List<Episode>();

        public CompactDisplay(Dictionary<Anime, Dictionary<string, Episode>> e, Anime a)
        {
            anime = a;
            se = e[a];
            so = e[a];
            InitializeComponent();
            foreach (Season y in a.seasons)
            {
                TreeNode w = treeView1.Nodes.Add(y.name);
                double u = y.progress;
                u *= 2.55;
                u /= 2;
                u = 127 - u;
                w.ForeColor = Color.FromArgb((int)u, (int)u, (int)u);
                label2.Text = (int)a.progress + "%";
                foreach (Episode z in y.episodes)
                {
                    TreeNode i = w.Nodes.Add(z.name);
                    i.ForeColor = z.watched ? Color.Green : Color.Red;
                }
            }
        }

        private void nodeDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level == 1) toggle(e.Node);
        }

        private void toggle(TreeNode node)
        {
            Episode ep = se[node.Text];
            Episode epo = so[node.Text];
            if (!ep.watched == epo.watched)
            {
                if (completed.Contains(ep))
                {
                    completed.Remove(ep);
                }
            }
            else ep.watched ^= true; completed.Add(ep); Console.WriteLine(ep.name);
            node.ForeColor = ep.watched ? Color.Green : Color.Red;
            label1.Text = (int)ep.season.recalculateProgress() + "%";
            label2.Text = (int)ep.anime.recalculateProgress() + "%";
            Season y = ep.season;
            double u = y.progress;
            u *= 2.55;
            u /= 2;
            u = 127 - u;
            node.Parent.ForeColor = Color.FromArgb((int)u, (int)u, (int)u);
        }

        private void checkChange(object sender, EventArgs e)
        {
            TopMost = pinCheck.Checked;
        }

        private void resize(object sender, EventArgs e)
        {
            treeView1.Size = new Size(Size.Width - 41, Size.Height - 85);
            int h = Size.Height - 85 + 13;
            pinCheck.Location = new Point(12, h + 8);
            label1.Location = new Point(57, h + 9);
            label2.Location = new Point(86, h + 9);
            okButton.Location = new Point(117, h + 4);
        }

        private void exit(object sender, EventArgs e)
        {
            Close();
        }
    }
}