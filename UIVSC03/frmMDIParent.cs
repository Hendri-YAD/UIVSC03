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
    public partial class frmMDIParent : Form
    {
        public frmMDIParent()
        {
            InitializeComponent();
        }

        private void mniChildForm1_Click(object sender, EventArgs e)
        {
            frmMDIChild1 mdiform = new frmMDIChild1();
            mdiform.MdiParent = this;
            mdiform.Show();
        }

        private void mniChildForm2_Click(object sender, EventArgs e)
        {
            frmMDIChild2 mdiform = new frmMDIChild2();
            mdiform.Show();
        }

        private void mniChildForm3_Click(object sender, EventArgs e)
        {
            frmMDIChild3 mdiform = new frmMDIChild3();
            mdiform.MdiParent = this;
            mdiform.Show();
        }
    }
}
