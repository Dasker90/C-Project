using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Game
{
    public partial class Form1 : Form
    {
        bool allowClick = false;
        PictureBox firstGuess;
        Random rnd = new Random();
        Timer clickTimer = new Timer();
        int time = 60;
        Timer timer = new Timer {Interval = 1000};
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // This picture box function , going to add all the picture boxes to ana array.
        // Enter this function right under the public Form 1()
        private PictureBox[] pictureBoxes
          {
            get { return Controls.OfType<PictureBox>().ToArray(); }
          }
        // Enter this function above as is. This function purpose is to link the images which we impoerted to the resources ealier.
        // Notice we are using static Ienumerable<image> in the title of this function.
        private static IEnumerable<Image> images
        {
            get
            {
                return new Image[]
                {
                    Properties.Resources.a1,
                    Properties.Resources.a2,
                    Properties.Resources.a3,    
                    Properties.Resources.a4,
                    Properties.Resources.a5,
                    Properties.Resources.a6,
                    Properties.Resources.a7,
                    Properties.Resources.a8
                };
            }
        }
        private void startGameTimer()
        {
            timer.Start();
            timer.Tick += delegate
            {
                time--;
                if (time < 0)
                {
                    timer.Stop();
                    MessageBox.Show("Out of Time","End Game");
                    ResetImages();
                }
                var ssTime = TimeSpan.FromSeconds(time);
                lbl_Time.Text = "00: " + time.ToString();
            };
        }
        private void ResetImages()
        {
            foreach(var pic in pictureBoxes)
            {
                pic.Tag = null;
                pic.Visible = true;
            }
            HideImages();
            setRandomImages();
            time = 60;
            timer.Start();
        }
        private void HideImages()
        {
            foreach(var pic in pictureBoxes)
            {
                pic.Image = Properties.Resources.a1;
            }
        }
        private PictureBox getFreeSlot()
        {
            int num;
            do
            {
                num = rnd.Next(0, pictureBoxes.Count());
            }
            while (pictureBoxes[num].Tag != null);
            return pictureBoxes[num];   
        }
        private void setRandomImages()
        {
            foreach (var image in images)
            {
                getFreeSlot().Tag = image;
                getFreeSlot().Tag = image;
            }
        }
        private void CLICKTIMER_TICK(object sender, EventArgs e)
        {
            HideImages();
            allowClick = true;
            clickTimer.Stop();
        }
        private void clickImage(object sender, EventArgs e)
        {
            if (!allowClick) return;
            var pic = (PictureBox)sender;
            if(firstGuess == null)
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }
            pic.Image = (Image)pic.Tag;
            if(pic.Image == firstGuess.Image && pic != firstGuess)
            {
                pic.Visible = firstGuess.Visible = false;
                {
                    firstGuess = pic;
                }
                HideImages();
            }
            else
            {
                allowClick = false;
                clickTimer.Start();
            }
            firstGuess = null;
            if (pictureBoxes.Any(p => p.Visible)) return;
            MessageBox.Show("Yoiu Win Now Try Again");
            ResetImages();
        }
        private void btn_New_Game_Click(object sender, EventArgs e)
        {
            pictureBox_A1 = null;
            pictureBox_A2 = null;
            pictureBox_A3 = null;
            pictureBox_A4 = null;
            pictureBox_A5 = null;
            pictureBox_A6 = null;
            pictureBox_A7 = null;
            pictureBox_A8 = null;
            pictureBox_A9 = null;
            pictureBox_A10 = null;
            pictureBox_A11 = null;
            pictureBox_A12 = null;
            pictureBox_A13 = null;
            pictureBox_A14 = null;
            pictureBox_A15 = null;
            pictureBox_A16 = null;

        }

        private void pictureBox_A1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_A2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_A3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_A4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_A5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_A6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_A7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_A8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_A9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_A10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_A11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_A12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_A13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_A14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_A15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_A16_Click(object sender, EventArgs e)
        {

        }
        // Przyciski 
        private void btn_Start_Click(object sender, EventArgs e)
        {
            allowClick = true;
            setRandomImages();
            HideImages();
            startGameTimer();
            clickTimer.Interval = 1000;
            clickTimer.Tick += CLICKTIMER_TICK;
            btn_New_Game.Enabled = false;
        }

        private void btn_play_Click(object sender, EventArgs e)
        {

        }

        private void btn_pause_Click(object sender, EventArgs e)
        {

        }


    }
}
