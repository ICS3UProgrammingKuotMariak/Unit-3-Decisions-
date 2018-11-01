/*
 * Created by: Kuot Mariak
 * Created on: 23-10-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #21 - Walking Man
 * Walking Man
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
using System.Threading;

namespace WalkingMan_KuotM_
{
    public partial class frmWalkingMan : Form
    {
        public frmWalkingMan()
        {
            InitializeComponent();
        }

        private void frmWalkingMan_Load(object sender, EventArgs e)
        {

        }

        private void btnWalk_Click(object sender, EventArgs e)
        {
            // This declares the local variables and constants
            const byte MAX_FRAMES = 10;
            int picFrameCounter = 1;

            // Use while loop to repeat loop until it has reached the max number of frames to display
            while (picFrameCounter < MAX_FRAMES + 1)
            {
                if (picFrameCounter == 1)
                {
                    this.picWalkingMan.Image = Properties.Resources.walk1;
                }
                else if (picFrameCounter == 2)
                {
                    this.picWalkingMan.Image = Properties.Resources.walk2;
                }
                else if (picFrameCounter == 3)
                {
                    this.picWalkingMan.Image = Properties.Resources.walk3;
                }
                else if (picFrameCounter == 4)
                {
                    this.picWalkingMan.Image = Properties.Resources.walk4;
                }
                else if (picFrameCounter == 5)
                {
                    this.picWalkingMan.Image = Properties.Resources.walk5;
                }
                else if (picFrameCounter == 6)
                {
                    this.picWalkingMan.Image = Properties.Resources.walk6;
                }
                else if (picFrameCounter == 7)
                {
                    this.picWalkingMan.Image = Properties.Resources.walk7;
                }
                else if (picFrameCounter == 8)
                {
                    this.picWalkingMan.Image = Properties.Resources.walk8;
                }
                else if (picFrameCounter == 9)
                {
                    this.picWalkingMan.Image = Properties.Resources.walk9;
                }
                else if (picFrameCounter == 10)
                {
                    this.picWalkingMan.Image = Properties.Resources.walk10;
                }

                // This increments the counter
                picFrameCounter++;

                // This refreshes the form
                this.Refresh();

                // This pauses the frames
                Thread.Sleep(100);

            }
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
