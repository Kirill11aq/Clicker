namespace Clicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int clickCount = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Clicks: " + clickCount;
            timer1.Start();

                
                pictureBox1.Image = Properties.Resources.gold;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Clicks: " + clickCount;
            clickCount += 1;
            if (clickCount > 0)
            {
                pictureBox1.Image = Properties.Resources.dollar;
                timer1.Stop();
            }
        }
    }
}