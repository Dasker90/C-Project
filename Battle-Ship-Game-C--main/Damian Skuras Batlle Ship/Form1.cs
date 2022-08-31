using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace Battle_Ship_Game_Windows_Form_MOO_ICT
{
    public partial class Form1 : Form
    {


        List<Button> playerPositionButtons;
        List<Button> enemyPositionButtons;

        Random rand = new Random();

        int totalShips = 3;
        int round = 10;
        int playerScore;
        int enemyScore;




        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void EnemyPlayTimerEvent(object sender, EventArgs e)
        {

            if (playerPositionButtons.Count > 0 && round > 0)
            {
                round -= 1;

                txtRounds.Text = "Round: " + round;

                int index = rand.Next(playerPositionButtons.Count);

                if ((string)playerPositionButtons[index].Tag == "playerShip")
                {
                    playerPositionButtons[index].BackgroundImage = Properties.Resources.fireIcon;
                    enemyMove.Text = playerPositionButtons[index].Text;
                    playerPositionButtons[index].Enabled = false;
                    playerPositionButtons[index].BackColor = Color.DarkBlue;
                    playerPositionButtons.RemoveAt(index);
                    enemyScore += 1;
                    txtEnemy.Text = enemyScore.ToString();
                    EnemyPlayTimer.Stop();
                }
                else
                {
                    playerPositionButtons[index].BackgroundImage = Properties.Resources.missIcon;
                    enemyMove.Text = playerPositionButtons[index].Text;
                    playerPositionButtons[index].Enabled = false;
                    playerPositionButtons[index].BackColor = Color.DarkBlue;
                    playerPositionButtons.RemoveAt(index);
                    EnemyPlayTimer.Stop();
                }
            }

            if (round < 1 || enemyScore > 2 || playerScore > 2)
            {

                if (playerScore > enemyScore)
                {
                    MessageBox.Show("Wygrałeś !!", "Wygrana");
                    RestartGame();
                }
                else if (enemyScore > playerScore)
                {
                    MessageBox.Show("Niestety przegrałeś :( ", "Przegrana");
                    RestartGame();
                }
                else if (enemyScore == playerScore)
                {
                    MessageBox.Show("REMIS !", "Draw");
                    RestartGame();
                }
            }



        }

        private void AttackButtonEvent(object sender, EventArgs e)
        {
            if (EnemyLocationListBox.Text != "")
            {

                var attackPosition = EnemyLocationListBox.Text.ToLower();

                int index = enemyPositionButtons.FindIndex(a => a.Name == attackPosition);

                if (enemyPositionButtons[index].Enabled && round > 0)
                {
                    round -= 1;
                    txtRounds.Text = "Round: " + round;


                    if ((string)enemyPositionButtons[index].Tag == "enemyShip")
                    {

                        enemyPositionButtons[index].Enabled = false;
                        enemyPositionButtons[index].BackgroundImage = Properties.Resources.fireIcon;
                        enemyPositionButtons[index].BackColor = Color.DarkBlue;
                        playerScore += 1;
                        txtPlayer.Text = playerScore.ToString();
                        EnemyPlayTimer.Start();

                    }
                    else
                    {
                        enemyPositionButtons[index].Enabled = false;
                        enemyPositionButtons[index].BackgroundImage = Properties.Resources.missIcon;
                        enemyPositionButtons[index].BackColor = Color.DarkBlue;
                        EnemyPlayTimer.Start();
                    }


                }


            }
            else
            {
                MessageBox.Show("Wybierz loaklizacje", "Informacja");
            }
        }

        private void PlayerPositionButtonsEvent(object sender, EventArgs e)
        {

            if (totalShips > 0)
            {
                var button = (Button)sender;

                button.Enabled = false;
                button.Tag = "playerShip";
                button.BackColor = Color.Turquoise;
                totalShips -= 1;
            }

            if (totalShips == 0)
            {
                btnAttack.Enabled = true;
                btnAttack.BackColor = Color.Red;
                btnAttack.ForeColor = Color.White;

                txtHelp.Text = "2) U góry masz panel, wybierz pozycję !";
            }


        }


        private void RestartGame()
        {

            playerPositionButtons = new List<Button> {w1, w2, w3, w4, x1, x2,x3, x4, y1, y2, y3, y4, z1, z2, z3, z4 };
            enemyPositionButtons = new List<Button> {a1, a2, a3, a4, b1, b2, b3, b4, c1, c2, c3, c4, d1, d2, d3, d4 };

            EnemyLocationListBox.Items.Clear();

            EnemyLocationListBox.Text = null;

            txtHelp.Text = "1) Wybierz 3 rózne lokalziacje !";


            for (int i = 0; i < enemyPositionButtons.Count; i++)
            {
                enemyPositionButtons[i].Enabled = true;
                enemyPositionButtons[i].Tag = null;
                enemyPositionButtons[i].BackColor = Color.OrangeRed;
                enemyPositionButtons[i].BackgroundImage = null;
                EnemyLocationListBox.Items.Add(enemyPositionButtons[i].Text);
            }

            for (int i = 0; i < playerPositionButtons.Count; i++)
            {
                playerPositionButtons[i].Enabled = true;
                playerPositionButtons[i].Tag = null;
                playerPositionButtons[i].BackColor = Color.White;
                playerPositionButtons[i].BackgroundImage = null;
            }

            playerScore = 0;
            enemyScore = 0;
            round = 10;
            totalShips = 3;

            txtPlayer.Text = playerScore.ToString();
            txtEnemy.Text = enemyScore.ToString();
            enemyMove.Text = "A1";

            btnAttack.Enabled = false;

            enemyLocationPicker();


        }

        private void enemyLocationPicker()
        {

            for (int i = 0; i < 3; i++)
            {
                int index = rand.Next(enemyPositionButtons.Count);

                if (enemyPositionButtons[index].Enabled == true && (string)enemyPositionButtons[index].Tag == null)
                {
                    enemyPositionButtons[index].Tag = "enemyShip";

                    Debug.WriteLine("Enemy Position: " + enemyPositionButtons[index].Text);
                }
                else
                {
                    index = rand.Next(enemyPositionButtons.Count);
                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void playerpanel_Click(object sender, EventArgs e)
        {

        }

        private void txtHelp_Click(object sender, EventArgs e)
        {

        }

        private void a4_Click(object sender, EventArgs e)
        {

        }

        private void d3_Click(object sender, EventArgs e)
        {

        }

        private void c4_Click(object sender, EventArgs e)
        {

        }

        private void c3_Click(object sender, EventArgs e)
        {

        }

        private void b4_Click(object sender, EventArgs e)
        {

        }

        private void d2_Click(object sender, EventArgs e)
        {

        }

        private void b3_Click(object sender, EventArgs e)
        {

        }

        private void c2_Click(object sender, EventArgs e)
        {

        }

        private void d4_Click(object sender, EventArgs e)
        {

        }

        private void d1_Click(object sender, EventArgs e)
        {

        }

        private void b2_Click(object sender, EventArgs e)
        {

        }

        private void c1_Click(object sender, EventArgs e)
        {

        }

        private void a3_Click(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {

        }

        private void a2_Click(object sender, EventArgs e)
        {

        }

        private void a1_Click(object sender, EventArgs e)
        {

        }

        private void infor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Damian Skuraś | Informatyka III rok | VI Semestr ", "Wersja 0.1");
        }
    }
}
