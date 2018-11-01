using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialForLoop
{
    public partial class frmFactorialFor : Form
    {
        public frmFactorialFor()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // This declares the local variables
            double factorialAnswer;
            double factorialNumber;
            int factorialCounter;

            // This clears the list box
            lstFactorialNumbers.Items.Clear();

            // Initializes final answer to 1
            factorialAnswer = 1;

            // Converts the number from the text box into an int
            factorialNumber = Convert.ToDouble(txtUserNum.Text);

            for (factorialCounter = 1; factorialCounter <= factorialNumber; factorialCounter++)
            {
                // This displays the counter number in the list box so the user can see
                this.lstFactorialNumbers.Items.Add(factorialCounter);

                // This multiplies the counter by the answer
                factorialAnswer = factorialAnswer * factorialCounter;

                // This shows the label
                lblFactorialAnswer.Show();

            }

            this.lblFactorialAnswer.Text = this.txtUserNum.Text + "! = " + Convert.ToString(factorialAnswer);
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFactorialFor_Load(object sender, EventArgs e)
        {
            lblFactorialAnswer.Hide();
        }
    }
}
