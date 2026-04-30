namespace Timer
{
    public partial class Timer : Form
    {
        int seconds = 0;

        public Timer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            lblScreen.Text = seconds--.ToString();
            if (seconds < 0)
            {
                CountdownTimer.Stop();
                lblScreen.Text = "Time's up!";
            }
        }

        private void Start_Click_1(object sender, EventArgs e)
        {
            seconds = 20;
            CountdownTimer.Start();

        }
    }
}
