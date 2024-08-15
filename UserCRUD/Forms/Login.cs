using System;
using System.Drawing;
using UserCRUD.Helpers;
using System.Windows.Forms;
using UserCRUD.Domain.Models;
using System.Runtime.InteropServices;
using UserCRUD.Domain.Services.Abstraction;


namespace UserCRUD.Forms
{
    public partial class Login : Form
    {
        //Private Properties
        #region

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        #endregion
        public Login()
        {
            InitializeComponent();
        }

        //Events Handling
        #region
        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtuser.Text != "Username")
                {
                    if (txtpass.Text != "Password")
                    {
                        UserDataLogic userModel = new UserDataLogic();

                        if (userModel.ReadUserData(txtuser.Text) == true)
                        {
                            string hashedPassword = Hashing.GenerateHashPassword(txtpass.Text, Users.SaltKey);
                            if (Users.Password == hashedPassword)
                            {
                                Create create = new Create();
                                create.Show();
                                this.Hide();
                            }
                            else
                            {
                                mesasgeError("Incorrect password!\nPlease try again.");
                                txtpass.Clear();
                                txtuser.Focus();
                            }
                        }
                        else
                        {
                            mesasgeError("Incorrect username and password!\nPlease try again.");
                            txtpass.Clear();
                            txtuser.Focus();
                        }
                    }
                    else
                    {
                        mesasgeError("Please Enter password!");
                    }
                }
                else
                {
                    mesasgeError("Please Enter username!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred:\n{ex.Message}", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Password")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Password";
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);// Exi the current Process
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnlogin.PerformClick();
            }
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnlogin.PerformClick();
            }
        }

        #endregion

        //Private Methods
        #region

        private void mesasgeError(string message)
        {
            lblErrorMessage.Text = message;
            lblErrorMessage.Visible = true;
        }

        public void Logout()
        {
            txtpass.Text = "Password";
            txtuser.Text = "Username";
            txtpass.ForeColor = Color.LightGray;
            txtuser.ForeColor = Color.LightGray;
            lblErrorMessage.Visible = false;
            this.Show();
        }

        #endregion
    }
}
