using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace furi_imageProcessing
{
    public partial class Form1 : Form
    {
        private Bitmap img1;
        private byte[,] vImg1Gray;
        private byte[,] vImg1R;
        private byte[,] vImg1G;
        private byte[,] vImg1B;
        private byte[,] vImg1A;


        private Bitmap img2;
        private byte[,] vImg2Gray;
        private byte[,] vImg2R;
        private byte[,] vImg2G;
        private byte[,] vImg2B;
        private byte[,] vImg2A;


        private Bitmap imgR;
        private byte[,] vImg3Gray;
        private byte[,] vImg3R;
        private byte[,] vImg3G;
        private byte[,] vImg3B;
        private byte[,] vImg3A;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            // Abre a caixa de diálogo Open
            var filePath = string.Empty;
            openFileDialog1.InitialDirectory = "C:\\MatLab"; // Define o diretorio padrâo de selcao de imagem
            openFileDialog1.Filter = "TIFF image (*.tif)|*.tif" + // Define as possiveis extensoes das imagens
                "|JPG image (*.jpg)|*.jpg" +
                "|BMP image (*.bmp)|*.bmp" +
                "|PNG image (*.png)|*.png" +
                "|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            // Se o arquivo foi localizado com sucesso...
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;

                bool bLoadImgOk = false;

                try
                {
                    img1 = new Bitmap(filePath);
                    bLoadImgOk = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                        "Error opening image A",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    bLoadImgOk = false;
                }

                if (bLoadImgOk)
                {
                    // Adiciona 
                    pbA.Image = img1;
                    vImg1Gray = new byte[img1.Width, img1.Height];
                    vImg1R = new byte[img1.Width, img1.Height];
                    vImg1G = new byte[img1.Width, img1.Height];
                    vImg1B = new byte[img1.Width, img1.Height];
                    vImg1A = new byte[img1.Width, img1.Height];

                }
            }
        }//Fim do evento click btnA

        private void btnB_Click(object sender, EventArgs e)
        {
            // Abre a caixa de diálogo Open
            var filePath = string.Empty;
            openFileDialog1.InitialDirectory = "C:\\MatLab"; //Define o diretorio padrâo de selcao de imagem
            openFileDialog1.Filter = "TIFF image (*.tif)|*.tif" + //Define as possiveis extensoes das imagens
                "|JPG image (*.jpg)|*.jpg" +
                "|BMP image (*.bmp)|*.bmp" +
                "|PNG image (*.png)|*.png" +
                "|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            //Se o arquivo foi localizado com sucesso...
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;

                bool bLoadImgOk = false;

                try
                {
                    img2 = new Bitmap(filePath);
                    bLoadImgOk = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                        "Error opening image B",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    bLoadImgOk = false;
                }

                if (bLoadImgOk)
                {
                    pbB.Image = img2;
                }
            }
        }//Fim do evento click btB

        private void pbA_Click(object sender, EventArgs e)
        {
            btnA_Click(sender, e);
        }

        private void pbB_Click(object sender, EventArgs e)
        {
            btnB_Click(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                imgR = addImages(img1, img2);
                pbResult.Image = imgR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error adding images",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Bitmap addImages(Bitmap img1, Bitmap img2)
        {
            Bitmap imgA = resizeImage(img1);
            Bitmap imgB = resizeImage(img2);
            Bitmap outputImage = new Bitmap(imgA.Width, imgB.Height);

            int x, y;

            for (x = 0; x < imgA.Width; x++)
            {
                for (y = 0; y < imgA.Height; y++)
                {
                    Color color1 = imgA.GetPixel(x, y);
                    Color color2 = imgB.GetPixel(x, y);
                    Color color;
                    int R, G, B;
                    if (color1 != color2)
                    {
                        R = color1.R + color2.R;
                        G = color1.G + color2.G;
                        B = color1.B + color2.B;

                        if (R > 255) R = 255;
                        if (G > 255) G = 255;
                        if (B > 255) B = 255;
                        color = Color.FromArgb(R, G, B);
                    }
                    else color = color1;
                    outputImage.SetPixel(x, y, color);
                }
            }
            return outputImage;
        }

        private void btnColV_Click(object sender, EventArgs e)
        {
            Bitmap[] images = new Bitmap[2];
            images[0] = img1;
            images[1] = img2;
            try
            {
                imgR = collageVBitmap(images);
                pbResult.Image = imgR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error add images",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtDiv_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntDiv_Click(object sender, EventArgs e)
        {
            string txt = txtDiv.Text;
            if (!double.TryParse(txt, out double num) && txt != "")
            {
                MessageBox.Show("Only numbers", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(txt, "Teste");
        }

        private Bitmap resizeImage(Bitmap imgToResize)
        {
            Size size;
            Size sizeA = new Size(img1.Width, img1.Height);
            Size sizeB = new Size(img2.Width, img2.Height);
            if (sizeA.Width > sizeB.Width && sizeA.Height > sizeB.Height) size = sizeA;
            else size = sizeB;

            return new Bitmap(imgToResize, size);
        }

        private Bitmap collageVBitmap(Bitmap[] images)
        {
            images[0] = resizeImage(images[0]);
            images[1] = resizeImage(images[1]);
            if (images.All(x => x.Width == images[0].Width) == false)
            {
                throw new InvalidOperationException("all images must have the same width");
            }

            var outputHeight = images.Sum(x => x.Height);
            var outputWidth = images[0].Width;

            var outputImage = new Bitmap(outputWidth, outputHeight);

            using (var g = Graphics.FromImage(outputImage))
            {
                //set background color
                g.Clear(System.Drawing.Color.Black);

                //go through each image and draw it on the output image
                int offset = 0;
                foreach (System.Drawing.Bitmap image in images)
                {
                    g.DrawImage(image,
                        new System.Drawing.Rectangle(0, offset, image.Width, image.Height)
                    );
                    offset += image.Height;
                }
            }
            return new Bitmap(outputImage);
        }
        byte Average(byte a, byte b)
        {
            return (byte)((a + b) / 2);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            try
            {
                imgR = subImages(img1, img2);
                pbResult.Image = imgR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error subtracting images",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Bitmap subImages(Bitmap img1, Bitmap img2)
        {
            Bitmap imgA = resizeImage(img1);
            Bitmap imgB = resizeImage(img2);
            Bitmap outputImage = new Bitmap(imgA.Width, imgB.Height);

            int x, y;

            for (x = 0; x < imgA.Width; x++)
            {
                for (y = 0; y < imgA.Height; y++)
                {
                    Color color1 = imgA.GetPixel(x, y);
                    Color color2 = imgB.GetPixel(x, y);
                    Color color;
                    int R, G, B;
                    if (color1 != color2)
                    {
                        R = color1.R - color2.R;
                        G = color1.G - color2.G;
                        B = color1.B - color2.B;

                        if (R < 0) R = 0;
                        if (G < 0) G = 0;
                        if (B < 0) B = 0;
                        color = Color.FromArgb(R, G, B);
                    }
                    else color = color1;
                    outputImage.SetPixel(x, y, color);
                }
            }
            return outputImage;
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            try
            {
                imgR = avgImages(img1, img2);
                pbResult.Image = imgR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error averaging images",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Bitmap avgImages(Bitmap img1, Bitmap img2)
        {
            Bitmap imgA = resizeImage(img1);
            Bitmap imgB = resizeImage(img2);
            Bitmap outputImage = new Bitmap(imgA.Width, imgB.Height);

            int x, y;

            for (x = 0; x < imgA.Width; x++)
            {
                for (y = 0; y < imgA.Height; y++)
                {
                    Color Color1 = imgA.GetPixel(x, y);
                    Color Color2 = imgB.GetPixel(x, y);
                    Color color = Color.FromArgb(Average(Color1.R, Color2.R), Average(Color1.G, Color2.G), Average(Color1.B, Color2.B));

                    outputImage.SetPixel(x, y, color);
                }
            }

            return outputImage;
        }
    }
}
