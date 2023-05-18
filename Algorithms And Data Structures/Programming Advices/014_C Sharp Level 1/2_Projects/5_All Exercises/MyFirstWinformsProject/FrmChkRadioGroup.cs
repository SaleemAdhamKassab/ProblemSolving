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
    public partial class FrmChkRadioGroup : Form
    {
        public FrmChkRadioGroup()
        {
            InitializeComponent();
        }

        private void chkEmail_CheckedChanged(object sender, EventArgs e)
        {
            btnSenEmail.Enabled = chkEmail.Checked;
        }

        private void FrmChkRadioGroup_Load(object sender, EventArgs e)
        {
            btnSenEmail.Enabled = false;
        }

        private void btnSenEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Email Sended");
        }

        private void btnIsSmall_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rbSmall.Checked.ToString());
        }

        private void btnDisablePizzaSize_Click(object sender, EventArgs e)
        {
            grpSize.Enabled = false;
        }
    }
}
