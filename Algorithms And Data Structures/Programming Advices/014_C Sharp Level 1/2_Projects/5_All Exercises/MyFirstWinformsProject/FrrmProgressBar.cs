using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinformsProject
{
    public partial class FrrmProgressBar : Form
    {
        public FrrmProgressBar()
        {
            InitializeComponent();
        }

        private void btnLoading_Click(object sender, EventArgs e)
        {
            btnLoading.Enabled = false;

            for (int i=progressBar1.Minimum; i <= progressBar1.Maximum; i += progressBar1.Step)
            {
                Thread.Sleep(500);
                progressBar1.Value = i;
                lblLoading.Text = (((float)progressBar1.Value / progressBar1.Maximum) * 100) + "%";
                progressBar1.Refresh();
                lblLoading.Refresh();
            }

            lblLoading.Text = "Completed Loading";
            btnLoading.Enabled = true;
        }

        private void btnResetLoading_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            lblLoading.Text = "Loading";
        }
    }
}
