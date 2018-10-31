/*
 * Created by: Kuot Mariak
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #19 - Chocolate Boxes
 * This program...
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

namespace ChocolateBoxes_KuotM_
{
    public partial class ChocolateBoxesForm : Form
    {
        public ChocolateBoxesForm()
        {
            InitializeComponent();
        }

        private void ChocolateBoxesForm_Load(object sender, EventArgs e)
        {
            lblPrize.Hide();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetPrize_Click(object sender, EventArgs e)
        {
            int NumSold = (int)(nudNumBoxesSold.Value);

            if (NumSold > 20)
            {
                lblPrize.Show();
                lblPrize.Text = Convert.ToString("You win a big prize");
            }
            else
            {
                if (NumSold > 10)
                {
                    lblPrize.Show();
                    lblPrize.Text = Convert.ToString("You win a small prize");
                }
                else
                {
                    lblPrize.Show();
                    lblPrize.Text = Convert.ToString("You get an honorable mention");
                }

            }



        }
    }
}
