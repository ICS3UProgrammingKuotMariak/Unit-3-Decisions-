namespace FactorialDoWhile_KuotM_
{
    partial class FactorialDoWhileForm
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
            this.mnuFactorialDoWhile = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lstFactorial = new System.Windows.Forms.ListBox();
            this.mnuFactorialDoWhile.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuFactorialDoWhile
            // 
            this.mnuFactorialDoWhile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuFactorialDoWhile.Location = new System.Drawing.Point(0, 0);
            this.mnuFactorialDoWhile.Name = "mnuFactorialDoWhile";
            this.mnuFactorialDoWhile.Size = new System.Drawing.Size(428, 24);
            this.mnuFactorialDoWhile.TabIndex = 0;
            this.mnuFactorialDoWhile.Text = "menuStrip1";
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
            // lstFactorial
            // 
            this.lstFactorial.FormattingEnabled = true;
            this.lstFactorial.Location = new System.Drawing.Point(22, 76);
            this.lstFactorial.Name = "lstFactorial";
            this.lstFactorial.Size = new System.Drawing.Size(381, 238);
            this.lstFactorial.TabIndex = 1;
            // 
            // FactorialDoWhileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 365);
            this.Controls.Add(this.lstFactorial);
            this.Controls.Add(this.mnuFactorialDoWhile);
            this.MainMenuStrip = this.mnuFactorialDoWhile;
            this.Name = "FactorialDoWhileForm";
            this.Text = "FactorialDoWhile";
            this.Load += new System.EventHandler(this.FactorialDoWhileForm_Load);
            this.mnuFactorialDoWhile.ResumeLayout(false);
            this.mnuFactorialDoWhile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuFactorialDoWhile;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ListBox lstFactorial;
    }
}

