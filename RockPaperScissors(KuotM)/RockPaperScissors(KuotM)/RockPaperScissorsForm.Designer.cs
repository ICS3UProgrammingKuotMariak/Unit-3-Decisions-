namespace RockPaperScissors_KuotM_
{
    partial class RockPaperScissorsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picRock = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblStateOptions = new System.Windows.Forms.Label();
            this.lblStateCpuChoice = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblStateWinner = new System.Windows.Forms.Label();
            this.mnuRockPaperScissors = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.mnuRockPaperScissors.SuspendLayout();
            this.SuspendLayout();
            // 
            // picRock
            // 
            this.picRock.Image = global::RockPaperScissors_KuotM_.Properties.Resources.rock;
            this.picRock.Location = new System.Drawing.Point(12, 91);
            this.picRock.Name = "picRock";
            this.picRock.Size = new System.Drawing.Size(180, 154);
            this.picRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRock.TabIndex = 0;
            this.picRock.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RockPaperScissors_KuotM_.Properties.Resources.paper;
            this.pictureBox2.Location = new System.Drawing.Point(219, 91);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(178, 154);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RockPaperScissors_KuotM_.Properties.Resources.scissors;
            this.pictureBox3.Location = new System.Drawing.Point(415, 91);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(178, 154);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // lblStateOptions
            // 
            this.lblStateOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateOptions.Location = new System.Drawing.Point(12, 52);
            this.lblStateOptions.Name = "lblStateOptions";
            this.lblStateOptions.Size = new System.Drawing.Size(133, 36);
            this.lblStateOptions.TabIndex = 3;
            this.lblStateOptions.Text = "Your choice:";
            // 
            // lblStateCpuChoice
            // 
            this.lblStateCpuChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateCpuChoice.Location = new System.Drawing.Point(12, 259);
            this.lblStateCpuChoice.Name = "lblStateCpuChoice";
            this.lblStateCpuChoice.Size = new System.Drawing.Size(195, 38);
            this.lblStateCpuChoice.TabIndex = 4;
            this.lblStateCpuChoice.Text = "Computer\'s choice:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::RockPaperScissors_KuotM_.Properties.Resources.scissors;
            this.pictureBox4.Location = new System.Drawing.Point(415, 300);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(178, 164);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::RockPaperScissors_KuotM_.Properties.Resources.paper;
            this.pictureBox5.Location = new System.Drawing.Point(219, 300);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(178, 164);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::RockPaperScissors_KuotM_.Properties.Resources.rock;
            this.pictureBox6.Location = new System.Drawing.Point(12, 300);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(180, 164);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // lblStateWinner
            // 
            this.lblStateWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateWinner.Location = new System.Drawing.Point(172, 488);
            this.lblStateWinner.Name = "lblStateWinner";
            this.lblStateWinner.Size = new System.Drawing.Size(240, 42);
            this.lblStateWinner.TabIndex = 8;
            this.lblStateWinner.Text = "Who Wins!";
            this.lblStateWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mnuRockPaperScissors
            // 
            this.mnuRockPaperScissors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuRockPaperScissors.Location = new System.Drawing.Point(0, 0);
            this.mnuRockPaperScissors.Name = "mnuRockPaperScissors";
            this.mnuRockPaperScissors.Size = new System.Drawing.Size(605, 24);
            this.mnuRockPaperScissors.TabIndex = 9;
            this.mnuRockPaperScissors.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            // 
            // RockPaperScissorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 550);
            this.Controls.Add(this.lblStateWinner);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.lblStateCpuChoice);
            this.Controls.Add(this.lblStateOptions);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picRock);
            this.Controls.Add(this.mnuRockPaperScissors);
            this.MainMenuStrip = this.mnuRockPaperScissors;
            this.Name = "RockPaperScissorsForm";
            this.Text = "Rock Paper Scissors!";
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.mnuRockPaperScissors.ResumeLayout(false);
            this.mnuRockPaperScissors.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picRock;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblStateOptions;
        private System.Windows.Forms.Label lblStateCpuChoice;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblStateWinner;
        private System.Windows.Forms.MenuStrip mnuRockPaperScissors;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
    }
}

