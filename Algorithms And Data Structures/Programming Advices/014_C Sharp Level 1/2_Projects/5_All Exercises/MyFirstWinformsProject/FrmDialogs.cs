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
    public partial class FrmDialogs : Form
    {
        public FrmDialogs()
        {
            InitializeComponent();
        }

        private void btnChangeBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                textBox1.BackColor = colorDialog1.Color;
        }

        private void btnChangeForeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                textBox1.ForeColor = colorDialog1.Color;
        }

        private void btnChangeFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                MessageBox.Show(saveFileDialog1.FileName);

        }

        private void btnOpenfile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                MessageBox.Show(openFileDialog1.FileName);
        }

        private void btnOpenMultiFiles_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                foreach (string file in openFileDialog1.FileNames)
                    MessageBox.Show(openFileDialog1.FileName);
        }

        private void btnFolderBrowsing_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                MessageBox.Show(folderBrowserDialog1.SelectedPath);
        }
    }
}
