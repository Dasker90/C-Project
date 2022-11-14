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
    public partial class A1 : Form
    {
        public A1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CAR MEMORY GAME","Damian Skuras A.H.E Informatyka III rok");
        }

        private void btn_start_Click_1(object sender, EventArgs e)
        {
            string message = "Do you want to play?";
            string title = "Choose";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                A2 a2 = new A2();
                a2.Show();
                this.Hide();
            }
            else if (result == DialogResult.No)
            {
                this.Hide();
            }
        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_about_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Damian Skuras A.H.E Informatyka III rok  Projekt: Programowanie gier komputerowych", "CAR MEMORY GAME");
        }
    }
}
