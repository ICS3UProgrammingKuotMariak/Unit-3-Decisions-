/*
 * Created by: Kuot Mariak
 * Created on: 6-11-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #29 - Running Average
 * Running Avg
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

namespace RunningAvg_KuotM_
{
    public partial class frmRunningAvg : Form
    {
        public frmRunningAvg()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double mark = Convert.ToDouble(txtNum.Text);
            
            if (mark > 0)
            {

            }


        }
    }
}
