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
    public partial class FrmNotifyIcon : Form
    {
        public FrmNotifyIcon()
        {
            InitializeComponent();
        }

        private void btnShowNotify_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
            notifyIcon1.BalloonTipTitle = "This is a title";
            notifyIcon1.BalloonTipText = "This is a message";
            
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            MessageBox.Show("BalloonTip Clicked :-)");
        }
    }
}
