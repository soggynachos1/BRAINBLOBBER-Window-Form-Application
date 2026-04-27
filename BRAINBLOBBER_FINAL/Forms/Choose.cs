namespace BRAINBLOBBER_FINAL.Forms
{
    public partial class Choose : Form
    {
        public Choose()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            start.Dock = DockStyle.Fill;
            start.TopLevel = false;

            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(start);
            start.Show();

        }



        public void button1_Click_1(object sender, EventArgs e)
        {
            TriviaQuestions VgQuestions = new TriviaQuestions(Logic.TriviaQuestions.videoGames);
            VgQuestions.Dock = DockStyle.Fill;


            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(VgQuestions);
            VgQuestions.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TriviaQuestions PopQuestions = new TriviaQuestions(Logic.TriviaQuestions.popCulture);
            PopQuestions.Dock = DockStyle.Fill;


            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(PopQuestions);
            PopQuestions.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TriviaQuestions MusicQuestions = new TriviaQuestions(Logic.TriviaQuestions.music);
            MusicQuestions.Dock = DockStyle.Fill;


            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(MusicQuestions);
            MusicQuestions.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TriviaQuestions MovieQuestions = new TriviaQuestions(Logic.TriviaQuestions.movies);
            MovieQuestions.Dock = DockStyle.Fill;


            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(MovieQuestions);
            MovieQuestions.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TriviaQuestions TvQuestions = new TriviaQuestions(Logic.TriviaQuestions.tvshows);
            TvQuestions.Dock = DockStyle.Fill;


            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(TvQuestions);
            TvQuestions.Show();

        }
    }
}
