namespace RunningAvg_KuotM_
{
    partial class frmRunningAvg
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
            this.mnuAvg = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblAverage = new System.Windows.Forms.Label();
            this.mnuAvg.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEnterNum
            // 
            this.lblEnterNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterNum.Location = new System.Drawing.Point(12, 33);
            this.lblEnterNum.Name = "lblEnterNum";
            this.lblEnterNum.Size = new System.Drawing.Size(228, 56);
            this.lblEnterNum.TabIndex = 0;
            this.lblEnterNum.Text = "Enter a number between 1 and 10:";
            this.lblEnterNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mnuAvg
            // 
            this.mnuAvg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuAvg.Location = new System.Drawing.Point(0, 0);
            this.mnuAvg.Name = "mnuAvg";
            this.mnuAvg.Size = new System.Drawing.Size(436, 24);
            this.mnuAvg.TabIndex = 1;
            this.mnuAvg.Text = "menuStrip1";
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
            this.mniExit.Size = new System.Drawing.Size(92, 22);
            this.mniExit.Text = "Exit";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(259, 54);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(152, 20);
            this.txtNum.TabIndex = 2;
            // 
            // lblExit
            // 
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(61, 89);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(131, 33);
            this.lblExit.TabIndex = 3;
            this.lblExit.Text = "(Enter -1 to exit)";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(27, 149);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(175, 71);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate Average";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.Location = new System.Drawing.Point(208, 167);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(228, 35);
            this.lblAverage.TabIndex = 5;
            this.lblAverage.Text = "Running Average:";
            this.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmRunningAvg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 234);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblEnterNum);
            this.Controls.Add(this.mnuAvg);
            this.MainMenuStrip = this.mnuAvg;
            this.Name = "frmRunningAvg";
            this.Text = "Running Average";
            this.mnuAvg.ResumeLayout(false);
            this.mnuAvg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterNum;
        private System.Windows.Forms.MenuStrip mnuAvg;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblAverage;
    }
}

