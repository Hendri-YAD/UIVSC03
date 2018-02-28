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
    public partial class Form1 : Form
    {
        private int normalHeight, normalWidth;

        public Form1()
        {           
            InitializeComponent();
            normalHeight = pboDog.Height;
            normalWidth = pboDog.Width;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mniSearchCustomer_Click(object sender, EventArgs e)
        {
            BusinessCase f = new BusinessCase();
            f.Show();
        }

        private void mniMakeNormal_Click(object sender, EventArgs e)
        {
            pboDog.Height = normalHeight;
            pboDog.Width = normalWidth;
        }

        private void mniMakeSmall_Click(object sender, EventArgs e)
        {
            pboDog.Height = normalHeight / 2;
            pboDog.Width = normalWidth / 2;
        }

        private void mniMakeBig_Click(object sender, EventArgs e)
        {
            pboDog.Height = normalHeight * 2;
            pboDog.Width = normalWidth * 2;
        }
    }
}
