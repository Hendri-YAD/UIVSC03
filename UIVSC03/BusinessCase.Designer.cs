namespace UIVSC03
{
    partial class BusinessCase
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
            this.cxInfoGbo = new System.Windows.Forms.GroupBox();
            this.cxIDlabel = new System.Windows.Forms.Label();
            this.cxIDTextBox = new System.Windows.Forms.TextBox();
            this.cxNameLabel = new System.Windows.Forms.Label();
            this.cxNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contactGbo = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cxInfoGbo.SuspendLayout();
            this.contactGbo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cxInfoGbo
            // 
            this.cxInfoGbo.Controls.Add(this.cxNameTextBox);
            this.cxInfoGbo.Controls.Add(this.cxNameLabel);
            this.cxInfoGbo.Controls.Add(this.cxIDTextBox);
            this.cxInfoGbo.Controls.Add(this.cxIDlabel);
            this.cxInfoGbo.Location = new System.Drawing.Point(35, 75);
            this.cxInfoGbo.Name = "cxInfoGbo";
            this.cxInfoGbo.Size = new System.Drawing.Size(424, 100);
            this.cxInfoGbo.TabIndex = 0;
            this.cxInfoGbo.TabStop = false;
            this.cxInfoGbo.Text = "Customer Info";
            this.cxInfoGbo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cxIDlabel
            // 
            this.cxIDlabel.AutoSize = true;
            this.cxIDlabel.Location = new System.Drawing.Point(7, 28);
            this.cxIDlabel.Name = "cxIDlabel";
            this.cxIDlabel.Size = new System.Drawing.Size(68, 13);
            this.cxIDlabel.TabIndex = 0;
            this.cxIDlabel.Text = "Customer ID:";
            // 
            // cxIDTextBox
            // 
            this.cxIDTextBox.Location = new System.Drawing.Point(106, 28);
            this.cxIDTextBox.Name = "cxIDTextBox";
            this.cxIDTextBox.Size = new System.Drawing.Size(69, 20);
            this.cxIDTextBox.TabIndex = 1;
            // 
            // cxNameLabel
            // 
            this.cxNameLabel.AutoSize = true;
            this.cxNameLabel.Location = new System.Drawing.Point(7, 66);
            this.cxNameLabel.Name = "cxNameLabel";
            this.cxNameLabel.Size = new System.Drawing.Size(85, 13);
            this.cxNameLabel.TabIndex = 2;
            this.cxNameLabel.Text = "Customer Name:";
            // 
            // cxNameTextBox
            // 
            this.cxNameTextBox.Location = new System.Drawing.Point(106, 63);
            this.cxNameTextBox.Name = "cxNameTextBox";
            this.cxNameTextBox.Size = new System.Drawing.Size(206, 20);
            this.cxNameTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dafesty Video Rental";
            // 
            // contactGbo
            // 
            this.contactGbo.Controls.Add(this.textBox4);
            this.contactGbo.Controls.Add(this.label5);
            this.contactGbo.Controls.Add(this.textBox3);
            this.contactGbo.Controls.Add(this.label4);
            this.contactGbo.Controls.Add(this.textBox2);
            this.contactGbo.Controls.Add(this.label3);
            this.contactGbo.Controls.Add(this.textBox1);
            this.contactGbo.Controls.Add(this.label2);
            this.contactGbo.Location = new System.Drawing.Point(35, 216);
            this.contactGbo.Name = "contactGbo";
            this.contactGbo.Size = new System.Drawing.Size(424, 161);
            this.contactGbo.TabIndex = 2;
            this.contactGbo.TabStop = false;
            this.contactGbo.Text = "Contact Details";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone Number:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(46, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Extension:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(112, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fax Number:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(112, 127);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 20);
            this.textBox4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "E-Mail Address:";
            // 
            // BusinessCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 529);
            this.Controls.Add(this.contactGbo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cxInfoGbo);
            this.Name = "BusinessCase";
            this.Text = "BusinessCase";
            this.cxInfoGbo.ResumeLayout(false);
            this.cxInfoGbo.PerformLayout();
            this.contactGbo.ResumeLayout(false);
            this.contactGbo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox cxInfoGbo;
        private System.Windows.Forms.TextBox cxNameTextBox;
        private System.Windows.Forms.Label cxNameLabel;
        private System.Windows.Forms.TextBox cxIDTextBox;
        private System.Windows.Forms.Label cxIDlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox contactGbo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
    }
}