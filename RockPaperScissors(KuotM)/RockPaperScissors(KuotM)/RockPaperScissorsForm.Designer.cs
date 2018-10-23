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
            this.picUserRock = new System.Windows.Forms.PictureBox();
            this.picUserPaper = new System.Windows.Forms.PictureBox();
            this.picUserScissors = new System.Windows.Forms.PictureBox();
            this.lblStateOptions = new System.Windows.Forms.Label();
            this.lblStateCpuChoice = new System.Windows.Forms.Label();
            this.picCPUScissors = new System.Windows.Forms.PictureBox();
            this.picCPUPaper = new System.Windows.Forms.PictureBox();
            this.picCPURock = new System.Windows.Forms.PictureBox();
            this.lblStateWinner = new System.Windows.Forms.Label();
            this.mnuRockPaperScissors = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picUserRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPUScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPUPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPURock)).BeginInit();
            this.mnuRockPaperScissors.SuspendLayout();
            this.SuspendLayout();
            // 
            // picUserRock
            // 
            this.picUserRock.Image = global::RockPaperScissors_KuotM_.Properties.Resources.rock;
            this.picUserRock.Location = new System.Drawing.Point(12, 91);
            this.picUserRock.Name = "picUserRock";
            this.picUserRock.Size = new System.Drawing.Size(180, 154);
            this.picUserRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUserRock.TabIndex = 0;
            this.picUserRock.TabStop = false;
            this.picUserRock.Click += new System.EventHandler(this.picRock_Click);
            // 
            // picUserPaper
            // 
            this.picUserPaper.Image = global::RockPaperScissors_KuotM_.Properties.Resources.paper;
            this.picUserPaper.Location = new System.Drawing.Point(219, 91);
            this.picUserPaper.Name = "picUserPaper";
            this.picUserPaper.Size = new System.Drawing.Size(178, 154);
            this.picUserPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUserPaper.TabIndex = 1;
            this.picUserPaper.TabStop = false;
            this.picUserPaper.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // picUserScissors
            // 
            this.picUserScissors.Image = global::RockPaperScissors_KuotM_.Properties.Resources.scissors;
            this.picUserScissors.Location = new System.Drawing.Point(415, 91);
            this.picUserScissors.Name = "picUserScissors";
            this.picUserScissors.Size = new System.Drawing.Size(178, 154);
            this.picUserScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUserScissors.TabIndex = 2;
            this.picUserScissors.TabStop = false;
            this.picUserScissors.Click += new System.EventHandler(this.pictureBox3_Click);
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
            // picCPUScissors
            // 
            this.picCPUScissors.Image = global::RockPaperScissors_KuotM_.Properties.Resources.scissors;
            this.picCPUScissors.Location = new System.Drawing.Point(415, 300);
            this.picCPUScissors.Name = "picCPUScissors";
            this.picCPUScissors.Size = new System.Drawing.Size(178, 164);
            this.picCPUScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCPUScissors.TabIndex = 7;
            this.picCPUScissors.TabStop = false;
            // 
            // picCPUPaper
            // 
            this.picCPUPaper.Image = global::RockPaperScissors_KuotM_.Properties.Resources.paper;
            this.picCPUPaper.Location = new System.Drawing.Point(219, 300);
            this.picCPUPaper.Name = "picCPUPaper";
            this.picCPUPaper.Size = new System.Drawing.Size(178, 164);
            this.picCPUPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCPUPaper.TabIndex = 6;
            this.picCPUPaper.TabStop = false;
            // 
            // picCPURock
            // 
            this.picCPURock.Image = global::RockPaperScissors_KuotM_.Properties.Resources.rock;
            this.picCPURock.Location = new System.Drawing.Point(12, 300);
            this.picCPURock.Name = "picCPURock";
            this.picCPURock.Size = new System.Drawing.Size(180, 164);
            this.picCPURock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCPURock.TabIndex = 5;
            this.picCPURock.TabStop = false;
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
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(518, 37);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Play Again!";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // RockPaperScissorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 550);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblStateWinner);
            this.Controls.Add(this.picCPUScissors);
            this.Controls.Add(this.picCPUPaper);
            this.Controls.Add(this.picCPURock);
            this.Controls.Add(this.lblStateCpuChoice);
            this.Controls.Add(this.lblStateOptions);
            this.Controls.Add(this.picUserScissors);
            this.Controls.Add(this.picUserPaper);
            this.Controls.Add(this.picUserRock);
            this.Controls.Add(this.mnuRockPaperScissors);
            this.MainMenuStrip = this.mnuRockPaperScissors;
            this.Name = "RockPaperScissorsForm";
            this.Text = "Rock Paper Scissors!";
            this.Load += new System.EventHandler(this.RockPaperScissorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUserRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPUScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPUPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPURock)).EndInit();
            this.mnuRockPaperScissors.ResumeLayout(false);
            this.mnuRockPaperScissors.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picUserRock;
        private System.Windows.Forms.PictureBox picUserPaper;
        private System.Windows.Forms.PictureBox picUserScissors;
        private System.Windows.Forms.Label lblStateOptions;
        private System.Windows.Forms.Label lblStateCpuChoice;
        private System.Windows.Forms.PictureBox picCPUScissors;
        private System.Windows.Forms.PictureBox picCPUPaper;
        private System.Windows.Forms.PictureBox picCPURock;
        private System.Windows.Forms.Label lblStateWinner;
        private System.Windows.Forms.MenuStrip mnuRockPaperScissors;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Button btnReset;
    }
}

