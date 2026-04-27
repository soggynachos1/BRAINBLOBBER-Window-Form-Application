using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//GUI side of things srry they have the same name!!!!!!!
namespace BRAINBLOBBER_FINAL.Forms
{
    public partial class TriviaQuestions : UserControl
    {
        int currentQuestion = 0;

        List <Logic.TriviaQuestion> questions;
        List<RadioButton> answerRadio;

        public TriviaQuestions(List<Logic.TriviaQuestion> questions)
        {
            //initialize and list the item inside the radio button that was declared . . .
            InitializeComponent();
            answerRadio = [ radioButton1, radioButton2, radioButton3, radioButton4 ];
            this.questions = questions;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Choose choose = new Choose();
            choose.Dock = DockStyle.Fill;
            choose.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(choose);
            choose.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TriviaQuestions_Load(object sender, EventArgs e)
        {
            GetQuestionsAndAnswers(currentQuestion);

        }

        private void GetQuestionsAndAnswers(int question)
        {
            Question.Text = questions[question].question;
            radioButton1.Text = questions[question].answers[0];
            radioButton2.Text = questions[question].answers[1];
            radioButton3.Text = questions[question].answers[2];
            radioButton4.Text = questions[question].answers[3];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (answerRadio.ElementAt(questions[currentQuestion].correctAnswer).Checked)
            {
                currentQuestion++;
                GetQuestionsAndAnswers(currentQuestion);
            }
            // if true 
            // update current question question++
            // trivia question get current question and answers
        }
    }
}
