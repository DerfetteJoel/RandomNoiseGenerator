using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNoiseGenerator
{
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbDim.Text = "512";
            tbVar.Text = "20";

            int var = 20;
            int dim = 512;
            int[,] map = new int[dim, dim];
            Random rand = new Random();
            Bitmap bmp = new Bitmap(dim, dim);

            //Bitmap grau maskieren
            bmp = Mask(bmp, 128, 128, 128);

            //Random Noise darüber zeichnen
            bmp = drawRandomNoise(bmp, dim, var);

            picBox.Image = bmp;

        }

        private Bitmap Mask(Bitmap bmp, int r, int g, int b)
        {
            using (Graphics gfx = Graphics.FromImage(bmp))
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(r, g, b)))
            {
                gfx.FillRectangle(brush, 0, 0, bmp.Width, bmp.Height);
            }

            return bmp;
        }

        private Bitmap drawRandomNoise(Bitmap bmp, int dim, int var)
        {
            Random r = new Random();
            int[] adjacent = new int[8];
            for (int x = 1; x < dim - 1; x++)
            {
                for (int y = 1; y < dim - 1; y++)
                {
                    adjacent[0] = bmp.GetPixel(x - 1, y - 1).R;
                    adjacent[1] = bmp.GetPixel(x - 1, y).R;
                    adjacent[2] = bmp.GetPixel(x - 1, y + 1).R;
                    adjacent[3] = bmp.GetPixel(x, y - 1).R;
                    adjacent[4] = bmp.GetPixel(x, y + 1).R;
                    adjacent[5] = bmp.GetPixel(x + 1, y - 1).R;
                    adjacent[6] = bmp.GetPixel(x + 1, y).R;
                    adjacent[7] = bmp.GetPixel(x + 1, y + 1).R;

                    int min = adjacent.Min();
                    int max = adjacent.Max();

                    int g = (min + r.Next(max - min)) + r.Next(var) - r.Next(var);

                    if (g > 255)
                    {
                        g = 255;
                    }
                    if (g < 0)
                    {
                        g = 0;
                    }
                    bmp.SetPixel(x, y, Color.FromArgb(g, g, g));
                }
            }

            return bmp;
        }

        private void btNewImage_Click(object sender, EventArgs e)
        {
            int dim = 512;
            int var = 25;
            try
            {
                dim = Int32.Parse(tbDim.Text);
                var = Int32.Parse(tbVar.Text);
            }
            catch(Exception)
            {
                tbDim.Text = "512";
                tbVar.Text = "20";
            }
            Bitmap bmp = new Bitmap(dim, dim);
            bmp = Mask(bmp, 128, 128, 128);
            bmp = drawRandomNoise(bmp, dim, var);

            picBox.Image = bmp;
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "PNG (*.png)|*.png";

            if(f.ShowDialog() == DialogResult.OK)
            {
                picBox.Image.Save(f.FileName);
            }
        }
    }
}
