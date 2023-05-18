using Bank.Shared;
using Bank.Views;
using Lab.Bank.Controllers;
using Lab.Bank.Models;
using System;
using System.Windows.Forms;

namespace Bank
{
    public partial class FrmLogin : FrmLayout
    {

        public FrmLogin() : base("Login")
        {
            InitializeComponent();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }
        private void resetLoginForm()
        {
            txtPassword.Clear();
            txtUserName.Clear();
            lblInvalidCredintials.ResetText();
            LoggedUser.loginFailedAttempts = 0;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            ManageUsersController manageUsersController = new ManageUsersController();

            bool isValidUser = manageUsersController.isValidUserNameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());

            if (!isValidUser)
            {
                lblInvalidCredintials.Text = "Inavlid User Name Or Password!! \n You have " + (2 - LoggedUser.loginFailedAttempts) + " attempts before lock your account";
                LoggedUser.loginFailedAttempts++;
                if (LoggedUser.loginFailedAttempts == 3)
                {
                    btnLogin.Enabled = false;
                    lblInvalidCredintials.Text = "You Are Locked after 3 Faild Trails!! \n Contact System Administrators to Unlock Your Account";
                    return;
                }
            }
            else
            {
                User user = manageUsersController.Get(txtUserName.Text.Trim());
                manageUsersController.addLoginLog(user);
                LoggedUser.loggedUser = user;
                resetLoginForm();
                FrmHome frmHome = new FrmHome();
                frmHome.ShowDialog();
            }
        }
    }
}