using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Image_processing_blackwhite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap pict_O, pict_C;
        int t;

        public Bitmap BlackAndWhite(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            int t = int.Parse(textBox1.Text);
            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    Color c = source.GetPixel(x, y);
                    int avg = (int)((c.R + c.G + c.B) / 3);
                    if (avg > t)
                        avg = 255;
                    else
                        avg = 0;
                    bmp.SetPixel(x, y, Color.FromArgb(avg, avg, avg));

                }

            }

            return bmp;
        }

        private void btnBlackWhite_Click(object sender, EventArgs e)
        {

            pict_C = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = BlackAndWhite(pict_C);

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            int t = int.Parse(textBox1.Text);
            pictureBox1.Refresh();
        }

        private void btnOrigin_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pict_O;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            pict_C = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = Insert(pict_C);
        }
        public Bitmap Insert(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    Color c = source.GetPixel(x, y);
                    int avg = (int)((c.R + c.G + c.B) / 3);
                    if (avg == 255)
                        avg = 0;
                    else
                        avg = 255;
                    bmp.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
                }
            }

            return bmp;
        }

        private void btnNagative_Click(object sender, EventArgs e)
        {
            pict_C = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = Negative(pict_O);
        }
        public Bitmap Negative(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            int r, g, b;
            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    Color c = source.GetPixel(x, y);
                    r = 255 - (int)(c.R);
                    g = 255 - (int)(c.G);
                    b = 255 - (int)(c.B);
                    bmp.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            return bmp;
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            pict_C = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = GrayScale1 (pict_O);
        }

        public Bitmap GrayScale1(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            for (int x = 0; x < bmp.Width; x++)
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color c = source.GetPixel(x, y);
                    int avr = (int)((c.R + c.G + c.B) / 3);
                    bmp.SetPixel(x, y, Color.FromArgb(avr, avr, avr));

                }

            return bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGray2_Click(object sender, EventArgs e)
        {
            pict_C = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = GrayScale2(pict_O);
        }
        public Bitmap GrayScale2(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            for (int x = 0; x < bmp.Width; x++)
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color c = source.GetPixel(x, y);
                    int avr = (int)((c.R + c.G + c.B) / 10);
                    bmp.SetPixel(x, y, Color.FromArgb(avr, avr, avr));

                }

            return bmp;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog BW = new SaveFileDialog();
            BW.Title = " Save Binaty Image";
            BW.DefaultExt = "*.jpg";
            BW.Filter = " Jpeg Files (*.jpg)|*.jpg| PNG Files (*.png)|*.png| BMP Files (*.bmp)|*.bmp";
            if (BW.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(BW.FileName);
            }
        }

        private void openpicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd
                 = new OpenFileDialog();
            ofd.Title = " Select an Imager File";
            ofd.Filter = "png Image(*.png)|*.png|jpeg Images(*.jpeg)|*jpeg|Bitmap Image(*.bmp)|*.bmp ";
            if (ofd.ShowDialog() == DialogResult.OK){

                pict_O = new Bitmap(ofd.FileName);
                pictureBox1.Image = pict_O;
                pictureBox1.Refresh();
            }
        }
    }
}
