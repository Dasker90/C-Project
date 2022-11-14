using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAR_MEMORY_GAME_DASKER_V01
{
    public partial class A2 : Form
    {
        bool allowClick = false;
        PictureBox firstGuess;
        Random rnd = new Random();
        Timer clickTimer = new Timer();
        int time = 60;
        Timer timer = new Timer { Interval = 1000 };
        public A2()
        {
            InitializeComponent();
        }
        // Przyciski ------------------------------------------------------------------------------------------
        private void btn_return_Click(object sender, EventArgs e)
        {
            A1 a1 = new A1();
            a1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        //------------------------------------------------------------------------------------------------------
        private PictureBox[] pictureBoxes
        {
            get { return Controls.OfType<PictureBox>().ToArray(); }
        }
        private static IEnumerable<Image> images
        {
            get
            {
                return new Image[]
                {
                    Properties.Resources.main1,
                    Properties.Resources.main1,
                    Properties.Resources.main1,
                    Properties.Resources.main1,
                    Properties.Resources.main1,
                    Properties.Resources.main1,
                    Properties.Resources.main1,
                    Properties.Resources.main1,

                };
            }
        }
        private void startGameTimer()
        {
            timer1.Start();
            timer1.Tick += delegate
            {
                time--;
                if (time < 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Out of time");
                    ResetImages();
                }
                var ssTime = TimeSpan.FromSeconds(time);
                lbl_time.Text = "00:" + time.ToString();
            };
        }
        private void ResetImages()
        {
            foreach (var image in pictureBoxes)
            {
                pic.Tag = null;
                pic.Visible = true;
            }
            HideImages();
            setRandomImages();

        }
    }
    //https://www.mooict.com/c-tutorial-create-a-superhero-memory-game/
}

