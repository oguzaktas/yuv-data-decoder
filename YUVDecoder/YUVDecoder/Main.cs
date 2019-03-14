using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

/**
 * Yazilim Laboratuvari I Proje 3
 * @author Oguz Aktas & Ebubekir Sit
 */

namespace YUVDecoder
{
    public partial class Main : Form
    {
        private int yuvFormat; // YUV dosyasi formati, 0 = 4:4:4, 1 = 4:2:2, 2 = 4:2:0
        private int width;
        private int height;
        private int pixelFormat; // Image format, 0 = planar, 1 = pixel-order (packed)
        // Packed (pixel-order) image formatinda bilesenler YUV formatina gore byte akisinda sirayla bulunur (4:4:4 icin y0u0v0y1u1v1... gibi)
        // Planar image formatinda tum bilesenler her framede icin byte akisinda yan yana bulunur (4:4:4 icin y0y1y2y3y4... gibi)

        private byte[] allBytes; // Dosyadaki toplam byte sayisi (frames * pixels)
        private byte[] pixels; // Her bir frame'deki toplam pixel sayisi
        private int frames; // Goruntuyu gostermede kullanilacak frame sayisi
        private byte[,] yBytes; // Luminance (Y) pixels (her bir frame'deki Y bileseninin pixel sayisi)
        // private byte[,] uBytes; // Chrominance (Cb - U) pixels
        // private byte[,] vBytes; // Chrominance (Cr - Y) pixels
        private List<Bitmap> bitmaps; // Goruntuyu gostermede kullanilacak bitmap dosyalarinin bulunacagi liste

        public Main()
        {
            InitializeComponent();
        }

