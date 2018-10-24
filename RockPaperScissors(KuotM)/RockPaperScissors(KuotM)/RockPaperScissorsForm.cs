using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors_KuotM_
{
    public partial class frmRockPaperScissors : Form
    {
        // This declares global variables and constants
        const int ROCK = 1;
        const int PAPER = 2;
        const int SCISSORS = 3;
        const int MIN_VAL = 1;
        const int MAX_VAL = 3;
        int playerchoice, computerchoice;

        public frmRockPaperScissors()
        {
            InitializeComponent();
            Random randomNumberGenerator;
            randomNumberGenerator = new Random();

            // This assigns a random number between 1 and 3 to the computer's choice
            computerchoice = randomNumberGenerator.Next(MIN_VAL, MAX_VAL + 1);

        }

        private void picRock_Click(object sender, EventArgs e)
        {
            // This hides the other options
            this.picUserPaper.Hide();
            this.picUserScissors.Hide();
            playerchoice = ROCK;
            if (computerchoice == ROCK)
            {
                picCPUPaper.Hide();
                picCPUScissors.Hide();
                lblStateWinner.Show();
                lblStateWinner.Text = "It's a draw!";
            }
            else if (computerchoice == PAPER)
            {
                picCPURock.Hide();
                picCPUScissors.Hide();
                lblStateWinner.Show();
                lblStateWinner.Text = "You Lose!";
            }
            else
            {
                picCPUPaper.Hide();
                picCPURock.Hide();
                lblStateWinner.Show();
                lblStateWinner.Text = "You win!";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // This hides the other options
            this.picUserRock.Hide();
            this.picUserScissors.Hide();
            playerchoice = PAPER;
            if (computerchoice == PAPER)
            {
                picCPURock.Hide();
                picCPUScissors.Hide();
                lblStateWinner.Show();
                lblStateWinner.Text = "It's a draw!";
            }
            else if (computerchoice == SCISSORS)
            {
                picCPURock.Hide();
                picCPUPaper.Hide();
                lblStateWinner.Show();
                lblStateWinner.Text = "You Lose!";
            }
            else
            {
                picCPUPaper.Hide();
                picCPUScissors.Hide();
                lblStateWinner.Show();
                lblStateWinner.Text = "You win!";
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // This hides the other options
            this.picUserRock.Hide();
            this.picUserPaper.Hide();
            playerchoice = SCISSORS;
            if (computerchoice == SCISSORS)
            {
                picCPURock.Hide();
                picCPUPaper.Hide();
                lblStateWinner.Show();
                lblStateWinner.Text = "It's a draw!";
            }
            else if (computerchoice == ROCK)
            {
                picCPUPaper.Hide();
                picCPUScissors.Hide();
                lblStateWinner.Show();
                lblStateWinner.Text = "You Lose!";
            }
            else
            {
                picCPUScissors.Hide();
                picCPURock.Hide();
                lblStateWinner.Show();
                lblStateWinner.Text = "You win!";
            }

        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // This shows
            picUserRock.Show();
            picUserPaper.Show();
            picUserScissors.Show();
            picCPURock.Show();
            picCPUPaper.Show();
            picCPUScissors.Show();

            // This hides
            lblStateWinner.Hide();
            this.Refresh();

            Random randomNumberGenerator;
            randomNumberGenerator = new Random();

            // This assigns a random number between 1 and 3 to the computer's choice
            computerchoice = randomNumberGenerator.Next(MIN_VAL, MAX_VAL + 1);



        }

        private void RockPaperScissorsForm_Load(object sender, EventArgs e)
        {
            // This hides the label
            this.lblStateWinner.Hide();

        }
    }
}
