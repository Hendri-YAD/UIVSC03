using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIVSC03
{
    public partial class BusinessCaseUI3_1 : Form
    {
        public BusinessCaseUI3_1()
        {
            InitializeComponent();
        }
        private void status_Click(object sender, EventArgs e)
        {
            if (this.fileMenu.Selected)
            {
                this.toolStripStatusLabel1.Text = "File is selected";
                this.statusStrip1.Refresh();

                

            }
            else if (this.windowsMenu.Selected)
            {
                this.toolStripStatusLabel1.Text = "Windows is selected";
                this.statusStrip1.Refresh();
            }
            else if (this.helpMenu.Selected)
            {
                this.toolStripStatusLabel1.Text = "Help is selected";
                this.statusStrip1.Refresh();
            }
            else if (this.customerToolStripMenuItem.Pressed)
            {
                this.toolStripStatusLabel1.Text = "Customer is selected";
                this.statusStrip1.Refresh();
            }
            else if (this.freshInvoiceToolStripMenuItem.Pressed)
            {
                this.toolStripStatusLabel1.Text = "Fresh In-voice is selected";
                this.statusStrip1.Refresh();
            }
            else if (this.videoToolStripMenuItem.Pressed)
            {
                this.toolStripStatusLabel1.Text = "Video is selected";
                this.statusStrip1.Refresh();
            }
            else if (this.newInvoiceToolStripMenuItem.Pressed)
            {
                this.toolStripStatusLabel1.Text = "New Invoice is selected";
                this.statusStrip1.Refresh();
            }
            else if (this.checkInTapeToolStripMenuItem.Pressed)
            {
                this.toolStripStatusLabel1.Text = "Check in Tape is selected";
                this.statusStrip1.Refresh();
            }
            else if (this.exitToolStripMenuItem.Pressed)
            {
                this.toolStripStatusLabel1.Text = "Exit is selected";
                this.statusStrip1.Refresh();
            }

        }


        private void BusinessCaseUI3_1_Click(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "";
            this.statusStrip1.Refresh();
        }
    }
}
