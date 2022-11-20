using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        // dane ---------------------------------
        Boolean checker;
        int plusone;
        System.Timers.Timer t;
        int h, m, s;
        SoundPlayer soundPlayer = new SoundPlayer(soundLocation: @"B:\C# Project\TicTacToe\Music\d.wav");

        public SoundPlayer SoundPlayer { get => soundPlayer; set => soundPlayer = value; }

        public Form1()
        {
            InitializeComponent();
            lblPlayerX.Text = "0";
            lblPlayer0.Text = "0";
            btnTic1.BackColor = Color.LimeGreen;
            btnTic2.BackColor = Color.LimeGreen;
            btnTic3.BackColor = Color.LimeGreen;
            btnTic4.BackColor = Color.LimeGreen;
            btnTic5.BackColor = Color.LimeGreen;
            btnTic6.BackColor = Color.LimeGreen;
            btnTic7.BackColor = Color.LimeGreen;
            btnTic8.BackColor = Color.LimeGreen;
            btnTic9.BackColor = Color.LimeGreen;
        }
        private void OnTimeEvent(object sender, EventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if(m==60)
                {
                    m = 0;
                    h += 1;
                }
                txtResult.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }));
        }
        //--------------------------------------------------------------------------------------------------------------------
        // Enable - Falce
        void Enable_False()
        {
            btnTic1.Enabled = false;
            btnTic2.Enabled = false;
            btnTic3.Enabled = false;
            btnTic4.Enabled = false;
            btnTic5.Enabled = false;
            btnTic6.Enabled = false;
            btnTic7.Enabled = false;
            btnTic8.Enabled = false;
            btnTic9.Enabled = false;
        }
        //--------------------------------------------------------------------------------------------------------------------
        // Score
        void score()
        {
            //--------------------------------------------------------------------------------------------------------------------
            // Player X
            // ---
            if(btnTic1.Text =="X" && btnTic2.Text=="X" && btnTic3.Text == "X")
            {
                btnTic1.BackColor = System.Drawing.Color.Turquoise;
                btnTic2.BackColor = System.Drawing.Color.Turquoise;
                btnTic3.BackColor = System.Drawing.Color.Turquoise;
                MessageBox.Show("The winner is Player X","Tic Tac Toe",MessageBoxButtons.OK,MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (btnTic4.Text == "X" && btnTic5.Text == "X" && btnTic6.Text == "X")
            {
                btnTic4.BackColor = System.Drawing.Color.Turquoise;
                btnTic5.BackColor = System.Drawing.Color.Turquoise;
                btnTic6.BackColor = System.Drawing.Color.Turquoise;
                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (btnTic7.Text == "X" && btnTic8.Text == "X" && btnTic9.Text == "X")
            {
                btnTic7.BackColor = System.Drawing.Color.Turquoise;
                btnTic8.BackColor = System.Drawing.Color.Turquoise;
                btnTic9.BackColor = System.Drawing.Color.Turquoise;
                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            // |||
            if (btnTic1.Text == "X" && btnTic4.Text == "X" && btnTic7.Text == "X")
            {
                btnTic1.BackColor = System.Drawing.Color.Turquoise;
                btnTic4.BackColor = System.Drawing.Color.Turquoise;
                btnTic7.BackColor = System.Drawing.Color.Turquoise;
                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (btnTic2.Text == "X" && btnTic5.Text == "X" && btnTic8.Text == "X")
            {
                btnTic2.BackColor = System.Drawing.Color.Turquoise;
                btnTic5.BackColor = System.Drawing.Color.Turquoise;
                btnTic8.BackColor = System.Drawing.Color.Turquoise;
                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (btnTic3.Text == "X" && btnTic6.Text == "X" && btnTic9.Text == "X")
            {
                btnTic3.BackColor = System.Drawing.Color.Turquoise;
                btnTic6.BackColor = System.Drawing.Color.Turquoise;
                btnTic9.BackColor = System.Drawing.Color.Turquoise;
                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone +1);
                Enable_False();
            }
            // po skosie w prawo
            if (btnTic1.Text == "X" && btnTic5.Text == "X" && btnTic7.Text == "X")
            {
                btnTic1.BackColor = System.Drawing.Color.Turquoise;
                btnTic5.BackColor = System.Drawing.Color.Turquoise;
                btnTic7.BackColor = System.Drawing.Color.Turquoise;
                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            // po skosie w lewo
            if (btnTic1.Text == "X" && btnTic5.Text == "X" && btnTic9.Text == "X")
            {
                btnTic1.BackColor = System.Drawing.Color.Turquoise;
                btnTic5.BackColor = System.Drawing.Color.Turquoise;
                btnTic9.BackColor = System.Drawing.Color.Turquoise;
                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            // 4-8-6
            if (btnTic4.Text == "X" && btnTic8.Text == "X" && btnTic6.Text == "X")
            {
                btnTic4.BackColor = System.Drawing.Color.Turquoise;
                btnTic8.BackColor = System.Drawing.Color.Turquoise;
                btnTic6.BackColor = System.Drawing.Color.Turquoise;
                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            // 2-6-8
            if (btnTic2.Text == "X" && btnTic6.Text == "X" && btnTic8.Text == "X")
            {
                btnTic2.BackColor = System.Drawing.Color.Turquoise;
                btnTic6.BackColor = System.Drawing.Color.Turquoise;
                btnTic8.BackColor = System.Drawing.Color.Turquoise;
                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone +1);
                Enable_False();
            }
            // 6-8-4
            if (btnTic6.Text == "X" && btnTic8.Text == "X" && btnTic4.Text == "X")
            {
                btnTic6.BackColor = System.Drawing.Color.Turquoise;
                btnTic8.BackColor = System.Drawing.Color.Turquoise;
                btnTic4.BackColor = System.Drawing.Color.Turquoise;
                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone +1);
                Enable_False();
            }
            // 2-4-8
            if (btnTic2.Text == "X" && btnTic4.Text == "X" && btnTic8.Text == "X")
            {
                btnTic2.BackColor = System.Drawing.Color.Turquoise;
                btnTic4.BackColor = System.Drawing.Color.Turquoise;
                btnTic8.BackColor = System.Drawing.Color.Turquoise;
                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            //--------------------------------------------------------------------------------------------------------------------
            // Player 0
            // ---
            if(btnTic1.Text =="0" && btnTic2.Text=="0" && btnTic3.Text == "0")
            {
                btnTic1.BackColor = System.Drawing.Color.Yellow;
                btnTic2.BackColor = System.Drawing.Color.Yellow;
                btnTic3.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("The winner is Player 0","Tic Tac Toe",MessageBoxButtons.OK,MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayer0.Text);
                lblPlayer0.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (btnTic4.Text == "0" && btnTic5.Text == "0" && btnTic6.Text == "0")
            {
                btnTic4.BackColor = System.Drawing.Color.Yellow;
                btnTic5.BackColor = System.Drawing.Color.Yellow;
                btnTic6.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("The winner is Player 0", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayer0.Text);
                lblPlayer0.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (btnTic7.Text == "0" && btnTic8.Text == "0" && btnTic9.Text == "0")
            {
                btnTic7.BackColor = System.Drawing.Color.Yellow;
                btnTic8.BackColor = System.Drawing.Color.Yellow;
                btnTic9.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("The winner is Player 0", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayer0.Text);
                lblPlayer0.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            // |||
            if (btnTic1.Text == "0" && btnTic4.Text == "0" && btnTic7.Text == "0")
            {
                btnTic1.BackColor = System.Drawing.Color.Yellow;
                btnTic4.BackColor = System.Drawing.Color.Yellow;
                btnTic7.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("The winner is Player 0", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayer0.Text);
                lblPlayer0.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (btnTic2.Text == "0" && btnTic5.Text == "0" && btnTic8.Text == "0")
            {
                btnTic2.BackColor = System.Drawing.Color.Yellow;
                btnTic5.BackColor = System.Drawing.Color.Yellow;
                btnTic8.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("The winner is Player 0", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayer0.Text);
                lblPlayer0.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (btnTic3.Text == "0" && btnTic6.Text == "0" && btnTic9.Text == "0")
            {
                btnTic3.BackColor = System.Drawing.Color.Yellow;
                btnTic6.BackColor = System.Drawing.Color.Yellow;
                btnTic9.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("The winner is Player 0", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayer0.Text);
                lblPlayer0.Text = Convert.ToString(plusone);
                Enable_False();
            }
            // po skosie w prawo
            if (btnTic1.Text == "0" && btnTic5.Text == "0" && btnTic7.Text == "0")
            {
                btnTic1.BackColor = System.Drawing.Color.Yellow;
                btnTic5.BackColor = System.Drawing.Color.Yellow;
                btnTic7.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("The winner is Player 0", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayer0.Text);
                lblPlayer0.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            // po skosie w lewo
            if (btnTic1.Text == "0" && btnTic5.Text == "0" && btnTic9.Text == "0")
            {
                btnTic1.BackColor = System.Drawing.Color.Yellow;
                btnTic5.BackColor = System.Drawing.Color.Yellow;
                btnTic9.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("The winner is Player 0", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayer0.Text);
                lblPlayer0.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            // 4-8-6
            if (btnTic4.Text == "0" && btnTic8.Text == "0" && btnTic6.Text == "0")
            {
                btnTic4.BackColor = System.Drawing.Color.Yellow;
                btnTic8.BackColor = System.Drawing.Color.Yellow;
                btnTic6.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("The winner is Player 0", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayer0.Text);
                lblPlayer0.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            // 2-6-8
            if (btnTic2.Text == "0" && btnTic6.Text == "0" && btnTic8.Text == "0")
            {
                btnTic2.BackColor = System.Drawing.Color.Yellow;
                btnTic6.BackColor = System.Drawing.Color.Yellow;
                btnTic8.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("The winner is Player 0", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayer0.Text);
                lblPlayer0.Text = Convert.ToString(plusone +1);
                Enable_False();
            }
            // 6-8-4
            if (btnTic6.Text == "0" && btnTic8.Text == "0" && btnTic4.Text == "0")
            {
                btnTic6.BackColor = System.Drawing.Color.Yellow;
                btnTic8.BackColor = System.Drawing.Color.Yellow;
                btnTic4.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("The winner is Player 0", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayer0.Text);
                lblPlayer0.Text = Convert.ToString(plusone +1);
                Enable_False();
            }
            // 2-4-8
            if (btnTic2.Text == "0" && btnTic4.Text == "0" && btnTic8.Text == "0")
            {
                btnTic2.BackColor = System.Drawing.Color.Yellow;
                btnTic4.BackColor = System.Drawing.Color.Yellow;
                btnTic8.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("The winner is Player 0", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayer0.Text);
                lblPlayer0.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            //--------------------------------------------------------------------------------------------------------------------
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // stoper --------------------------
            t = new System.Timers.Timer();
            t.Interval = 1000; //1s
            t.Elapsed += OnTimeEvent;
            //----------------------------------
            t.Start();
        }
        //--------------------------------------------------------------------------------------------------------------------
        // Przyciski
        private void btnTic1_Click(object sender, EventArgs e)
        {
            if(checker == false)
            {
                btnTic1.Text = "X";
                btnTic1.BackColor = System.Drawing.Color.DarkTurquoise;
                checker = true;
            }
            else
            {
                btnTic1.Text = "0";
                btnTic1.BackColor = System.Drawing.Color.Yellow;
                checker = false;
            }
            score();
            btnTic1.Enabled= false;
        }

        private void btnTic2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic2.Text = "X";
                btnTic2.BackColor = System.Drawing.Color.DarkTurquoise;
                checker = true;
            }
            else
            {
                btnTic2.Text = "0";
                btnTic2.BackColor = System.Drawing.Color.Yellow;
                checker = false;
            }
            score();
            btnTic2.Enabled = false;
        }

        private void btnTic3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic3.Text = "X";
                btnTic3.BackColor = System.Drawing.Color.DarkTurquoise;
                checker = true;
            }
            else
            {
                btnTic3.Text = "0";
                btnTic3.BackColor = System.Drawing.Color.Yellow;
                checker = false;
            }
            score();
            btnTic3.Enabled = false;
        }

        private void btnTic4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic4.Text = "X";
                btnTic4.BackColor = System.Drawing.Color.DarkTurquoise;
                checker = true;
            }
            else
            {
                btnTic4.Text = "0";
                btnTic4.BackColor = System.Drawing.Color.Yellow;
                checker = false;
            }
            score();
            btnTic4.Enabled = false;
        }

        private void btnTic5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic5.Text = "X";
                btnTic5.BackColor = System.Drawing.Color.DarkTurquoise;
                checker = true;
            }
            else
            {
                btnTic5.Text = "0";
                btnTic5.BackColor = System.Drawing.Color.Yellow;
                checker = false;
            }
            score();
            btnTic5.Enabled = false;
        }

        private void btnTic6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic6.Text = "X";
                btnTic6.BackColor = System.Drawing.Color.DarkTurquoise;
                checker = true;
            }
            else
            {
                btnTic6.Text = "0";
                btnTic6.BackColor = System.Drawing.Color.Yellow;
                checker = false;
            }
            score();
            btnTic6.Enabled = false;
        }

        private void btnTic7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic7.Text = "X";
                btnTic7.BackColor = System.Drawing.Color.DarkTurquoise;
                checker = true;
            }
            else
            {
                btnTic7.Text = "0";
                btnTic7.BackColor = System.Drawing.Color.Yellow;
                checker = false;
            }
            score();
            btnTic7.Enabled = false;
        }

        private void btnTic8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic8.Text = "X";
                btnTic8.BackColor = System.Drawing.Color.DarkTurquoise;
                checker = true;
            }
            else
            {
                btnTic8.Text = "0";
                btnTic8.BackColor = System.Drawing.Color.Yellow;
                checker = false;
            }
            score();
            btnTic8.Enabled = false;
        }

        private void btnTic9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic9.Text = "X";
                btnTic9.BackColor = System.Drawing.Color.DarkTurquoise;
                checker = true;
            }
            else
            {
                btnTic9.Text = "0";
                btnTic9.BackColor = System.Drawing.Color.Yellow;
                checker = false;
            }
            score();
            btnTic9.Enabled = false;
        }
        //--------------------------------------------------------------------------------------------------------------------
        // Prawy Pael 3 przyciski
        private void btn_New_Game_Click(object sender, EventArgs e)
        {
            try
            {
                btnTic1.Enabled = true;
                btnTic2.Enabled = true;
                btnTic3.Enabled = true;
                btnTic4.Enabled = true;
                btnTic5.Enabled = true;
                btnTic6.Enabled = true;
                btnTic7.Enabled = true;
                btnTic8.Enabled = true;
                btnTic9.Enabled = true;

                btnTic1.Text = "";
                btnTic2.Text = "";
                btnTic3.Text = "";
                btnTic4.Text = "";
                btnTic5.Text = "";
                btnTic6.Text = "";
                btnTic7.Text = "";
                btnTic8.Text = "";
                btnTic9.Text = "";

                btnTic1.BackColor = Color.LimeGreen;
                btnTic2.BackColor = Color.LimeGreen;
                btnTic3.BackColor = Color.LimeGreen;
                btnTic4.BackColor = Color.LimeGreen;
                btnTic5.BackColor = Color.LimeGreen;
                btnTic6.BackColor = Color.LimeGreen;
                btnTic7.BackColor = Color.LimeGreen;
                btnTic8.BackColor = Color.LimeGreen;
                btnTic9.BackColor = Color.LimeGreen;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tac Toe", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            // reset kolorów -----------------------------------------------
            panel1.BackColor = Color.SpringGreen;
            lbl_Napis_Glowny.ForeColor = Color.Black;
            lbl_Napis_PlayerO.ForeColor = Color.Black;
            lbl_Napis_PlayerX.ForeColor = Color.Black;
            panel2.BackColor = Color.MediumSpringGreen;
            panel3.BackColor = Color.SpringGreen;
            panel4.BackColor = Color.Turquoise;
            panel5.BackColor = Color.MediumSpringGreen;

            try
            {
                MessageBox.Show("The game has been reseted", "Tic Tac Toe");
                lblPlayerX.Text = "0";
                lblPlayer0.Text = "0";
                btnTic1.Enabled = true;
                btnTic2.Enabled = true;
                btnTic3.Enabled = true;
                btnTic4.Enabled = true;
                btnTic5.Enabled = true;
                btnTic6.Enabled = true;
                btnTic7.Enabled = true;
                btnTic8.Enabled = true;
                btnTic9.Enabled = true;

                btnTic1.Text = "";
                btnTic2.Text = "";
                btnTic3.Text = "";
                btnTic4.Text = "";
                btnTic5.Text = "";
                btnTic6.Text = "";
                btnTic7.Text = "";
                btnTic8.Text = "";
                btnTic9.Text = "";

                lblPlayerX.Text = "0";
                lblPlayer0.Text = "0";

                btnTic1.BackColor = Color.LimeGreen;
                btnTic2.BackColor = Color.LimeGreen;
                btnTic3.BackColor = Color.LimeGreen;
                btnTic4.BackColor = Color.LimeGreen;
                btnTic5.BackColor = Color.LimeGreen;
                btnTic6.BackColor = Color.LimeGreen;
                btnTic7.BackColor = Color.LimeGreen;
                btnTic8.BackColor = Color.LimeGreen;
                btnTic9.BackColor = Color.LimeGreen;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tac Toe", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        private void btn_info_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Author: Damian Skuras", "Tic Tac Toe");
                DialogResult = DialogResult.Cancel;
                if (iExit == DialogResult.OK)
                {
                    MessageBox.Show("Labolatorium: Programowanie gier komputerowych","Tic Tac Toe");
                    MessageBox.Show("https://www.youtube.com/watch?v=O2ia9AydiIM", "How to Create Advanced Tic Tac Toe Game in C#");
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tac Toe", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                Application.Exit();
            }
        }
        private void btn_color_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Black;
            lbl_Napis_Glowny.ForeColor = Color.Tomato;
            lbl_Napis_PlayerO.ForeColor = Color.Tomato;
            lbl_Napis_PlayerX.ForeColor = Color.Tomato;
            panel2.BackColor = Color.Black;
            panel3.BackColor = Color.Black;
            panel4.BackColor = Color.Black;
            panel5.BackColor = Color.Black;
        }
        //-------------------------------------------------------------------------------------------------------------------------------
        //Muzyka
        private void btn_play_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"B:\Churka One Drive\OneDrive\Pulpit\TicTacToe_PROJEKT_ZALICZENIOWY V.0.3\Music\d.wav");
            simpleSound.Play();
        }
        private void btn_pause_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
        }
        //-------------------------------------------------------------------------------------------------------------------------------
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            t.Stop();
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Confirm if you want to exit","Tic Tac Toe");
                DialogResult = DialogResult.Cancel;
                if(iExit == DialogResult.OK)
                {
                    MessageBox.Show("https://www.youtube.com/watch?v=O2ia9AydiIM", "How to Create Advanced Tic Tac Toe Game in C#");
                    Application.Exit();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tac Toe",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            soundPlayer.Stop();
        }
        //--------------------------------------------------------------------------------------------------------------------
    }
}
