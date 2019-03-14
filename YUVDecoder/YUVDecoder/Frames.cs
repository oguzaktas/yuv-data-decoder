using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

/**
 * Yazilim Laboratuvari I Proje 3
 * @author Oguz Aktas & Ebubekir Sit
 */

namespace YUVDecoder
{
    public partial class Frames : Form
    {
        private readonly List<Bitmap> bitmaps; // Bitmap dosyalarinin bulundugu liste, yalnizca constructor icinde set edilebilir (readonly)
        private int fps = 25; // Frames per second (frame rate), default = 25
        private int index; // Bitmap dosyalarini listeden sirayla secmek icin kullanilan index degeri
        private bool flag; // Replay'e basilinca onceki oynatmayi hemen durdurup yenisini baslatmak icin kullanilan kontrol degiskeni
        private bool progress; // Resume butonu icin kullanilacak timer'in calisip calismadigini kontrol eden degisken

        public Frames(List<Bitmap> bitmaps)
        {
            InitializeComponent();
            this.bitmaps = bitmaps;
            Play();
        }

        private void Play()
        {
            timer.Interval = 1000 / fps; // Timer bekleme suresi, Interval 1000 = 1 saniye, fps = frame rate
            timer.Start();
            progress = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (index != bitmaps.Count)
            {
                switch (flag)
                {
                    case true:
                        timer.Stop();
                        index = 0;
                        flag = false;
                        timer.Start();
                        progress = true;
                        break;
                    case false:
                        pictureBoxFrames.Image = bitmaps.ElementAt(index);
                        pictureBoxFrames.Refresh();
                        index++;
                        break;
                }
            }
            else
            {
                timer.Stop();
                index = 0;
                flag = false;
                progress = false;
            }
        }

        private void ButtonReplay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFPS.Text.Trim()))
            {
                flag = true;
                fps = 25; // FPS textbox'i bos birakilirsa fps 25 olarak alinacak.
                Play();
            }
            else
            {
                if (int.Parse(textBoxFPS.Text) > 1000)
                {
                    MessageBox.Show(@"FPS degeri 1000'den buyuk olamaz.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (int.Parse(textBoxFPS.Text) == 0)
                {
                    MessageBox.Show(@"FPS degeri 0 olamaz.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    flag = true;
                    fps = int.Parse(textBoxFPS.Text);
                    Play();
                }
            }

        }

        private void TextBoxFPS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                textBoxFPS.BackColor = Color.Red;
            }
            else
            {
                textBoxFPS.BackColor = Color.Yellow;
            }
        }

        private void ButtonPause_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }

        private void ButtonResume_Click(object sender, EventArgs e)
        {
            if (progress)
            {
                timer.Enabled = true;
            }
        }
    }
}
