namespace UIVSC03
{
    partial class Exercise3_1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exercise3_1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeImagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revertBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeImagToolStripMenuItem,
            this.revertBackToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // changeImagToolStripMenuItem
            // 
            this.changeImagToolStripMenuItem.Name = "changeImagToolStripMenuItem";
            this.changeImagToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.changeImagToolStripMenuItem.Text = "ChangeImage";
            this.changeImagToolStripMenuItem.Click += new System.EventHandler(this.changeImagToolStripMenuItem_Click);
            // 
            // revertBackToolStripMenuItem
            // 
            this.revertBackToolStripMenuItem.Name = "revertBackToolStripMenuItem";
            this.revertBackToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.revertBackToolStripMenuItem.Text = "Revert Back";
            this.revertBackToolStripMenuItem.Click += new System.EventHandler(this.revertBackToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(99, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 80);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Exercise3_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 389);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Exercise3_1";
            this.Text = "Exercise3_1";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem changeImagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revertBackToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}