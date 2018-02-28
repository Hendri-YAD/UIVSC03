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
    public partial class Exercise3_1 : Form
    {
        public Exercise3_1()
        {
            InitializeComponent();
        }

        private void changeImagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Image.FromFile(@"C:\Users\Henry-YAB\Desktop\GDipSA\SA4102\Lectures\UIVSC\Image\BFLY2.BMP");
        }

        private void revertBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Image.FromFile(@"C:\Users\Henry-YAB\Desktop\GDipSA\SA4102\Lectures\UIVSC\Image\BFLY1.BMP");
        }
    }
}