        private bool CheckInputs()
        {
            if (string.IsNullOrEmpty(textBoxFilePath.Text.Trim()))
            {
                MessageBox.Show(@"Okumak icin bir YUV dosyasi seciniz.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxFormat.SelectedIndex < 0 || comboBoxResolution.SelectedIndex < 0 || comboBoxPixelFormat.SelectedIndex < 0)
            {
                MessageBox.Show(@"Bir ya da daha fazla alani bos biraktiniz.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (comboBoxResolution.SelectedIndex == 4)
            {
                if (string.IsNullOrEmpty(textBoxWidth.Text.Trim()) || string.IsNullOrEmpty(textBoxHeight.Text.Trim()))
                {
                    MessageBox.Show(@"Bir ya da daha fazla alani bos biraktiniz.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (int.Parse(textBoxWidth.Text) == 0 || int.Parse(textBoxHeight.Text) == 0)
                {
                    MessageBox.Show(@"Resolution degerleri 0 olamaz.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (int.Parse(textBoxWidth.Text) > 1920 || int.Parse(textBoxHeight.Text) > 1080)
                {
                    MessageBox.Show(@"Resolution 1920x1080'den buyuk olamaz.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            switch (comboBoxFormat.SelectedIndex)
            {
                case 2 when comboBoxPixelFormat.SelectedIndex == 1:
                    MessageBox.Show(@"YUV 4:2:0 dosyasi yalnizca planar image formati ile okunabilir.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                default:
                    return true;
            }
        }

        [SuppressMessage("ReSharper", "ParameterHidesMember")]
        private void ParseYUV(int yuvFormat, int width, int height, int pixelFormat)
        {
            allBytes = File.ReadAllBytes(textBoxFilePath.Text); // Tum byte'lar, dosyadaki toplam byte sayisi = frames * pixels
            switch (yuvFormat)
            {
                case 0: // YUV 4:4:4 format
                    pixels = new byte[width * height * 3]; // Her bir frame'deki toplam pixel sayisi
                    frames = allBytes.Length / pixels.Length; // Frame sayisi
                    yBytes = new byte[frames, width * height]; // Luminance (Y) pixels (her bir frame'deki Y bileseninin pixel sayisi)
                    // uBytes = new byte[frames, width * height]; // Chrominance (Cb - U) pixels
                    // vBytes = new byte[frames, width * height]; // Chrominance (Cr - Y) pixels
                    for (int i = 0, k = 0; i < frames; i++, k += pixels.Length)
                    {
                        for (var j = 0; j < yBytes.GetLength(1); j++)
                        {
                            switch (pixelFormat)
                            {
                                case 0: // Planar image format (Her framede once Y bilesenleri sonra U ve en son V bilesenleri siralanmistir.)
                                    yBytes[i, j] = allBytes[j + k]; // y0y1y2y3y4y5...
                                    break;
                                case 1: // Packed (pixel-order) image format
                                    yBytes[i, j] = allBytes[j * 3 + k]; // y0u0v0y1u1v1y2u2v2...
                                    break;
                            }
                        }
                    }
                    break;
                case 1: // YUV 4:2:2 format
                    pixels = new byte[width * height * 2];
                    frames = allBytes.Length / pixels.Length;
                    yBytes = new byte[frames, width * height];
                    // uBytes = new byte[frames, width * height / 2]; // Chrominance (Cb - U) pixels
                    // vBytes = new byte[frames, width * height / 2]; // Chrominance (Cr - Y) pixels
                    for (int i = 0, k = 0; i < frames; i++, k += pixels.Length)
                    {
                        for (var j = 0; j < yBytes.GetLength(1); j++)
                        {
                            switch (pixelFormat)
                            {
                                case 0: // Planar image format
                                    yBytes[i, j] = allBytes[j + k]; // y0y1y2y3y4y5...
                                    break;
                                case 1: // Packed (pixel-order) image format
                                    yBytes[i, j] = allBytes[j * 2 + k]; // y0u0v0y1u1v1y2u2v2...
                                    break;
                            }
                        }
                    }
                    break;
                case 2: // YUV 4:2:0 format
                    pixels = new byte[width * height * 3 / 2]; // Her bir frame'deki toplam pixel sayisi
                    frames = allBytes.Length / pixels.Length; // Frame sayisi
                    yBytes = new byte[frames, width * height]; // Luminance (Y) pixels (her bir frame'deki Y bileseninin pixel sayisi)
                    // uBytes = new byte[frames, width * height / 4]; // Chrominance (Cb - U) pixels
                    // vBytes = new byte[frames, width * height / 4]; // Chrominance (Cr - Y) pixels
                    for (int i = 0, k = 0; i < frames; i++, k += pixels.Length)
                    {
                        for (var j = 0; j < yBytes.GetLength(1); j++)
                        {
                            switch (pixelFormat)
                            {
                                case 0: // Planar image format (Her framede once Y bilesenleri sonra U ve en son V bilesenleri siralanmistir.)
                                    yBytes[i, j] = allBytes[j + k]; // y0y1y2y3y4y5...
                                    break;
                            }
                            // YUV 4:2:0 dosyalari packed (pixel-order) image formati ile okunamaz. 
                        }
                    }
                    break;
            }
        }

        private void SaveBitmaps()
        {
            bitmaps = new List<Bitmap>();
            var pixel = 0;
            for (var i = 0; i < frames; i++)
            {
                var bitmap = new Bitmap(width, height, PixelFormat.Format24bppRgb);
                for (var j = 0; j < height; j++)
                {
                    for (var k = 0; k < width; k++)
                    {
                        bitmap.SetPixel(k, j, Color.FromArgb(yBytes[i, pixel], yBytes[i, pixel], yBytes[i, pixel]));
                        pixel++;
                        if (pixel == width * height)
                        {
                            pixel = 0;
                        }
                    }
                }
                bitmaps.Add(bitmap); // Olusturulan bitmap dosyalari bitmaps listesine eklendi.
                bitmap.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\frames\frame" + (i + 1) + ".bmp", ImageFormat.Bmp);
                // Olusturulan bitmap dosyalari numaralandirilarak frames dizinine kaydedildi.
            }
        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog
            {
                Title = @"Select a YUV File",
                Multiselect = false, // Coklu dosya secimi kapali
                ValidateNames = true, // Sadece gecerli isimli dosya secimi acik
                Filter = @"YUV Files|*.yuv", // Sadece .yuv uzantili dosyalar secilecek
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) // Baslangic dizini masaustu
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxFile.Text = openFileDialog.SafeFileName;
                    textBoxFilePath.Text = openFileDialog.FileName;
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            comboBoxFormat.SelectedIndex = 0;
            comboBoxResolution.SelectedIndex = 0;
            comboBoxPixelFormat.SelectedIndex = 0;
        }

        private void ComboBoxFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            yuvFormat = comboBoxFormat.SelectedIndex;
        }

        private void ComboBoxResolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxResolution.SelectedIndex == 4)
            {
                labelSize.Visible = true;
                textBoxWidth.Visible = true;
                labelX.Visible = true;
                textBoxHeight.Visible = true;
            }
            else
            {
                labelSize.Visible = false;
                textBoxWidth.Visible = false;
                labelX.Visible = false;
                textBoxHeight.Visible = false;

                switch (comboBoxResolution.SelectedIndex)
                {
                    case 0:
                        width = 176;
                        height = 144;
                        break;
                    case 1:
                        width = 352;
                        height = 288;
                        break;
                    case 2:
                        width = 720;
                        height = 576;
                        break;
                    case 3:
                        width = 1920;
                        height = 1080;
                        break;
                }
            }
        }

        private void TextBoxWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                textBoxWidth.BackColor = Color.Red;
            }
            else
            {
                textBoxWidth.BackColor = Color.Yellow;
            }
        }

        private void TextBoxHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                textBoxHeight.BackColor = Color.Red;
            }
            else
            {
                textBoxHeight.BackColor = Color.Yellow;
            }
        }

        private void ComboBoxPixelFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            pixelFormat = comboBoxPixelFormat.SelectedIndex;
        }

        private void ButtonRead_Click(object sender, EventArgs e)
        {
            if (CheckInputs())
            {
                Array.ForEach(Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\frames"), File.Delete);
                // frames dizininde bulunan tum Bitmap dosyalari silindi.
                bitmaps?.Clear(); // Framelerin bulundugu bitmaps listesi null degilse (referansi olusturulmussa) sifirlandi.

                if (comboBoxResolution.SelectedIndex == 4)
                {
                    width = int.Parse(textBoxWidth.Text);
                    height = int.Parse(textBoxHeight.Text);
                }

                ParseYUV(yuvFormat, width, height, pixelFormat); // YUV render/parse islemi

                SaveBitmaps(); // Bitmap dosyalarinin numaralandirilarak kaydedilmesi islemi
                
                MessageBox.Show(@"Bitmap dosyalari basariyla kaydedilmistir, goruntuyu oynatabilirsiniz.", @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonShow_Click(object sender, EventArgs e)
        {
            if (bitmaps == null || !bitmaps.Any())
            {
                MessageBox.Show(@"Dosyayi okuduktan sonra tekrar deneyiniz.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                new Frames(bitmaps).Visible = true;
            }
        }
    }
}
