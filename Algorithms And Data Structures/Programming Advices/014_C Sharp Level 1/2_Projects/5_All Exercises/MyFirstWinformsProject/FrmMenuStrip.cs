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
    public partial class FrmMenuStrip : Form
    {
        public FrmMenuStrip()
        {
            InitializeComponent();
        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add New Client is here");
        }

        private void findClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("find Client is here");
        }
    }
}
