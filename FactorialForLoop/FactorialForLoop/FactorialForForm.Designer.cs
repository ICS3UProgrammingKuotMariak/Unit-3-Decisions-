namespace FactorialForLoop
{
    partial class frmFactorialFor
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
            this.lblEnterNum = new System.Windows.Forms.Label();
            this.mnuFactorialFor = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUserNum = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lstFactorialNumbers = new System.Windows.Forms.ListBox();
            this.lblFactorialAnswer = new System.Windows.Forms.Label();
            this.mnuFactorialFor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEnterNum
            // 
            this.lblEnterNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterNum.Location = new System.Drawing.Point(12, 62);
            this.lblEnterNum.Name = "lblEnterNum";
            this.lblEnterNum.Size = new System.Drawing.Size(149, 30);
            this.lblEnterNum.TabIndex = 0;
            this.lblEnterNum.Text = "Enter a number:";
            // 
            // mnuFactorialFor
            // 
            this.mnuFactorialFor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuFactorialFor.Location = new System.Drawing.Point(0, 0);
            this.mnuFactorialFor.Name = "mnuFactorialFor";
            this.mnuFactorialFor.Size = new System.Drawing.Size(397, 24);
            this.mnuFactorialFor.TabIndex = 1;
            this.mnuFactorialFor.Text = "menuStrip1";
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
            // txtUserNum
            // 
            this.txtUserNum.Location = new System.Drawing.Point(204, 67);
            this.txtUserNum.Name = "txtUserNum";
            this.txtUserNum.Size = new System.Drawing.Size(167, 20);
            this.txtUserNum.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(16, 112);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(99, 57);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lstFactorialNumbers
            // 
            this.lstFactorialNumbers.FormattingEnabled = true;
            this.lstFactorialNumbers.Location = new System.Drawing.Point(132, 112);
            this.lstFactorialNumbers.Name = "lstFactorialNumbers";
            this.lstFactorialNumbers.Size = new System.Drawing.Size(239, 173);
            this.lstFactorialNumbers.TabIndex = 4;
            // 
            // lblFactorialAnswer
            // 
            this.lblFactorialAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactorialAnswer.Location = new System.Drawing.Point(12, 304);
            this.lblFactorialAnswer.Name = "lblFactorialAnswer";
            this.lblFactorialAnswer.Size = new System.Drawing.Size(359, 30);
            this.lblFactorialAnswer.TabIndex = 5;
            this.lblFactorialAnswer.Text = "Factorial Answer";
            // 
            // frmFactorialFor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 343);
            this.Controls.Add(this.lblFactorialAnswer);
            this.Controls.Add(this.lstFactorialNumbers);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtUserNum);
            this.Controls.Add(this.lblEnterNum);
            this.Controls.Add(this.mnuFactorialFor);
            this.MainMenuStrip = this.mnuFactorialFor;
            this.Name = "frmFactorialFor";
            this.Text = "Factorial For Loop";
            this.Load += new System.EventHandler(this.frmFactorialFor_Load);
            this.mnuFactorialFor.ResumeLayout(false);
            this.mnuFactorialFor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterNum;
        private System.Windows.Forms.MenuStrip mnuFactorialFor;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.TextBox txtUserNum;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstFactorialNumbers;
        private System.Windows.Forms.Label lblFactorialAnswer;
    }
}

