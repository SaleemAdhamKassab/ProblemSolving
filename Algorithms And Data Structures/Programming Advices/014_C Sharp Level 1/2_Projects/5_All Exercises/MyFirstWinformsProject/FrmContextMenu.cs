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
    public partial class FrmContextMenu : Form
    {
        public FrmContextMenu()
        {
            InitializeComponent();
        }

        private void temClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            
        }

        private void tsmChangeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                textBox1.BackColor = colorDialog1.Color;
        }
    }
}
