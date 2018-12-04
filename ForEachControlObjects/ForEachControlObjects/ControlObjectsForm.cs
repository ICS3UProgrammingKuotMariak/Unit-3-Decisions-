/*
 * Created by: Kuot Mariak
 * Created on: 2-11-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #27 - Control Objects
 * Control Objects
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

namespace ForEachControlObjects
{
    public partial class frmControlObjects : Form
    {
        Font Sans = new Font("Comic Sans MS", 20, FontStyle.Italic);
        Font Default = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);

        public frmControlObjects()
        {
            InitializeComponent();
        }

        private void lblChangeText_Click(object sender, EventArgs e)
        {
            foreach (Control FontControl in this.Controls)
            {
                FontControl.Font = Sans;
                if (FontControl.GetType() == typeof(ListBox))
                {
                    FontControl.Font = Sans;
                }
                else if (FontControl.GetType() == typeof(Button))
                {
                    FontControl.Font = Sans;
                }
 
            }
        }

        private void lstDefault_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This Foreach loop changes the colour and font of the all objects back to default
            foreach (Control DefaultControl in this.Controls)
            {
                DefaultControl.BackColor = SystemColors.Window;
                DefaultControl.ForeColor = SystemColors.WindowText;
                DefaultControl.Font = Default;

                if (DefaultControl.GetType() == typeof(Label))
                {
                    DefaultControl.BackColor = SystemColors.Control;
                    DefaultControl.ForeColor = SystemColors.ControlText;
                    DefaultControl.Font = Default;
                }
                else if (DefaultControl.GetType() == typeof(Button))
                {
                    DefaultControl.BackColor = SystemColors.Control;
                    DefaultControl.ForeColor = SystemColors.ControlText;
                    DefaultControl.Font = Default;
                }
                
            }
        }

        private void btnChangeColour_Click(object sender, EventArgs e)
        {
            // This Foreach loop changes the colour of the Label and Listbox when the 
            foreach (Control ColourControl in this.Controls)
            {
                ColourControl.BackColor = Color.Green;

                if (ColourControl.GetType() == typeof(Label))
                {
                    ColourControl.BackColor = Color.Purple;
                }
                else if (ColourControl.GetType() == typeof(ListBox))
                {
                    ColourControl.BackColor = Color.Orange;
                }
            }
        }
    }
}
