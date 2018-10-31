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
            this.lstFactorialNumbers = new System.Windows.Forms.ListBox();
            this.lblEnterNum = new System.Windows.Forms.Label();
            this.txtUserNum = new System.Windows.Forms.TextBox();
            this.lblFactorialAnswer = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblMultiplyNum = new System.Windows.Forms.Label();
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
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // lstFactorialNumbers
            // 
            this.lstFactorialNumbers.FormattingEnabled = true;
            this.lstFactorialNumbers.Location = new System.Drawing.Point(142, 123);
            this.lstFactorialNumbers.Name = "lstFactorialNumbers";
            this.lstFactorialNumbers.Size = new System.Drawing.Size(264, 186);
            this.lstFactorialNumbers.TabIndex = 1;
            // 
            // lblEnterNum
            // 
            this.lblEnterNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterNum.Location = new System.Drawing.Point(22, 44);
            this.lblEnterNum.Name = "lblEnterNum";
            this.lblEnterNum.Size = new System.Drawing.Size(152, 29);
            this.lblEnterNum.TabIndex = 2;
            this.lblEnterNum.Text = "Enter a number:";
            // 
            // txtUserNum
            // 
            this.txtUserNum.Location = new System.Drawing.Point(213, 49);
            this.txtUserNum.Name = "txtUserNum";
            this.txtUserNum.Size = new System.Drawing.Size(148, 20);
            this.txtUserNum.TabIndex = 3;
            // 
            // lblFactorialAnswer
            // 
            this.lblFactorialAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactorialAnswer.Location = new System.Drawing.Point(22, 326);
            this.lblFactorialAnswer.Name = "lblFactorialAnswer";
            this.lblFactorialAnswer.Size = new System.Drawing.Size(394, 30);
            this.lblFactorialAnswer.TabIndex = 4;
            this.lblFactorialAnswer.Text = "Factorial Answer";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(142, 76);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(110, 37);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblMultiplyNum
            // 
            this.lblMultiplyNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiplyNum.Location = new System.Drawing.Point(12, 123);
            this.lblMultiplyNum.Name = "lblMultiplyNum";
            this.lblMultiplyNum.Size = new System.Drawing.Size(124, 84);
            this.lblMultiplyNum.TabIndex = 6;
            this.lblMultiplyNum.Text = "Multiply these numbers together:";
            // 
            // FactorialDoWhileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 365);
            this.Controls.Add(this.lblMultiplyNum);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblFactorialAnswer);
            this.Controls.Add(this.txtUserNum);
            this.Controls.Add(this.lblEnterNum);
            this.Controls.Add(this.lstFactorialNumbers);
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
        private System.Windows.Forms.ListBox lstFactorialNumbers;
        private System.Windows.Forms.Label lblEnterNum;
        private System.Windows.Forms.TextBox txtUserNum;
        private System.Windows.Forms.Label lblFactorialAnswer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblMultiplyNum;
    }
}

