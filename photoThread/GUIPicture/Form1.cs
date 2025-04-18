using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ThreadPicture;

namespace GUIPicture
{
    public partial class Form1 : Form
    {
        private Bitmap? img;
        public Form1()
        {
            InitializeComponent();
        }
        private void loadButton_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            var file = openFileDialog.FileName;
            if (file != null)
            {
                img = new Bitmap(file);
                defImg.Image = img;
            }
        }

        private void procesButton_Click(object sender, EventArgs e)
        {
            if (img != null)
            {
                Picture neg = new Picture((Bitmap)img.Clone());
                Picture sepia = new Picture((Bitmap)img.Clone());
                Picture thresh = new Picture((Bitmap)img.Clone());
                Picture gray = new Picture((Bitmap)img.Clone());

                Parallel.Invoke(
                    () => neg.ToNegative(),
                    () => sepia.ToSepia(),
                    () => thresh.Threshold(100),
                    () => gray.ToGrayscale()
                );

                negImg.Image = neg.Img;
                sepiaImg.Image = sepia.Img;
                threshImg.Image = thresh.Img;
                grayImg.Image = gray.Img;
            }
        }
    }
}
