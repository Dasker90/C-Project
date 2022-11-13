namespace Gauge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            aGauge1.Value = trackBar1.Value = 0;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            aGauge1.Value = trackBar1.Value;

            if(aGauge1.Value == 399)
            {
                MessageBox.Show("Max");
            }
            // Value track bar
            if (trackBar1.Value == 1)
            {
                aGauge1.Value = 50;
                label1.Text = "50";
                label1.BackColor = Color.Transparent;
            }
            if (trackBar1.Value == 2)
            {
                aGauge1.Value = 100;
                label1.Text = "100";
                label1.BackColor = Color.Cyan;
            }
            if (trackBar1.Value == 3)
            {
                aGauge1.Value = 150;
                label1.Text = "150";
                label1.BackColor = Color.DarkCyan;
            }
            if (trackBar1.Value == 4)
            {
                aGauge1.Value = 200;
                label1.Text = "200";
                label1.BackColor = Color.SpringGreen;
            }
            if (trackBar1.Value == 5)
            {
                aGauge1.Value = 250;
                label1.Text = "250";
                label1.BackColor = Color.LimeGreen;
            }
            if (trackBar1.Value == 6)
            {
                aGauge1.Value = 300;
                label1.Text = "300";
                label1.BackColor = Color.Yellow;
            }
            if (trackBar1.Value == 7)
            {
                aGauge1.Value = 350;
                label1.Text = "350";
                label1.BackColor = Color.Gold;
            }
            if (trackBar1.Value == 8)
            {
                aGauge1.Value = 400;
                label1.Text = "400";
                label1.BackColor = Color.Pink;
            }
            if (trackBar1.Value == 9)
            {
                aGauge1.Value = 450;
                label1.Text = "450";
                label1.BackColor = Color.Crimson;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aGauge1.Value = 0;
            label1.Text = "0";
            label1.BackColor = Color.Transparent;
        }
    }
}