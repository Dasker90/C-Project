namespace Loop_DASKER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ForLoop_Click(object sender, EventArgs e)
        {
            int q = Convert.ToInt32(txt_ForLoop.Text);

            for(int i = 1; i < 101; i++)
            {
                lst_ForLoop.Items.Add(i + " x " + q + " = " + i * q);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            lst_ForLoop.Items.Clear();
            txt_ForLoop.Text = null;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dowidzenia","V.0.1",MessageBoxButtons.OK);
            Application.Exit();
        }
    }
}