using System;
using System.Linq;
using System.Windows.Forms;
using UserCRUD.Domain.Models;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using UserCRUD.Domain.Services.Abstraction;

namespace UserCRUD.Forms
{
    public partial class Edit : Form
    {
        //Private Properties
        #region

        public bool isDataUpdated = false;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        #endregion

        public Edit()
        {
            InitializeComponent();
        }

        //Events Handling
        #region
        private void FormEditUser_Load(object sender, EventArgs e)
        {
            try
            {
                List<UserRoles> userRoles = new List<UserRoles>();
                UserDataLogic objUserDataLogic = new UserDataLogic();
                userRoles = objUserDataLogic.ReadUsersRole();
                if (userRoles.Count() > 0)
                {
                    foreach (UserRoles item in userRoles)
                    {
                        comboBoxRole.Items.Add(item.RoleName);
                    }
                    txtuser.Text = UserDetailsByUserName.UserName;
                    txtEmail.Text = UserDetailsByUserName.Email;
                    txtFirstName.Text = UserDetailsByUserName.FirstName;
                    txtLastName.Text = UserDetailsByUserName.LastName;
                    txtPhone.Text = UserDetailsByUserName.Phone;
                    comboBoxStatus.Text = UserDetailsByUserName.Status;
                    comboBoxRole.Text = UserDetailsByUserName.Role;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSubmitUser_Click(object sender, EventArgs e)
        {
            try
            {
                string roleId = "";
                Create form_UMS = new Create();
                UserDataLogic objUserDataLogic = new UserDataLogic();
                if (comboBoxRole.SelectedItem != null)
                {
                    roleId = objUserDataLogic.ReadRoleIdByRoleName(comboBoxRole.SelectedItem.ToString());
                }
                if (!string.IsNullOrEmpty(roleId))
                {
                    if (UserValidation())
                    {
                        if (IsValidEmail(txtEmail.Text))
                        {

                            if (objUserDataLogic.UpdateUserData(txtuser.Text, txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPhone.Text, comboBoxStatus.SelectedItem.ToString(), roleId) == true)
                            {
                                isDataUpdated = true;
                                MessageBox.Show("User Updated Successfully!", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                form_UMS.UpdateDataGridView(isDataUpdated);
                                this.Close();
                            }
                        }
                        else
                        {
                            lblSubmitUserError.Visible = true;
                            lblSubmitUserError.Text = "Email is Invalid!";
                        }
                    }
                    else
                    {
                        lblSubmitUserError.Visible = true;
                        lblSubmitUserError.Text = "* These fields are required.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured: {ex.Message}", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormEditUser_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        //Private Methods
        #region

        private bool IsValidEmail(string email)
        {
            // Regular expression for a simple email validation
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
        private bool UserValidation()
        {
            var IsValid = true;
            try
            {
                if (string.IsNullOrEmpty(txtuser.Text.ToString()))
                {
                    IsValid = false;
                    errorUserName.Visible = true;
                }
                if (string.IsNullOrEmpty(txtFirstName.Text.ToString()))
                {
                    IsValid = false;
                    errorFirstName.Visible = true;
                }
                if (string.IsNullOrEmpty(txtLastName.Text.ToString()))
                {
                    IsValid = false;
                    errorLastName.Visible = true;
                }
                if (string.IsNullOrEmpty(txtPhone.Text.ToString()))
                {
                    IsValid = false;
                    errorAddress.Visible = true;
                }
                if (string.IsNullOrEmpty(txtEmail.Text.ToString()))
                {
                    IsValid = false;
                    errorEmail.Visible = true;
                }
                //if (string.IsNullOrEmpty(txtPassword.Text.ToString()))
                //{
                //    IsValid = false;
                //    errorPassword.Visible = true;
                //}
                if (comboBoxRole.SelectedItem == null)
                {
                    IsValid = false;
                    errorRole.Visible = true;
                }
                if (comboBoxStatus.SelectedItem == null)
                {
                    IsValid = false;
                    errorStatus.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return IsValid;
        }
        #endregion
    }
}
