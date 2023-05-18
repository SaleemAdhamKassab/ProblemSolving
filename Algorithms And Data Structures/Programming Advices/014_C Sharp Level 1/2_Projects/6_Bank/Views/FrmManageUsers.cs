using Bank.Shared;
using Lab.Bank.Controllers;
using Lab.Bank.Models;
using Lab.Bank.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank.Views
{
    public partial class FrmManageUsers : FrmLayout
    {
        ManageUsersController manageUsersController = new ManageUsersController();
        FrontEndFunctions frontEndFunctions = new FrontEndFunctions();
        List<object> users = new List<object>();
        List<object> loginUsers = new List<object>();
        User _userToUpdate;

        public FrmManageUsers() : base("Manage Users")
        {
            InitializeComponent();
            resetManageUsersForms();
        }

        ////////////////////////// Shared /////////////////////////
        private void resetManageUsersForms()
        {
            resetShowUsersForm();
            resetAddNewUserForm();
            resetUpdateUserForm();
            resetLoginRegisterForm();
        }
        private void validateUsertForm(TextBox textBox, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                UserInfoErrorProvider.SetError(textBox, "required");
            }
            else if (textBox.Name == "txtAddNewUserName" && manageUsersController.IsUserExsist(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                UserInfoErrorProvider.SetError(textBox, "User Name (" + textBox.Text + ") is already used, Choose another one.");
            }
            else if ((textBox.Name == "txtAddNewUserEmail" || textBox.Name == "txtUpdateUserEmail") && !textBox.Text.Contains("@"))
            {
                e.Cancel = true;
                textBox.Focus();
                UserInfoErrorProvider.SetError(textBox, "Invalid Email, Include an '@' in the email address");
            }
            else if ((textBox.Name == "txtAddNewUserPhone" || textBox.Name == "txtUpdateUserPhone") && !textBox.Text.All(char.IsDigit))
            {
                e.Cancel = true;
                textBox.Focus();
                UserInfoErrorProvider.SetError(textBox, "Invalid Phone, Only Numbers Accepted");
            }
            else
            {
                e.Cancel = false;
                UserInfoErrorProvider.SetError(textBox, null);
            }

            updateProgressBarAddNewUser(addNewUserValidFormInputsCount());
        }
        private void validateUserForm(object sender, CancelEventArgs e) => validateUsertForm((TextBox)sender, e);
        private void tabControlesManageUsers_SelectedIndexChanged(object sender, EventArgs e) => resetManageUsersForms();

        ////////////////////////// Show Users /////////////////////////
        private void resetShowUsersForm()
        {
            lstViewShowUsers.Items.Clear();
            txtShowUsersSearch.Clear();
            fillUsersListView();
        }
        private void txtShowUsersSearch_KeyUp(object sender, KeyEventArgs e) => frontEndFunctions.txtSearch_KeyUp(sender, e, lstViewShowUsers, users, txtShowUsersSearch, lblShowUsersCount, "users");
        private void rbShowUsersAsc_CheckedChanged(object sender, EventArgs e) => frontEndFunctions.lstViewSort(sender, e, lstViewShowUsers);
        private void rbShowUsersDesc_CheckedChanged(object sender, EventArgs e) => frontEndFunctions.lstViewSort(sender, e, lstViewShowUsers, SortOrder.Descending);
        private void fillUsersListView()
        {
            users = manageUsersController.Get();
            frontEndFunctions.fillListView(users, lstViewShowUsers, lblShowUsersCount, "users");
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                          "Are you sure to Delete Acc. (" + lstViewShowUsers.SelectedItems[0].SubItems[0].Text + ")?",
                          "Confirm"
                          , MessageBoxButtons.OKCancel,
                          MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Client (" + lstViewShowUsers.SelectedItems[0].SubItems[0].Text + ") Deleted Successfully",
                 "Info",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);

                manageUsersController.Delete(lstViewShowUsers.SelectedItems[0].SubItems[0].Text);
                lstViewShowUsers.Items.Remove(lstViewShowUsers.SelectedItems[0]);
            }
        }

        ////////////////////////// Add New User /////////////////////////
        private void resetAddNewUserForm()
        {
            txtAddNewUserName.Clear();
            txtAddNewUserEmail.Clear();
            txtAddNewUserFirstName.Clear();
            txtAddNewUserLastName.Clear();
            txtAddNewUserPhone.Clear();
            txtAddNewUserPassword.Clear();
            rbAddUserPermissionsYes.Checked = false;
            rbAddUserPermissionsNo.Checked = false;
            permissionsStatus(grpAddNewUserPermissions, false, false);


            circularProgressBarAddNewUser.Value = 0;
            circularProgressBarAddNewUser.Text = "0%";
            btnAddNewUser.Enabled = false;
        }
        private void permissionsStatus(GroupBox groupBox, bool isChecked, bool isEnabled = true)
        {
            foreach (CheckBox control in groupBox.Controls.OfType<CheckBox>())
            {
                control.Checked = isChecked;
                control.Enabled = isEnabled;
            }
        }
        private int getPermissionsValue(CheckBox checkBox)
        {
            int result = 0;

            switch (checkBox.Name)
            {
                case "chkManageClients":
                case "chkUpdateManageClients":
                    result = 1;
                    break;

                case "chkManageUsers":
                case "chkUpdateManageUsers":
                    result = 2;
                    break;
                case "chkClientsTransactions":
                case "chkUpdateClientsTransactions":
                    result = 4;
                    break;
                case "chkCurrencyExchange":
                case "chkUpdateCurrencyExchange":
                    result = 8;
                    break;
            }

            return result;
        }
        int _grantUserPermissions(RadioButton rbAllPermissionsYes, GroupBox groupBox)
        {
            if (rbAllPermissionsYes.Checked)
                return -1;

            int permissionsValue = 0;

            foreach (CheckBox control in groupBox.Controls.OfType<CheckBox>())
                if (control.Checked == true)
                    permissionsValue += getPermissionsValue(control);

            return permissionsValue == 10 ? -1 : permissionsValue;
        }
        private User getUserInfo() =>
              new User(
              txtAddNewUserFirstName.Text.Trim(),
              txtAddNewUserLastName.Text.Trim(),
              txtAddNewUserEmail.Text.Trim(),
              txtAddNewUserPhone.Text.Trim(),
              txtAddNewUserName.Text.Trim(),
              txtAddNewUserPassword.Text.Trim(),
              _grantUserPermissions(rbAddUserPermissionsYes, grpAddNewUserPermissions));
        private void checkBtnAddNewUserStatus()
        {
            if (circularProgressBarAddNewUser.Value == 6)
                btnAddNewUser.Enabled = true;
            else
                btnAddNewUser.Enabled = false;
        }
        private void updateProgressBarAddNewUser(int value)
        {
            circularProgressBarAddNewUser.Value = value;
            circularProgressBarAddNewUser.Text = (((float)circularProgressBarAddNewUser.Value / circularProgressBarAddNewUser.Maximum) * 100).ToString("0") + "%";
            circularProgressBarAddNewUser.ProgressColor = Color.FromArgb(192, 192, 255);
            circularProgressBarAddNewUser.Refresh();

            checkBtnAddNewUserStatus();
        }
        private int addNewUserValidFormInputsCount()
        {
            int counter = 0;

            if (!String.IsNullOrWhiteSpace(txtAddNewUserName.Text) && !manageUsersController.IsUserExsist(txtAddNewUserName.Text))
                counter++;
            if (!String.IsNullOrWhiteSpace(txtAddNewUserFirstName.Text))
                counter++;
            if (!String.IsNullOrWhiteSpace(txtAddNewUserLastName.Text))
                counter++;
            if (!String.IsNullOrWhiteSpace(txtAddNewUserPassword.Text))
                counter++;
            if (!String.IsNullOrWhiteSpace(txtAddNewUserEmail.Text) &&
                txtAddNewUserEmail.Text.Contains("@"))
                counter++;
            if (!String.IsNullOrWhiteSpace(txtAddNewUserPhone.Text) &&
                txtAddNewUserPhone.Text.All(char.IsDigit))
                counter++;

            return counter;
        }
        private void rbPermissionsYes_CheckedChanged(object sender, EventArgs e) => permissionsStatus(grpAddNewUserPermissions, true, false);
        private void rbPermissionsNo_CheckedChanged(object sender, EventArgs e) => permissionsStatus(grpAddNewUserPermissions, false);
        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                            "Are you sure to Add user (" + txtAddNewUserName.Text.Trim() + ") ?",
                            "Confirm"
                            , MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Question) == DialogResult.OK)
            {
                manageUsersController.Post(getUserInfo());

                MessageBox.Show("User (" + txtAddNewUserName.Text.Trim() + ") Added Successfully",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                resetAddNewUserForm();
            }
        }

        ////////////////////////// Update User /////////////////////////
        private void resetUpdateUserForm()
        {
            changeUpdateUSerFormInputsStatus(false);
            txtUpdateUserEmail.Clear();
            txtUpdateUserFirstName.Clear();
            txtUpdateUserLastName.Clear();
            txtUpdateUserPhone.Clear();
            txtUpdateUserPassword.Clear();
            permissionsStatus(grpUpdateUserPermissions, false, false);
            btnAddNewUser.Enabled = false;
            fillComboBoxUpdateUserName();
            btnUpdateUser.Enabled = false;
        }
        private List<string> getUsersNames()
        {
            List<string> usersNames = new List<string>();
            foreach (User user in users)
                usersNames.Add(user.UserName);

            return usersNames;
        }
        private void fillComboBoxUpdateUserName()
        {
            cbUpdateUserName.Items.Clear();
            List<string> userNames = getUsersNames();

            foreach (string user in userNames)
                cbUpdateUserName.Items.Add(user);
        }
        private void fillUpdateUserFormWithSelectedUser()
        {
            txtUpdateUserEmail.Text = _userToUpdate.Email;
            txtUpdateUserFirstName.Text = _userToUpdate.FirstName;
            txtUpdateUserLastName.Text = _userToUpdate.LastName;
            txtUpdateUserPhone.Text = _userToUpdate.Phone;
            txtUpdateUserPassword.Text = _userToUpdate.Password;
        }
        private void changeUpdateUSerFormInputsStatus(bool status)
        {
            txtUpdateUserEmail.Enabled = status;
            txtUpdateUserFirstName.Enabled = status;
            txtUpdateUserLastName.Enabled = status;
            txtUpdateUserPhone.Enabled = status;
            txtUpdateUserPassword.Enabled = status;
            rbUpdateUserPermissionsYes.Checked = status;
            rbUpdateUserPermissionsYes.Enabled = status;
            rbUpdateUserPermissionsNo.Checked = status;
            rbUpdateUserPermissionsNo.Enabled = status;
        }
        private void cbUpdateUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            _userToUpdate = manageUsersController.Get(cbUpdateUserName.SelectedItem.ToString());
            fillUpdateUserFormWithSelectedUser();
            changeUpdateUSerFormInputsStatus(true);
            btnUpdateUser.Enabled = true;
        }
        private User getUpdatedUserInfo() =>
            new User(
              txtUpdateUserFirstName.Text.Trim(),
              txtUpdateUserLastName.Text.Trim(),
              txtUpdateUserEmail.Text.Trim(),
              txtUpdateUserPhone.Text.Trim(),
              _userToUpdate.UserName,
              txtUpdateUserPassword.Text.Trim(),
              _grantUserPermissions(rbUpdateUserPermissionsYes, grpUpdateUserPermissions));
        private void rbUpdateUserPermissionsYes_CheckedChanged(object sender, EventArgs e) => permissionsStatus(grpUpdateUserPermissions, true, false);
        private void rbUpdateUserPermissionsNo_CheckedChanged(object sender, EventArgs e) => permissionsStatus(grpUpdateUserPermissions, false);
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                            "Are you sure to Update The User (" + _userToUpdate.UserName + ") ?",
                            "Confirm"
                            , MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Question) == DialogResult.OK)
            {
                manageUsersController.Delete(_userToUpdate.UserName);
                manageUsersController.Post(getUpdatedUserInfo());

                MessageBox.Show("User (" + txtAddNewUserName.Text.Trim() + ") Updated Successfully",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                resetUpdateUserForm();
            }
        }

        ////////////////////////// Login Register /////////////////////////
        private void resetLoginRegisterForm()
        {
            lstViewLoginRegister.Items.Clear();
            txtLoginRegisterSearch.Clear();
            fillLoginRegisterListView();
        }
        private void fillLoginRegisterListView()
        {
            loginUsers = manageUsersController.getLoginLog();
            frontEndFunctions.fillListView(loginUsers, lstViewLoginRegister, lblLoginRegister, "loginRegister");
        }
        private void txtLoginRegisterSearch_KeyUp(object sender, KeyEventArgs e) => frontEndFunctions.txtSearch_KeyUp(sender, e, lstViewLoginRegister, loginUsers, txtLoginRegisterSearch, lblLoginRegister, "loginRegister");
        private void rbLoginRegisterAsc_CheckedChanged(object sender, EventArgs e) => frontEndFunctions.lstViewSort(sender, e, lstViewLoginRegister);
        private void rbLoginRegisterDesc_CheckedChanged(object sender, EventArgs e) => frontEndFunctions.lstViewSort(sender, e, lstViewLoginRegister, SortOrder.Descending);
    }
}