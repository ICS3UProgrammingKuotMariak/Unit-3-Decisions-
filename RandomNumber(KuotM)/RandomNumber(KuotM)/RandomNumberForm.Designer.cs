namespace RandomNumber_KuotM_
{
    partial class RandomNumberForm
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
            this.nudGuess = new System.Windows.Forms.NumericUpDown();
            this.lblGuessNumber = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblStateAnswer = new System.Windows.Forms.Label();
            this.mniOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mniRandomize = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuess)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudGuess
            // 
            this.nudGuess.Location = new System.Drawing.Point(255, 91);
            this.nudGuess.Name = "nudGuess";
            this.nudGuess.Size = new System.Drawing.Size(120, 20);
            this.nudGuess.TabIndex = 0;
            // 
            // lblGuessNumber
            // 
            this.lblGuessNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessNumber.Location = new System.Drawing.Point(12, 70);
            this.lblGuessNumber.Name = "lblGuessNumber";
            this.lblGuessNumber.Size = new System.Drawing.Size(219, 54);
            this.lblGuessNumber.TabIndex = 1;
            this.lblGuessNumber.Text = "Guess a number between 1 and 10";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mniOptions});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(410, 24);
            this.menuStrip1.TabIndex = 2;
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
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(116, 144);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(164, 59);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblStateAnswer
            // 
            this.lblStateAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateAnswer.Location = new System.Drawing.Point(65, 228);
            this.lblStateAnswer.Name = "lblStateAnswer";
            this.lblStateAnswer.Size = new System.Drawing.Size(249, 38);
            this.lblStateAnswer.TabIndex = 4;
            this.lblStateAnswer.Text = "Answer";
            this.lblStateAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mniOptions
            // 
            this.mniOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniRandomize});
            this.mniOptions.Name = "mniOptions";
            this.mniOptions.Size = new System.Drawing.Size(61, 20);
            this.mniOptions.Text = "Options";
            // 
            // mniRandomize
            // 
            this.mniRandomize.Name = "mniRandomize";
            this.mniRandomize.Size = new System.Drawing.Size(152, 22);
            this.mniRandomize.Text = "Randomize";
            this.mniRandomize.Click += new System.EventHandler(this.mniRandomize_Click);
            // 
            // RandomNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 301);
            this.Controls.Add(this.lblStateAnswer);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblGuessNumber);
            this.Controls.Add(this.nudGuess);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RandomNumberForm";
            this.Text = "Random Number";
            this.Load += new System.EventHandler(this.RandomNumberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudGuess)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudGuess;
        private System.Windows.Forms.Label lblGuessNumber;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblStateAnswer;
        private System.Windows.Forms.ToolStripMenuItem mniOptions;
        private System.Windows.Forms.ToolStripMenuItem mniRandomize;
    }
}

