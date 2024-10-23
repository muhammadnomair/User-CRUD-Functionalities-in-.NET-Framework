using System;
using System.Linq;
using UserCRUD.Enum;
using System.Drawing;
using UserCRUD.Helpers;
using System.Windows.Forms;
using UserCRUD.Domain.Models;
using UserCRUD.Domain.Services;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UserCRUD.Domain.Services.Abstraction;

namespace UserCRUD.Forms
{
    public partial class Create : Form
    {

        //Private Properties
        #region
        
        private int pageSize = 19;
        private int currentPage = 1;
        private int totalPages = 0;
        
        #endregion

        public Create()
        {
            InitializeComponent();
        }

        //Events Handling
        #region

        private void btnSubmitUser_Click(object sender, EventArgs e)
        {
            try
            {
                UserDataLogic userDataLogic = new UserDataLogic();
                string roleId = "";
                ResetError();
                if (!userDataLogic.ReadAllUserDataByUserName(txtuser.Text))
                {
                    if (UserValidation())
                    {
                        if (IsValidEmail(txtEmail.Text))
                        {
                            string passwordValidationResult = IsValidPassword(txtPassword.Text);
                            if (passwordValidationResult == "Valid")
                            {
                                if (comboBoxRole.SelectedItem != null)
                                {
                                    roleId = userDataLogic.ReadRoleIdByRoleName(comboBoxRole.SelectedItem.ToString());
                                }
                                if (!string.IsNullOrEmpty(roleId))
                                {
                                    string saltKey = Hashing.GenerateHashedSaltKey();
                                    string hashedPassword = Hashing.GenerateHashPassword(txtPassword.Text, saltKey);
                                    if (userDataLogic.InsertUserData(txtuser.Text, hashedPassword, txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPhone.Text, comboBoxStatus.SelectedItem.ToString(), roleId, saltKey) == true)
                                    {
                                        UserSubmitted();
                                        dataGridView1.DataSource = null;
                                        List<UserDetails> userData = new List<UserDetails>();
                                        userData = userDataLogic.ReadAllUserData(currentPage, pageSize);
                                        if (userData.Count() > 0)
                                        {
                                            dataGridView1.DataSource = userData;
                                        }
                                        MessageBox.Show("User Added Successfully!", "Create User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                            else
                            {
                                lblSubmitUserError.Visible = true;
                                lblSubmitUserError.Text = $"Password is weak.{passwordValidationResult}";
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
                else
                {
                    lblSubmitUserError.Visible = true;
                    lblSubmitUserError.Text = "User Name is Already Taken";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured during user creation: {ex.Message}", "Create User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Username")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.Black;
            }
        }
        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Username";
                txtuser.ForeColor = Color.Black;
            }
        }
        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "First Name")
            {
                txtFirstName.Text = "";
                txtFirstName.ForeColor = Color.Black;
            }
        }
        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                txtFirstName.Text = "First Name";
                txtFirstName.ForeColor = Color.Black;
            }
        }
        private void txtLastName_Enter(object sender, EventArgs e)
        {
            if (txtLastName.Text == "Last Name")
            {
                txtLastName.Text = "";
                txtLastName.ForeColor = Color.Black;
            }
        }
        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (txtLastName.Text == "")
            {
                txtLastName.Text = "Last Name";
                txtLastName.ForeColor = Color.Black;
            }
        }
        private void comboBoxStatus_Enter(object sender, EventArgs e)
        {
            if (comboBoxStatus.Text == "Status")
            {
                comboBoxStatus.Text = "";
                comboBoxStatus.ForeColor = Color.Black;
            }
        }
        private void comboBoxStatus_Leave(object sender, EventArgs e)
        {
            if (comboBoxStatus.Text == "")
            {
                comboBoxStatus.Text = "Status";
                comboBoxStatus.ForeColor = Color.Black;
            }
        }
        private void comboBoxRole_Enter(object sender, EventArgs e)
        {
            if (comboBoxRole.Text == "Role")
            {
                comboBoxRole.Text = "";
                comboBoxRole.ForeColor = Color.Black;
            }
        }
        private void comboBoxRole_Leave(object sender, EventArgs e)
        {
            if (comboBoxRole.Text == "")
            {
                comboBoxRole.Text = "Role";
                comboBoxRole.ForeColor = Color.Black;
            }
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = false;
            }
        }
        private void txtPhone_Enter(object sender, EventArgs e)
        {
            if (txtPhone.Text == "Phone")
            {
                txtPhone.Text = "";
                txtPhone.ForeColor = Color.Black;
            }
        }
        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                txtPhone.Text = "Phone";
                txtPhone.ForeColor = Color.Black;
            }
        }
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.Black;
            }
        }
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            try
            {
                UserDataLogic objUserDataLogic = new UserDataLogic();
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataGridView1.SelectedRows[0];
                    if (objUserDataLogic.ReadAllUserDataByUserName(row.Cells[0].Value.ToString()))
                    {
                        Edit formEditUser = new Edit();
                        formEditUser.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Please select user to Edit", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured during editing user: {ex.Message}", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Create_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                UserDataLogic objUserDataLogic = new UserDataLogic();
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Are you sure?\nYou want to Delete User?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        DataGridViewRow row = dataGridView1.SelectedRows[0];
                        if (row.Cells[0].Value != null)
                        {
                            if (objUserDataLogic.ReadUserRoleByUserName(row.Cells[0].Value.ToString()) != UsersPosition.SuperAdmin.ToString())
                            {
                                if (objUserDataLogic.DeleteUser(row.Cells[0].Value.ToString()))
                                {
                                    dataGridView1.DataSource = null;
                                    List<UserDetails> userData = new List<UserDetails>();
                                    userData = objUserDataLogic.ReadAllUserData(currentPage, pageSize);
                                    if (userData.Count() > 0)
                                    {
                                        dataGridView1.DataSource = userData;
                                    }
                                    MessageBox.Show("User Deleted Successfully!", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Default Super Admin user can not be deleted!", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select user to delete", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured during deleting user: {ex.Message}", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Create_Load(object sender, EventArgs e)
        {
            try
            {
                List<UserRoles> userRoles = new List<UserRoles>();
                UserDataLogic objUserDataLogic = new UserDataLogic();
                int count = objUserDataLogic.ReadUserDataCount();
                int result = count % pageSize;
                if (result == 0)
                {
                    totalPages = count / pageSize;
                }
                else
                {
                    totalPages = (count / pageSize) + 1;
                }
                userRoles = objUserDataLogic.ReadUsersRole();
                if (userRoles.Count() > 0)
                {
                    foreach (UserRoles item in userRoles)
                    {
                        comboBoxRole.Items.Add(item.RoleName);
                    }
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured: {ex.Message}", "UMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentPage < totalPages)
                {
                    currentPage++;
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentPage > 1)
                {
                    currentPage--;
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        //Private Methods
        #region

        private void LoadData()
        {
            try
            {
                List<UserDetails> userData = new List<UserDetails>();
                UserDataService objUserDataService = new UserDataService();
                userData = objUserDataService.ReadAllUserData(currentPage, pageSize);
                if (userData.Count() > 0)
                {
                    dataGridView1.DataSource = userData;
                    UpdatePageLabel();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateDataGridView(bool isDataEffected)
        {
            if (isDataEffected)
            {
                UserDataLogic objUserDataLogic = new UserDataLogic();
                dataGridView1.DataSource = null;
                List<UserDetails> userData = new List<UserDetails>();
                userData = objUserDataLogic.ReadAllUserData(currentPage, pageSize);
                if (userData.Count() > 0)
                {
                    dataGridView1.DataSource = userData;
                }
            }
        }
        private void UpdatePageLabel()
        {
            lblPageInfo.Text = $"Page {currentPage} of {totalPages}";
        }
        // check validation while creating a new user by providing information in each field
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
                if (string.IsNullOrEmpty(txtPassword.Text.ToString()))
                {
                    IsValid = false;
                    errorPassword.Visible = true;
                }
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
        }// End of the function: UserValidation
        
        private void UserSubmitted()
        {
            lblSubmitUserError.Visible = false;
            txtuser.Clear();
            txtuser.Text = "Username";
            txtPassword.Clear();
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.Text = "Password";
            txtFirstName.Clear();
            txtFirstName.Text = "First Name";
            txtLastName.Clear();
            txtLastName.Text = "Last Name";
            txtEmail.Clear();
            txtEmail.Text = "Email";
            txtPhone.Clear();
            txtPhone.Text = "Phone";

            comboBoxRole.SelectedItem = null;
            comboBoxRole.Text = "Role";
            comboBoxStatus.SelectedItem = null;
            comboBoxStatus.Text = "Status";
            UserSubmittedSuccessfully();
        }
        private void UserSubmittedSuccessfully()
        {
            try
            {
                errorUserName.Visible = false;
                errorFirstName.Visible = false;
                errorLastName.Visible = false;
                errorAddress.Visible = false;
                errorEmail.Visible = false;
                errorPassword.Visible = false;
                lblSubmitUserError.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ResetError()
        {
            lblSubmitUserError.Visible = false;
            errorUserName.Visible = false;
            errorFirstName.Visible = false;
            errorLastName.Visible = false;
            errorAddress.Visible = false;
            errorEmail.Visible = false;
            errorPassword.Visible = false;
            errorRole.Visible = false;
            errorStatus.Visible = false;
        }
        // Check the valid email while creating a new user
        private bool IsValidEmail(string email)
        {
            // Regular expression for a simple email validation
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
        private string IsValidPassword(string password)
        {
            try
            {
                // Minimum and maximum length
                if (password.Length < 8 || password.Length > 20)
                    return "Password should be at least 8 characters long.";

                // Contains at least one uppercase letter
                if (!password.Any(char.IsUpper))
                    return "Password should contain at least one uppercase letter.";

                // Contains at least one lowercase letter
                if (!password.Any(char.IsLower))
                    return "Password should contain at least one lowercase letter.";

                // Contains at least one digit
                if (!password.Any(char.IsDigit))
                    return "Password should contain at least one digit.";

                // Contains at least one special character
                string specialCharacters = @"!@#$%^&*()-_+=<>?/{}[]|";
                if (!password.Any(c => specialCharacters.Contains(c)))
                    return "Password should contain at least one of the special characters (!@#$%^&*()-_+=<>?/{}[]|).";

                // Does not contain spaces
                if (password.Contains(" "))
                    return "Password does not contain white space.";

                // Does not start or end with a space
                if (password.First() == ' ' || password.Last() == ' ')
                    return "Password does not start or end with white space.";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "Valid";
        }

        #endregion
    }
}
