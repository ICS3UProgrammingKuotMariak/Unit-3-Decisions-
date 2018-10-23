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
    public partial class RockPaperScissorsForm : Form
    {
        public RockPaperScissorsForm()
        {
            InitializeComponent();
        }

        private void picRock_Click(object sender, EventArgs e)
        {
            // This hides the other options
            this.picUserPaper.Hide();
            this.picUserScissors.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // This hides the other options
            this.picUserRock.Hide();
            this.picUserScissors.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // This hides the other options
            this.picUserRock.Hide();
            this.picUserPaper.Hide();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RockPaperScissorsForm_Load(object sender, EventArgs e)
        {
            // This declares global variables and constants
            const int ROCK = 1;
            const int PAPER = 2;
            const int SCISSORS = 3;
            int playerchoice, computerchoice;

            // This hides the label
            this.lblStateWinner.Hide();

        }
    }
}
