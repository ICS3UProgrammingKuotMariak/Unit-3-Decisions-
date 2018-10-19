/*
 * Created by: Kuot Mariak
 * Created on: 10-10-2016
 * Created for: ICS3U Programming
 * Daily Assignment – Day #16 - Number Guessing game
 * Number Guessing Game
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuessingGame_KuotM_
{
    public partial class NumberGuessingForm : Form
    {
        public NumberGuessingForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // This declares variables
            const int answer = 3;
            int guessnumber;

            // This converts the NUD into value
            guessnumber = (int)(nudGuess.Value);


            // This sets the min and max value
            nudGuess.Minimum = 1;
            nudGuess.Maximum = 10;

            if (guessnumber == answer)
            {
                System.IO.Stream right = Properties.Resources.Correct_Answer_Sound_Effect;
                System.Media.SoundPlayer correct = new System.Media.SoundPlayer(right);
                correct.Play();
                picGuessAnswer.Image = Properties.Resources.checkmark;
                lblGuessAnswer.Text = Convert.ToString("You guessed right!");
                
            }
            else
            {
                System.IO.Stream wrong = Properties.Resources.Wrong_Buzzer_Sound_Effect;
                System.Media.SoundPlayer incorrect = new System.Media.SoundPlayer(wrong);
                incorrect.Play();
                picGuessAnswer.Image = Properties.Resources.red_x;
                lblGuessAnswer.Text = Convert.ToString("You guessed wrong!");

            }

            // This shows the label and picture box
            lblGuessAnswer.Show();
            picGuessAnswer.Show();
            

        }

        private void NumberGuessingForm_Load(object sender, EventArgs e)
        {
            lblGuessAnswer.Hide();
            picGuessAnswer.Hide();
            

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
