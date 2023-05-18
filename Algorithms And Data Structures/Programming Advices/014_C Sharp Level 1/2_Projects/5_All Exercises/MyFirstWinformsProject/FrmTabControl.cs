using MyFirstWinformsProject.Properties;
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
    public partial class FrmTabControl : Form
    {
        public FrmTabControl()
        {
            InitializeComponent();
        }

        struct Register
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime DataOfBirth { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string ProfileImage { get; set; }
        }
        private Register register = new Register();
        private void updateProgressBar()
        {
            progressBar1.Value += 10;
            lblLoadedInfo.Text = Math.Round((((float)progressBar1.Value / progressBar1.Maximum) * 100)) + "%";
            progressBar1.Refresh();
            lblLoadedInfo.Refresh();
        }
        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                e.Cancel = true;
                txtFirstName.Focus();
                errorProvider1.SetError(txtFirstName, "Required");
            }
            else
            {
                register.FirstName = txtFirstName.Text.Trim();
                e.Cancel = false;
                errorProvider1.SetError(txtFirstName, "");
                updateProgressBar();
            }
        }
        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtLastName.Text))
            {
                e.Cancel = true;
                txtLastName.Focus();
                errorProvider1.SetError(txtLastName, "Required");
            }
            else
            {
                register.LastName = txtLastName.Text.Trim();
                e.Cancel = false;
                errorProvider1.SetError(txtLastName, "");
                updateProgressBar();
            }

        }
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Required");
                txtEmail.Focus();
            }
            else if (!txtEmail.Text.Contains("@"))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Invalid Email");
                txtEmail.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, "");
                register.Email = txtEmail.Text.Trim();
                updateProgressBar();
            }
        }
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Required");
                txtPassword.Focus();
            }
            else if (!txtPassword.Text.Any(char.IsDigit))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Required Number");
                txtPassword.Focus();
            }
            else if (!txtPassword.Text.Any(char.IsLetter))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Required Letter");
                txtPassword.Focus();
            }
            else
            {
                e.Cancel = false;
                register.Password = txtPassword.Text;
                errorProvider1.SetError(txtPassword, "");
                updateProgressBar();
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            lblResult.Text =
                "First Name: " + register.FirstName + "\n" +
                "Last Name: " + register.LastName + "\n" +
                "Date Of Birth: " + register.DataOfBirth + "\n" +
                "Email: " + register.Email + "\n" +
                "Passwrod: " + register.Password + "\n" +
                "Profile Image: " + register.ProfileImage;
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            register.DataOfBirth = dateTimePicker1.Value;
            updateProgressBar();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Saleem;
            register.ProfileImage = "Saleem.jpg";
            updateProgressBar();
        }

        private bool isValidUser(string email, string password) => email == "saleem@gmail.com" && password == "123";
        private void button1_Click(object sender, EventArgs e)
        {
            if (isValidUser(txtloginEmail.Text, txtloginPassword.Text))
            {
                lblLogin.ForeColor = Color.Green;
                lblLogin.Text = "Login Successfully";
            }
            else
            {
                lblLogin.ForeColor = Color.Red;
                lblLogin.Text = "Invalid Email or Password!";
            }
        }
    }
}
