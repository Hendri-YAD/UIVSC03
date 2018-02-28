namespace UIVSC03
{
    partial class frmMDIParent
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mniChildForm1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mniChildForm2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mniChildForm3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniChildForm1,
            this.mniChildForm2,
            this.mniChildForm3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(495, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mniChildForm1
            // 
            this.mniChildForm1.Name = "mniChildForm1";
            this.mniChildForm1.Size = new System.Drawing.Size(81, 20);
            this.mniChildForm1.Text = "ChildForm1";
            this.mniChildForm1.Click += new System.EventHandler(this.mniChildForm1_Click);
            // 
            // mniChildForm2
            // 
            this.mniChildForm2.Name = "mniChildForm2";
            this.mniChildForm2.Size = new System.Drawing.Size(81, 20);
            this.mniChildForm2.Text = "ChildForm2";
            this.mniChildForm2.Click += new System.EventHandler(this.mniChildForm2_Click);
            // 
            // mniChildForm3
            // 
            this.mniChildForm3.Name = "mniChildForm3";
            this.mniChildForm3.Size = new System.Drawing.Size(81, 20);
            this.mniChildForm3.Text = "ChildForm3";
            this.mniChildForm3.Click += new System.EventHandler(this.mniChildForm3_Click);
            // 
            // frmMDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 431);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMDIParent";
            this.Text = "frmMDIParent";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mniChildForm1;
        private System.Windows.Forms.ToolStripMenuItem mniChildForm2;
        private System.Windows.Forms.ToolStripMenuItem mniChildForm3;
    }
}