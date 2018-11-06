namespace ForEachControlObjects
{
    partial class frmControlObjects
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
            this.lblChangeVisibility = new System.Windows.Forms.Label();
            this.lstChangeFont = new System.Windows.Forms.ListBox();
            this.btnChangeColour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChangeVisibility
            // 
            this.lblChangeVisibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeVisibility.Location = new System.Drawing.Point(205, 45);
            this.lblChangeVisibility.Name = "lblChangeVisibility";
            this.lblChangeVisibility.Size = new System.Drawing.Size(164, 79);
            this.lblChangeVisibility.TabIndex = 1;
            this.lblChangeVisibility.Text = "Change Text";
            this.lblChangeVisibility.Click += new System.EventHandler(this.lblChangeText_Click);
            // 
            // lstChangeFont
            // 
            this.lstChangeFont.FormattingEnabled = true;
            this.lstChangeFont.Location = new System.Drawing.Point(12, 166);
            this.lstChangeFont.Name = "lstChangeFont";
            this.lstChangeFont.Size = new System.Drawing.Size(247, 147);
            this.lstChangeFont.TabIndex = 2;
            this.lstChangeFont.Tag = "";
            this.lstChangeFont.SelectedIndexChanged += new System.EventHandler(this.lstChangeFont_SelectedIndexChanged);
            // 
            // btnChangeColour
            // 
            this.btnChangeColour.Location = new System.Drawing.Point(12, 12);
            this.btnChangeColour.Name = "btnChangeColour";
            this.btnChangeColour.Size = new System.Drawing.Size(178, 112);
            this.btnChangeColour.TabIndex = 3;
            this.btnChangeColour.Text = "Change Colour";
            this.btnChangeColour.UseVisualStyleBackColor = true;
            this.btnChangeColour.Click += new System.EventHandler(this.btnChangeColour_Click);
            // 
            // frmControlObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 325);
            this.Controls.Add(this.btnChangeColour);
            this.Controls.Add(this.lstChangeFont);
            this.Controls.Add(this.lblChangeVisibility);
            this.Name = "frmControlObjects";
            this.Text = "Control Objects";
            this.Load += new System.EventHandler(this.frmControlObjects_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblChangeVisibility;
        private System.Windows.Forms.ListBox lstChangeFont;
        private System.Windows.Forms.Button btnChangeColour;
    }
}

