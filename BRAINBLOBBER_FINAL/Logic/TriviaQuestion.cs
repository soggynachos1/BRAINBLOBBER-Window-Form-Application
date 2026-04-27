using System;
using System.Collections.Generic;
using System.Text;
//LOGIC!!!!!!
namespace BRAINBLOBBER_FINAL.Logic
{
    public class TriviaQuestion
    {
        public string question;
        public List<string> answers;
        public int correctAnswer;
       

        public TriviaQuestion(string question, List<string> answers, int correctAnswer)
        {
            this.question = question;
            this.answers = answers;
            this.correctAnswer = correctAnswer;

        }

        
    }
}
