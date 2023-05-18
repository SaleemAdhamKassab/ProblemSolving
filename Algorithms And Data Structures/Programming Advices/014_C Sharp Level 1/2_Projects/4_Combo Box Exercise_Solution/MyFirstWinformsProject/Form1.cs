using MyFirstWinformsProject.Properties;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace MyFirstWinformsProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
        private void setPictureBox(string dropDownChoose)
        {
            switch (dropDownChoose)
            {
                case "Pen":
                    pictureBox1.Image = Resources.Pen;
                    break;
                case "Boy":
                    pictureBox1.Image = Resources.Boy;
                    break;
                case "Girl":
                    pictureBox1.Image = Resources.Girl;
                    break;
                case "Book":
                    pictureBox1.Image = Resources.Book;
                    break;
                default:
                    lblTitle.Text = "Invalid Title";
                    break;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTitle.Text = comboBox1.Text;
            setPictureBox(lblTitle.Text);
        }
    }
}
