using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("GUIPicture")]

namespace ThreadPicture
{
    public class Picture
    {
        public Bitmap Img {  get;  set; }
        public Picture(string file) { 
            Img=new Bitmap(file);
        }
        public Picture(Bitmap img)
        {
            Img = img;
        }

        public Picture() { }

        public void ToGrayscale()
        {
            if (Img == null) return;

            for (int y = 0; y < Img.Height; y++)
            {
                for (int x = 0; x < Img.Width; x++)
                {
                    Color pixel = Img.GetPixel(x, y);
                    int gray = (int)(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B);
                    Img.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }
        }
        public void ToNegative()
        {
            if (Img == null) return;

            for (int y = 0; y < Img.Height; y++)
            {
                for (int x = 0; x < Img.Width; x++)
                {
                    Color pixel = Img.GetPixel(x, y);
                    int r = 255 - pixel.R;
                    int g = 255 - pixel.G;
                    int b = 255 - pixel.B;
                    Img.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
        }
        public void ToSepia()
        {
            if (Img == null) return;

            for (int y = 0; y < Img.Height; y++)
            {
                for (int x = 0; x < Img.Width; x++)
                {
                    Color pixel = Img.GetPixel(x, y);
                    int tr = (int)(0.393 * pixel.R + 0.769 * pixel.G + 0.189 * pixel.B);
                    int tg = (int)(0.349 * pixel.R + 0.686 * pixel.G + 0.168 * pixel.B);
                    int tb = (int)(0.272 * pixel.R + 0.534 * pixel.G + 0.131 * pixel.B);

                    tr = tr > 255 ? 255 : tr;
                    tg = tg > 255 ? 255 : tg;
                    tb = tb > 255 ? 255 : tb;

                    Img.SetPixel(x, y, Color.FromArgb(tr, tg, tb));
                }
            }
        }
        public void Threshold(byte threshold)
        {
            if (Img == null) return;

            for (int y = 0; y < Img.Height; y++)
            {
                for (int x = 0; x < Img.Width; x++)
                {
                    Color pixel = Img.GetPixel(x, y);
                    int gray = (int)(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B);
                    int colorValue = gray < threshold ? 0 : 255;
                    Img.SetPixel(x, y, Color.FromArgb(colorValue, colorValue, colorValue));
                }
            }
        }
    }
}
