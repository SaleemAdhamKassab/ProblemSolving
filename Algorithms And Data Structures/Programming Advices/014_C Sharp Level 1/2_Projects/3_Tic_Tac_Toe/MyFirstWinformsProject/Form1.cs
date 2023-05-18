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
        private void drawGrid(object sender, PaintEventArgs e)
        {
            Color Black = Color.FromArgb(255, 0, 0, 0);

            Pen Pen = new Pen(Color.White);
            Pen.Width = 10;

            // Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            //Columns
            e.Graphics.DrawLine(Pen, 500, 500, 500, 100);
            e.Graphics.DrawLine(Pen, 700, 500, 700, 100);

            //Rows
            e.Graphics.DrawLine(Pen, 350, 250, 900, 250);
            e.Graphics.DrawLine(Pen, 350, 400, 900, 400);
        }
        private char playerChoose = 'x';
        private string player = "Player 1";
        private int count = 0;

        private void setTurnLabel()
        {
            if (lblTurn.Text == "Player 1")
            {
                player = "Player 1";
                lblTurn.Text = "Player 2";
            }
            else
            {
                player = "Player 2";
                lblTurn.Text = "Player 1";
            }
        }
        private char userChoose(PictureBox pictureBox)
        {
            if (playerChoose == 'x')
            {
                playerChoose = 'o';
                pictureBox.Image = Resources.X;
                setTurnLabel();
                return 'x';

            }
            else
            {
                playerChoose = 'x';
                pictureBox.Image = Resources.O;
                setTurnLabel();
                return 'o';
            }
        }
        private void wrongChoose() => MessageBox.Show("Wrong Choose", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
        private void changeImage(PictureBox pictureBox)
        {

            if (pictureBox.Tag.ToString().StartsWith("n"))
            {
                pictureBox.Tag = userChoose(pictureBox);
                checkWinner();
                count++;

                if (count >= 8)
                {
                    MessageBox.Show("No Winner!!", "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetGame();
                    count = 0;
                }
            }
            else
                wrongChoose();
        }
        private bool checkValues(PictureBox pictureBox1, PictureBox pictureBox2, PictureBox pictureBox3)
        {
            if (pictureBox1.Tag.Equals(pictureBox2.Tag) && pictureBox2.Tag.Equals(pictureBox3.Tag))
            {
                pictureBox1.BackColor = Color.GreenYellow;
                pictureBox2.BackColor = Color.GreenYellow;
                pictureBox3.BackColor = Color.GreenYellow;

                return true;
            }

            return false;
        }
        private void resetButton(PictureBox pictureBox, int nullTagNumber)
        {
            pictureBox.Image = Resources.question_mark_96;
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Tag = "n" + nullTagNumber;
        }
        private void btnRestartGame_Click(object sender, EventArgs e) => resetGame();
        private void resetGame()
        {
            resetButton(pb1, 1);
            resetButton(pb2, 2);
            resetButton(pb3, 3);
            resetButton(pb4, 4);
            resetButton(pb5, 5);
            resetButton(pb6, 6);
            resetButton(pb7, 7);
            resetButton(pb8, 8);
            resetButton(pb9, 9);

            playerChoose = 'x';
            player = "Player 1";
            lblTurn.Text = "Player 1";
            lblWinner.Text = "In Progress";
        }
        private bool checkWinner()
        {
            if (
                //Check Rows
                checkValues(pb1, pb2, pb3) || checkValues(pb4, pb5, pb6) || checkValues(pb7, pb8, pb9) ||

               //Check Columns
               checkValues(pb1, pb4, pb7) || checkValues(pb2, pb5, pb8) || checkValues(pb3, pb6, pb9) ||

                //Check diagonals
                checkValues(pb1, pb5, pb9) || checkValues(pb3, pb5, pb7)
                )

            {
                lblWinner.Text = player;
                MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }


            return false;
        }
        private void pb_Click(object sender, System.EventArgs e) => changeImage((PictureBox)sender);
    }
}
