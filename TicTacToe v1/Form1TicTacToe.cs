using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        Boolean checker;
        int plusone;
        public Form1()
        {
            InitializeComponent();
            lblPlayerX.Text = "0";
            lblPlayer0.Text = "0";
           
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
            
            //--------------------------------------------------------------------------------------------------------------------
            // Player 0
            // ---     
            //--------------------------------------------------------------------------------------------------------------------
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //--------------------------------------------------------------------------------------------------------------------
        // Przyciski
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

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tac Toe", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

       
        //--------------------------------------------------------------------------------------------------------------------
    }
}
// - v.0.1
