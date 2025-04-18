using System.Diagnostics;
using System.Drawing;

namespace ThreadPicture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "doge.jpg";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Plik nie istnieje.");
                return;
            }

            Picture original = new Picture(filePath);

            Picture neg = new Picture() { Img = new Bitmap(original.Img) };
            Picture sepia = new Picture() { Img = new Bitmap(original.Img) };
            Picture thresh = new Picture() { Img = new Bitmap(original.Img) };
            Picture gray = new Picture() { Img = new Bitmap(original.Img) };

            Parallel.Invoke(
                () => {
                    neg.ToNegative();
                    neg.Img.Save("negatyw.jpg");
                },
                () => {
                    sepia.ToSepia();
                    sepia.Img.Save("sepia.jpg");
                },
                () => {
                    thresh.Threshold(100);
                    thresh.Img.Save("progowanie.jpg");
                },
                () => {
                    gray.ToGrayscale();
                    gray.Img.Save("szarosci.jpg");
                }
            );

            Process.Start("negatyw.jpg");
            Process.Start("sepia.jpg");
            Process.Start("progowanie.jpg");
            Process.Start("szarosci.jpg");
        }
    }
}
