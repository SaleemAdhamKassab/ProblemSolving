using MyFirstWinformsProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinformsProject
{
    public partial class FrmPictureBox : Form
    {
        public FrmPictureBox()
        {
            InitializeComponent();
        }

        private void btnWeak_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Weak;
        }

        private void btnStrong_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Strong;
        }
    }
}
