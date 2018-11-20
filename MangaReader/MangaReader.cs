using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace do_you_ever_A
{
    public partial class MangaReader : Form
    {
        public MangaReader()
        {
            InitializeComponent();
            select(this, new EventArgs());
            resize();
        }

        private int p = 0;
        private int m = 0;
        private string pt = null;
        private string[] a = null;
        private bool z = false;
        private PictureBox zBox = null;

        private void load()
        {
            if (right.Image != null)
                right.Image.Dispose();
            if (left.Image != null)
                left.Image.Dispose();
            try { right.Image = Image.FromFile(a[p * 2]); }
            catch { p -= 1; return; }
            try { left.Image = Image.FromFile(a[(p * 2) + 1]); }
            catch { left.Image = null; }
            leftNum.Text = ((p * 2) + 2).ToString();
            rightNum.Text = ((p * 2) + 1).ToString();
        }

        private void resize()
        {
            Console.WriteLine(left.Width);
            left.Height = Height - 88;
            left.Width = (Width - 39) / 2;
            right.Size = left.Size;
            right.Location = new Point(left.Width + 11, 36);
            zoomBox.Size = new Size(Height / 4, Height / 4);
            z = false;
            right.BringToFront();
            zoomBox.Visible = false;
        }

        private void endResize(object sender, EventArgs e)
        {
            resize();
        }

        private void formResize(object sender, EventArgs e)
        {
            resize();
        }

        private void next(object sender, EventArgs e)
        {
            if (p + 1 > m) return; else p += 1;
            load();
        }

        private void prev(object sender, EventArgs e)
        {
            if (p - 1 < 0) return; else p -= 1;
            load();
        }

        private void select(object sender, EventArgs e)
        {
            using (FolderBrowserDialog f = new FolderBrowserDialog { Description = "Select chapter.", SelectedPath = pt })
            {
                if (f.ShowDialog() != DialogResult.OK) return;
                pt = f.SelectedPath;
            }
            p = 0;
            List<string> w = new List<string>();
            foreach (string f in Directory.EnumerateFiles(pt, "*.png", SearchOption.AllDirectories))
            {
                w.Add(f);
            }
            foreach (string f in Directory.EnumerateFiles(pt, "*.jpg", SearchOption.AllDirectories))
            {
                w.Add(f);
            }
            foreach (string f in Directory.EnumerateFiles(pt, "*.jpeg", SearchOption.AllDirectories))
            {
                w.Add(f);
            }
            foreach (string f in Directory.EnumerateFiles(pt, "*.bmp", SearchOption.AllDirectories))
            {
                w.Add(f);
            }
            a = w.ToArray();
            m = a.Length / 2;
            load();
        }

        private void fullscreenToggle(object sender, EventArgs e)
        {
            if (fullscreenCheckBox.Checked)
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
            }
            resize();
        }

        private void zoom(object sender, EventArgs e)
        {
            PictureBox q = (PictureBox)sender;
            if (q.Image == null) return;
            if (!z)
            {
                q.Width *= 2;
                if (q == right)
                {
                    q.Location = new Point(12, 36);
                }
                else
                {
                    q.BringToFront();
                }
                z = true;
                zoomBox.BringToFront();
                q.MouseMove += hover;
                zBox = q;
            }
            else
            {
                zBox.Width /= 2;
                if (zBox == right)
                {
                    zBox.Location = new Point(q.Width + 11, 36);
                }
                else
                {
                    right.BringToFront();
                }
                z = false;
                zoomBox.Visible = false;
                zBox.MouseMove -= hover;
            }
            Console.WriteLine(z);
        }

        private void pageClick(object sender, EventArgs e)
        {
            decimal v = pageNum.Value / 2;
            if (v >= m) return;
            p = v % 1 == 0 ? (int)v - 1 : (int)v;
            load();
        }

        private void hover(object sender, MouseEventArgs e)
        {
            PictureBox w = (PictureBox)sender;
            pictureBox1.BringToFront();
            pictureBox1.Parent = w;
            Pen myBrush = new Pen(Color.Red);
            Graphics formGraphics;
            formGraphics = w.CreateGraphics();
            formGraphics.DrawRectangle(myBrush, new Rectangle(0, 0, w.Image.Width, w.Image.Height));
            myBrush.Dispose();
            formGraphics.Dispose();
            Point q = getPosition(w, e.Location);
            pictureBox1.Location = q;
            zoomBox.Visible = true;
            try
            {
                zoomBox.Image = new Bitmap(w.Image).Clone(new Rectangle(new Point(q.X /*- (int)zoomNumber.Value / 100*/, q.Y), new Size((int)zoomNumber.Value, (int)zoomNumber.Value)), System.Drawing.Imaging.PixelFormat.DontCare);
            }
            catch (OutOfMemoryException)
            {
                return;
            }
            //zoomBox.Padding = new Padding(-2000, -2000  , 50, 50);
            zoomBox.Refresh();
        }

        private Point getPosition(PictureBox w, Point e)
        {
            Image img = w.Image;
            float imgA = (float)img.Width / img.Height;
            float ctrA = (float)w.Width / w.Height;
            float X = e.X;
            float Y = e.Y;
            if (imgA > ctrA)
            {
                float rW = (float)img.Width / w.Width;
                X *= rW;
                float s = (float)w.Width / img.Width;
                float dpH = s * img.Height;
                float dH = (w.Height - dpH) / 2;
                Y = (Y - dH) / s;
            }
            else
            {
                float rW = (float)img.Height / w.Height;
                Y *= rW;
                float s = (float)w.Height / img.Height;
                float dpH = s * img.Width;
                float dH = (w.Width - dpH) / 2;
                X = (X - dH) / s;
            }
            return new Point((int)X, (int)Y);
        }
    }
}