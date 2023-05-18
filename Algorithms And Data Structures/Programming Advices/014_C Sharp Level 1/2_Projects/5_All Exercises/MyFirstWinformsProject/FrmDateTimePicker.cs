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
    public partial class FrmDateTimePicker : Form
    {
        public FrmDateTimePicker()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Text;
        }

        private void btnShortDate_Click(object sender, EventArgs e)
        {
            label1.Text =  dateTimePicker1.Value.ToShortDateString();
        }

        private void btnLongDate_Click(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Value.ToLongDateString();
        }
    }
}
