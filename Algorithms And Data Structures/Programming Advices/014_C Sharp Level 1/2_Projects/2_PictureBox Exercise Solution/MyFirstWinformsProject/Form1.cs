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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void setPicture(RadioButton radioButton, Bitmap bitmap)
        {
            lblPicName.Text = radioButton.Text;
            pictureBox1.Image = bitmap;
        }
        private void rbBoy_CheckedChanged(object sender, EventArgs e) => setPicture(rbBoy, Resources.Boy);
        private void rbGirl_CheckedChanged(object sender, EventArgs e) => setPicture(rbGirl, Resources.Girl);
        private void rbBook_CheckedChanged(object sender, EventArgs e) => setPicture(rbBook, Resources.Book);
        private void rbPen_CheckedChanged(object sender, EventArgs e) => setPicture(rbPen, Resources.Pen);
    }
}
