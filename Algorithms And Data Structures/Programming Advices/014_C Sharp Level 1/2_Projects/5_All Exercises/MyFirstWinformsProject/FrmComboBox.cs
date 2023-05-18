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
    public partial class FrmComboBox : Form
    {
        public FrmComboBox()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
        }

        private void FrmComboBox_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex= 0;
        }
    }
}
