namespace ChocolateBoxes_KuotM_
{
    partial class ChocolateBoxesForm
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
            this.mnuChocolateBoxes = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.nudNumBoxesSold = new System.Windows.Forms.NumericUpDown();
            this.lblNumBoxes = new System.Windows.Forms.Label();
            this.btnGetPrize = new System.Windows.Forms.Button();
            this.lblPrize = new System.Windows.Forms.Label();
            this.mnuChocolateBoxes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumBoxesSold)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuChocolateBoxes
            // 
            this.mnuChocolateBoxes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuChocolateBoxes.Location = new System.Drawing.Point(0, 0);
            this.mnuChocolateBoxes.Name = "mnuChocolateBoxes";
            this.mnuChocolateBoxes.Size = new System.Drawing.Size(387, 24);
            this.mnuChocolateBoxes.TabIndex = 0;
            this.mnuChocolateBoxes.Text = "menuStrip1";
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
            this.mniExit.Size = new System.Drawing.Size(180, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // nudNumBoxesSold
            // 
            this.nudNumBoxesSold.Location = new System.Drawing.Point(233, 92);
            this.nudNumBoxesSold.Name = "nudNumBoxesSold";
            this.nudNumBoxesSold.Size = new System.Drawing.Size(120, 20);
            this.nudNumBoxesSold.TabIndex = 1;
            // 
            // lblNumBoxes
            // 
            this.lblNumBoxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumBoxes.Location = new System.Drawing.Point(28, 71);
            this.lblNumBoxes.Name = "lblNumBoxes";
            this.lblNumBoxes.Size = new System.Drawing.Size(166, 56);
            this.lblNumBoxes.TabIndex = 2;
            this.lblNumBoxes.Text = "How many boxes did you sell?";
            // 
            // btnGetPrize
            // 
            this.btnGetPrize.Location = new System.Drawing.Point(89, 152);
            this.btnGetPrize.Name = "btnGetPrize";
            this.btnGetPrize.Size = new System.Drawing.Size(185, 78);
            this.btnGetPrize.TabIndex = 3;
            this.btnGetPrize.Text = "Click to receive your Prize!";
            this.btnGetPrize.UseVisualStyleBackColor = true;
            this.btnGetPrize.Click += new System.EventHandler(this.btnGetPrize_Click);
            // 
            // lblPrize
            // 
            this.lblPrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrize.Location = new System.Drawing.Point(49, 266);
            this.lblPrize.Name = "lblPrize";
            this.lblPrize.Size = new System.Drawing.Size(269, 36);
            this.lblPrize.TabIndex = 4;
            this.lblPrize.Text = "You get a big prize";
            this.lblPrize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChocolateBoxesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 345);
            this.Controls.Add(this.lblPrize);
            this.Controls.Add(this.btnGetPrize);
            this.Controls.Add(this.lblNumBoxes);
            this.Controls.Add(this.nudNumBoxesSold);
            this.Controls.Add(this.mnuChocolateBoxes);
            this.MainMenuStrip = this.mnuChocolateBoxes;
            this.Name = "ChocolateBoxesForm";
            this.Text = "Chocolate Boxes";
            this.Load += new System.EventHandler(this.ChocolateBoxesForm_Load);
            this.mnuChocolateBoxes.ResumeLayout(false);
            this.mnuChocolateBoxes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumBoxesSold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuChocolateBoxes;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.NumericUpDown nudNumBoxesSold;
        private System.Windows.Forms.Label lblNumBoxes;
        private System.Windows.Forms.Button btnGetPrize;
        private System.Windows.Forms.Label lblPrize;
    }
}

