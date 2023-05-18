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
    public partial class FrmMonthCalander : Form
    {
        public FrmMonthCalander()
        {
            InitializeComponent();
        }

        private void btnStartRange_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionStart.ToString());
        }

        private void btnEndRange_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionEnd.ToString());
        }

        private void btnSelectedrange_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionRange.ToString());
        }
    }
}
