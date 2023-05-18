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
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            //lbl1.Text = txt1.Text;
            //txt2.Text = txt1.Text;
        }

        private void btnCopyOnMouseClick_Click(object sender, EventArgs e)
        {
            txt2.Text = txt1.Text;
        }

        private void btnCopyOnMouseEnter_MouseEnter(object sender, EventArgs e)
        {
            txt2.Text = txt1.Text;
        }

        private void btnText1ToRed_Click(object sender, EventArgs e)
        {
            txt1.ForeColor = Color.Red;
        }

        private void btnDisableText1_Click(object sender, EventArgs e)
        {
            txt1.Enabled = false;
        }

        private void btnHideText1_Click(object sender, EventArgs e)
        {
            txt1.Hide();
        }

        private void btnChangeFormTitle_Click(object sender, EventArgs e)
        {
            this.Text = "Koko";
        }

        private void btnText1ToWhite_Click(object sender, EventArgs e)
        {
            txt1.ForeColor = Color.White;
        }

        private void btnEnableText1_Click(object sender, EventArgs e)
        {
            txt1.Enabled = true;
        }

        private void btnShowText1_Click(object sender, EventArgs e)
        {
            txt1.Visible = true;
        }

        private void btnChangeLabel_Click(object sender, EventArgs e)
        {
            lbl1.Text = "Saleem Kasssab";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
