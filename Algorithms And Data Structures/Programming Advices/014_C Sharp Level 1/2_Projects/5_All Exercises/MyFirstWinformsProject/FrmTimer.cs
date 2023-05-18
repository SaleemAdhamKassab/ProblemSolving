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
    public partial class FrmTimer : Form
    {
        public FrmTimer()
        {
            InitializeComponent();
        }
        private int counter = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}