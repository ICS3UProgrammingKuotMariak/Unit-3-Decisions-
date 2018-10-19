namespace NumberGuessingGame_KuotM_
{
    partial class NumberGuessingForm
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
            this.lblGuess = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nudGuess = new System.Windows.Forms.NumericUpDown();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblGuessAnswer = new System.Windows.Forms.Label();
            this.picGuessAnswer = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuessAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGuess
            // 
            this.lblGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuess.Location = new System.Drawing.Point(12, 61);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(199, 61);
            this.lblGuess.TabIndex = 0;
            this.lblGuess.Text = "Guess a number between 1 and 10";
            this.lblGuess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(453, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // nudGuess
            // 
            this.nudGuess.Location = new System.Drawing.Point(295, 81);
            this.nudGuess.Name = "nudGuess";
            this.nudGuess.Size = new System.Drawing.Size(120, 20);
            this.nudGuess.TabIndex = 2;
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(295, 146);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(120, 61);
            this.btnGuess.TabIndex = 3;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblGuessAnswer
            // 
            this.lblGuessAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessAnswer.Location = new System.Drawing.Point(12, 146);
            this.lblGuessAnswer.Name = "lblGuessAnswer";
            this.lblGuessAnswer.Size = new System.Drawing.Size(209, 45);
            this.lblGuessAnswer.TabIndex = 4;
            this.lblGuessAnswer.Text = "You guessed ";
            this.lblGuessAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picGuessAnswer
            // 
            this.picGuessAnswer.Location = new System.Drawing.Point(48, 205);
            this.picGuessAnswer.Name = "picGuessAnswer";
            this.picGuessAnswer.Size = new System.Drawing.Size(133, 79);
            this.picGuessAnswer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGuessAnswer.TabIndex = 5;
            this.picGuessAnswer.TabStop = false;
            // 
            // NumberGuessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 296);
            this.Controls.Add(this.picGuessAnswer);
            this.Controls.Add(this.lblGuessAnswer);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.nudGuess);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NumberGuessingForm";
            this.Text = "Number Guessing Game";
            this.Load += new System.EventHandler(this.NumberGuessingForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuessAnswer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown nudGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblGuessAnswer;
        private System.Windows.Forms.PictureBox picGuessAnswer;
    }
}

