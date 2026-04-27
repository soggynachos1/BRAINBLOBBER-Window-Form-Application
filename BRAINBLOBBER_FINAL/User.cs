using System;
using System.Collections.Generic;
using System.Text;
//This is the user logic and nteraction hoping to add multiplayer. . .
namespace BRAINBLOBBER_FINAL
{
    public class User
    {
        public int currentScore;
        public int numCorrect;


        //Constructor creaqted and getter and setters defined . . .
        public User(int score = 0, int correct = 0)
        {
            this.currentScore = score;
            this.numCorrect = correct;
        }

        public int GetCurrentScore()
        {
            return currentScore;
        }

        public void SetCurrentScore(int score)
        {

            currentScore = score;
        }

        public void AddToCurrentScore(int points)
        {
            currentScore += points;
        }

        public void AddCorrect()
        {
            AddToCurrentScore(10);
            numCorrect++;
        }



        public int GetNumOfCorrect()
        {
            return numCorrect;
        }

        public void SetNumOfCorrect(int correct)
        {
            numCorrect = correct;
        }
    }

}

