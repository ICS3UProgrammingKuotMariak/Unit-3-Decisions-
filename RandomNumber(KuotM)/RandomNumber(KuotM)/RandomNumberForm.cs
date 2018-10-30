/*
 * Created by: Kuot Mariak
 * Created on: 11-10-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #17 - Random Number
 * Random Number
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

namespace RandomNumber_KuotM_
{
    public partial class RandomNumberForm : Form
    {
        // This declares the variables
        int userChoice;
        int correctAnswer;


        public RandomNumberForm()
        {
            InitializeComponent();
            // Declares the constants and variables
            const int Min_Value = 1;
            const int Max_Value = 10;

            // This generates a random number
            Random randomNumberGenerator = new Random();
            correctAnswer = randomNumberGenerator.Next(Min_Value, Max_Value + 1);
            
            
        }

        private void RandomNumberForm_Load(object sender, EventArgs e)
        {
            lblStateAnswer.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            
            // This converts the NUD into an int
            userChoice = (int)(nudGuess.Value);

            // This sets the min and max values
            nudGuess.Minimum = 1;
            nudGuess.Maximum = 10;


            if (userChoice == correctAnswer)
            {
                lblStateAnswer.Show();
                lblStateAnswer.Text = Convert.ToString("You win!");
            }
            else
            {
                lblStateAnswer.Show();
                lblStateAnswer.Text = Convert.ToString("You lose");
            }

            
           

           
        }

        private void mniRandomize_Click(object sender, EventArgs e)
        {
            // Declares the constants and variables
            const int Min_Value = 1;
            const int Max_Value = 10;

            // This generates a random number
            Random randomNumberGenerator = new Random();
            correctAnswer = randomNumberGenerator.Next(Min_Value, Max_Value + 1);

            this.Refresh();
        }
    }
}
