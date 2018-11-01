namespace WalkingMan_KuotM_
{
    partial class frmWalkingMan
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
            this.mnuWalkingMan = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.picWalkingMan = new System.Windows.Forms.PictureBox();
            this.btnWalk = new System.Windows.Forms.Button();
            this.mnuWalkingMan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWalkingMan)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuWalkingMan
            // 
            this.mnuWalkingMan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuWalkingMan.Location = new System.Drawing.Point(0, 0);
            this.mnuWalkingMan.Name = "mnuWalkingMan";
            this.mnuWalkingMan.Size = new System.Drawing.Size(473, 24);
            this.mnuWalkingMan.TabIndex = 0;
            this.mnuWalkingMan.Text = "menuStrip1";
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
            // picWalkingMan
            // 
            this.picWalkingMan.Location = new System.Drawing.Point(99, 53);
            this.picWalkingMan.Name = "picWalkingMan";
            this.picWalkingMan.Size = new System.Drawing.Size(250, 217);
            this.picWalkingMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWalkingMan.TabIndex = 1;
            this.picWalkingMan.TabStop = false;
            // 
            // btnWalk
            // 
            this.btnWalk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWalk.Location = new System.Drawing.Point(159, 296);
            this.btnWalk.Name = "btnWalk";
            this.btnWalk.Size = new System.Drawing.Size(132, 76);
            this.btnWalk.TabIndex = 2;
            this.btnWalk.Text = "Walk";
            this.btnWalk.UseVisualStyleBackColor = true;
            this.btnWalk.Click += new System.EventHandler(this.btnWalk_Click);
            // 
            // frmWalkingMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 414);
            this.Controls.Add(this.btnWalk);
            this.Controls.Add(this.picWalkingMan);
            this.Controls.Add(this.mnuWalkingMan);
            this.MainMenuStrip = this.mnuWalkingMan;
            this.Name = "frmWalkingMan";
            this.Text = "Walking Man";
            this.Load += new System.EventHandler(this.frmWalkingMan_Load);
            this.mnuWalkingMan.ResumeLayout(false);
            this.mnuWalkingMan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWalkingMan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuWalkingMan;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.PictureBox picWalkingMan;
        private System.Windows.Forms.Button btnWalk;
    }
}

