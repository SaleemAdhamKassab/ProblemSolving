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
    public partial class FrmMessageBox : Form
    {
        public FrmMessageBox()
        {
            InitializeComponent();
        }

        private void btnShowMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi this  a message");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi this  a message", "This is a titile Koko");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                MessageBox.Show("User Pressed Ok");
        }

        private void btnShowMessageWithTitleandButtonsandImage_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?",
                                "Confirm",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information) == DialogResult.OK)
                MessageBox.Show("User Pressed Ok");
        }

        private void btnShowMessageWithTitleandButtonsandImageandDefaultButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?",
                                          "Confirm",
                                          MessageBoxButtons.OKCancel,
                                          MessageBoxIcon.Information,
                                          MessageBoxDefaultButton.Button2) == DialogResult.OK)
                MessageBox.Show("User Pressed Ok");
        }
    }
}
