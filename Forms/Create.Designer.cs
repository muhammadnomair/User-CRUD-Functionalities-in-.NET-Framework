namespace UserCRUD.Forms
{
    partial class Create
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelSignUpForm = new System.Windows.Forms.Panel();
            this.errorRole = new System.Windows.Forms.Label();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.errorEmail = new System.Windows.Forms.Label();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.errorAddress = new System.Windows.Forms.Label();
            this.btnSubmitUser = new System.Windows.Forms.Button();
            this.errorPassword = new System.Windows.Forms.Label();
            this.errorStatus = new System.Windows.Forms.Label();
            this.errorLastName = new System.Windows.Forms.Label();
            this.errorFirstName = new System.Windows.Forms.Label();
            this.errorUserName = new System.Windows.Forms.Label();
            this.lblSubmitUserError = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.panelUserDetails = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelPageBottom = new System.Windows.Forms.Panel();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.userDetailsByUserNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panelSignUpForm.SuspendLayout();
            this.panelUserDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panelPageBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDetailsByUserNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelSignUpForm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(1107, 313);
            this.panel2.TabIndex = 24;
            // 
            // panelSignUpForm
            // 
            this.panelSignUpForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panelSignUpForm.Controls.Add(this.errorRole);
            this.panelSignUpForm.Controls.Add(this.btnEditUser);
            this.panelSignUpForm.Controls.Add(this.errorEmail);
            this.panelSignUpForm.Controls.Add(this.btnDeleteUser);
            this.panelSignUpForm.Controls.Add(this.errorAddress);
            this.panelSignUpForm.Controls.Add(this.btnSubmitUser);
            this.panelSignUpForm.Controls.Add(this.errorPassword);
            this.panelSignUpForm.Controls.Add(this.errorStatus);
            this.panelSignUpForm.Controls.Add(this.errorLastName);
            this.panelSignUpForm.Controls.Add(this.errorFirstName);
            this.panelSignUpForm.Controls.Add(this.errorUserName);
            this.panelSignUpForm.Controls.Add(this.lblSubmitUserError);
            this.panelSignUpForm.Controls.Add(this.comboBoxRole);
            this.panelSignUpForm.Controls.Add(this.comboBoxStatus);
            this.panelSignUpForm.Controls.Add(this.txtPhone);
            this.panelSignUpForm.Controls.Add(this.txtPassword);
            this.panelSignUpForm.Controls.Add(this.txtEmail);
            this.panelSignUpForm.Controls.Add(this.txtLastName);
            this.panelSignUpForm.Controls.Add(this.txtFirstName);
            this.panelSignUpForm.Controls.Add(this.txtuser);
            this.panelSignUpForm.Location = new System.Drawing.Point(15, 14);
            this.panelSignUpForm.Name = "panelSignUpForm";
            this.panelSignUpForm.Size = new System.Drawing.Size(1077, 290);
            this.panelSignUpForm.TabIndex = 61;
            // 
            // errorRole
            // 
            this.errorRole.AutoSize = true;
            this.errorRole.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.errorRole.ForeColor = System.Drawing.Color.Red;
            this.errorRole.Location = new System.Drawing.Point(559, 144);
            this.errorRole.Name = "errorRole";
            this.errorRole.Size = new System.Drawing.Size(19, 19);
            this.errorRole.TabIndex = 93;
            this.errorRole.Text = "*";
            this.errorRole.Visible = false;
            // 
            // btnEditUser
            // 
            this.btnEditUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(48)))), ((int)(((byte)(90)))));
            this.btnEditUser.FlatAppearance.BorderSize = 0;
            this.btnEditUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnEditUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUser.ForeColor = System.Drawing.Color.White;
            this.btnEditUser.Location = new System.Drawing.Point(919, 225);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(117, 50);
            this.btnEditUser.TabIndex = 60;
            this.btnEditUser.Text = "Edit User";
            this.btnEditUser.UseVisualStyleBackColor = false;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // errorEmail
            // 
            this.errorEmail.AutoSize = true;
            this.errorEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.errorEmail.ForeColor = System.Drawing.Color.Red;
            this.errorEmail.Location = new System.Drawing.Point(559, 95);
            this.errorEmail.Name = "errorEmail";
            this.errorEmail.Size = new System.Drawing.Size(19, 19);
            this.errorEmail.TabIndex = 92;
            this.errorEmail.Text = "*";
            this.errorEmail.Visible = false;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(48)))), ((int)(((byte)(90)))));
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnDeleteUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Location = new System.Drawing.Point(784, 225);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(117, 50);
            this.btnDeleteUser.TabIndex = 55;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // errorAddress
            // 
            this.errorAddress.AutoSize = true;
            this.errorAddress.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.errorAddress.ForeColor = System.Drawing.Color.Red;
            this.errorAddress.Location = new System.Drawing.Point(559, 52);
            this.errorAddress.Name = "errorAddress";
            this.errorAddress.Size = new System.Drawing.Size(19, 19);
            this.errorAddress.TabIndex = 91;
            this.errorAddress.Text = "*";
            this.errorAddress.Visible = false;
            // 
            // btnSubmitUser
            // 
            this.btnSubmitUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmitUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(85)))));
            this.btnSubmitUser.FlatAppearance.BorderSize = 0;
            this.btnSubmitUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnSubmitUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSubmitUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitUser.ForeColor = System.Drawing.Color.White;
            this.btnSubmitUser.Location = new System.Drawing.Point(363, 225);
            this.btnSubmitUser.Name = "btnSubmitUser";
            this.btnSubmitUser.Size = new System.Drawing.Size(117, 50);
            this.btnSubmitUser.TabIndex = 54;
            this.btnSubmitUser.Text = "Submit";
            this.btnSubmitUser.UseVisualStyleBackColor = false;
            this.btnSubmitUser.Click += new System.EventHandler(this.btnSubmitUser_Click);
            // 
            // errorPassword
            // 
            this.errorPassword.AutoSize = true;
            this.errorPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.errorPassword.ForeColor = System.Drawing.Color.Red;
            this.errorPassword.Location = new System.Drawing.Point(559, 6);
            this.errorPassword.Name = "errorPassword";
            this.errorPassword.Size = new System.Drawing.Size(19, 19);
            this.errorPassword.TabIndex = 90;
            this.errorPassword.Text = "*";
            this.errorPassword.Visible = false;
            // 
            // errorStatus
            // 
            this.errorStatus.AutoSize = true;
            this.errorStatus.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.errorStatus.ForeColor = System.Drawing.Color.Red;
            this.errorStatus.Location = new System.Drawing.Point(14, 145);
            this.errorStatus.Name = "errorStatus";
            this.errorStatus.Size = new System.Drawing.Size(19, 19);
            this.errorStatus.TabIndex = 89;
            this.errorStatus.Text = "*";
            this.errorStatus.Visible = false;
            // 
            // errorLastName
            // 
            this.errorLastName.AutoSize = true;
            this.errorLastName.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.errorLastName.ForeColor = System.Drawing.Color.Red;
            this.errorLastName.Location = new System.Drawing.Point(14, 98);
            this.errorLastName.Name = "errorLastName";
            this.errorLastName.Size = new System.Drawing.Size(19, 19);
            this.errorLastName.TabIndex = 88;
            this.errorLastName.Text = "*";
            this.errorLastName.Visible = false;
            // 
            // errorFirstName
            // 
            this.errorFirstName.AutoSize = true;
            this.errorFirstName.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.errorFirstName.ForeColor = System.Drawing.Color.Red;
            this.errorFirstName.Location = new System.Drawing.Point(14, 55);
            this.errorFirstName.Name = "errorFirstName";
            this.errorFirstName.Size = new System.Drawing.Size(19, 19);
            this.errorFirstName.TabIndex = 87;
            this.errorFirstName.Text = "*";
            this.errorFirstName.Visible = false;
            // 
            // errorUserName
            // 
            this.errorUserName.AutoSize = true;
            this.errorUserName.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.errorUserName.ForeColor = System.Drawing.Color.Red;
            this.errorUserName.Location = new System.Drawing.Point(14, 6);
            this.errorUserName.Name = "errorUserName";
            this.errorUserName.Size = new System.Drawing.Size(19, 19);
            this.errorUserName.TabIndex = 86;
            this.errorUserName.Text = "*";
            this.errorUserName.Visible = false;
            // 
            // lblSubmitUserError
            // 
            this.lblSubmitUserError.AutoSize = true;
            this.lblSubmitUserError.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmitUserError.ForeColor = System.Drawing.Color.Red;
            this.lblSubmitUserError.Location = new System.Drawing.Point(35, 189);
            this.lblSubmitUserError.Name = "lblSubmitUserError";
            this.lblSubmitUserError.Size = new System.Drawing.Size(116, 19);
            this.lblSubmitUserError.TabIndex = 85;
            this.lblSubmitUserError.Text = "Error Message";
            this.lblSubmitUserError.Visible = false;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.comboBoxRole.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Super Admin",
            "Admin",
            "Installer"});
            this.comboBoxRole.Location = new System.Drawing.Point(584, 141);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(441, 29);
            this.comboBoxRole.TabIndex = 76;
            this.comboBoxRole.Text = "Role";
            this.comboBoxRole.Enter += new System.EventHandler(this.comboBoxRole_Enter);
            this.comboBoxRole.Leave += new System.EventHandler(this.comboBoxRole_Leave);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.comboBoxStatus.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Active",
            "Not Active"});
            this.comboBoxStatus.Location = new System.Drawing.Point(39, 142);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(441, 29);
            this.comboBoxStatus.TabIndex = 75;
            this.comboBoxStatus.Text = "Status";
            this.comboBoxStatus.Enter += new System.EventHandler(this.comboBoxStatus_Enter);
            this.comboBoxStatus.Leave += new System.EventHandler(this.comboBoxStatus_Leave);
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.txtPhone.Location = new System.Drawing.Point(584, 49);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(441, 28);
            this.txtPhone.TabIndex = 74;
            this.txtPhone.Text = "Phone";
            this.txtPhone.Enter += new System.EventHandler(this.txtPhone_Enter);
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.txtPassword.Location = new System.Drawing.Point(584, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(441, 28);
            this.txtPassword.TabIndex = 73;
            this.txtPassword.Text = "Password";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.txtEmail.Location = new System.Drawing.Point(584, 95);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(441, 28);
            this.txtEmail.TabIndex = 72;
            this.txtEmail.Text = "Email";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.txtLastName.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.txtLastName.Location = new System.Drawing.Point(39, 95);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(441, 28);
            this.txtLastName.TabIndex = 71;
            this.txtLastName.Text = "Last Name";
            this.txtLastName.Enter += new System.EventHandler(this.txtLastName_Enter);
            this.txtLastName.Leave += new System.EventHandler(this.txtLastName_Leave);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.txtFirstName.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.txtFirstName.Location = new System.Drawing.Point(39, 49);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(441, 28);
            this.txtFirstName.TabIndex = 70;
            this.txtFirstName.Text = "First Name";
            this.txtFirstName.Enter += new System.EventHandler(this.txtFirstName_Enter);
            this.txtFirstName.Leave += new System.EventHandler(this.txtFirstName_Leave);
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.txtuser.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.txtuser.Location = new System.Drawing.Point(39, 3);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(441, 28);
            this.txtuser.TabIndex = 69;
            this.txtuser.Text = "Username";
            this.txtuser.Enter += new System.EventHandler(this.txtuser_Enter);
            this.txtuser.Leave += new System.EventHandler(this.txtuser_Leave);
            // 
            // panelUserDetails
            // 
            this.panelUserDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUserDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panelUserDetails.Controls.Add(this.label4);
            this.panelUserDetails.Controls.Add(this.dataGridView1);
            this.panelUserDetails.Location = new System.Drawing.Point(16, 16);
            this.panelUserDetails.Name = "panelUserDetails";
            this.panelUserDetails.Size = new System.Drawing.Size(1079, 283);
            this.panelUserDetails.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 33);
            this.label4.TabIndex = 10;
            this.label4.Text = "User Details";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(49)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 55);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(49)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1073, 187);
            this.dataGridView1.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.panelUserDetails);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 313);
            this.panel4.Margin = new System.Windows.Forms.Padding(50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1107, 305);
            this.panel4.TabIndex = 27;
            // 
            // panelPageBottom
            // 
            this.panelPageBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panelPageBottom.Controls.Add(this.lblPageInfo);
            this.panelPageBottom.Controls.Add(this.btnNext);
            this.panelPageBottom.Controls.Add(this.btnPrevious);
            this.panelPageBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPageBottom.Location = new System.Drawing.Point(0, 577);
            this.panelPageBottom.Name = "panelPageBottom";
            this.panelPageBottom.Size = new System.Drawing.Size(1107, 41);
            this.panelPageBottom.TabIndex = 28;
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPageInfo.AutoSize = true;
            this.lblPageInfo.Location = new System.Drawing.Point(962, 14);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(35, 13);
            this.lblPageInfo.TabIndex = 75;
            this.lblPageInfo.Text = "label4";
            this.lblPageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(48)))), ((int)(((byte)(90)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(1026, 8);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(66, 25);
            this.btnNext.TabIndex = 73;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(48)))), ((int)(((byte)(90)))));
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.ForeColor = System.Drawing.Color.Transparent;
            this.btnPrevious.Location = new System.Drawing.Point(887, 8);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(66, 25);
            this.btnPrevious.TabIndex = 74;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // userDetailsByUserNameBindingSource
            // 
            this.userDetailsByUserNameBindingSource.DataSource = typeof(UserCRUD.Domain.Models.UserDetailsByUserName);
            // 
            // userDetailsBindingSource
            // 
            this.userDetailsBindingSource.DataSource = typeof(UserCRUD.Domain.Models.UserDetails);
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 618);
            this.Controls.Add(this.panelPageBottom);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "Create";
            this.Text = "Create";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Create_FormClosed);
            this.Load += new System.EventHandler(this.Create_Load);
            this.panel2.ResumeLayout(false);
            this.panelSignUpForm.ResumeLayout(false);
            this.panelSignUpForm.PerformLayout();
            this.panelUserDetails.ResumeLayout(false);
            this.panelUserDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panelPageBottom.ResumeLayout(false);
            this.panelPageBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDetailsByUserNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelSignUpForm;
        private System.Windows.Forms.Label errorRole;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Label errorEmail;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Label errorAddress;
        private System.Windows.Forms.Button btnSubmitUser;
        private System.Windows.Forms.Label errorPassword;
        private System.Windows.Forms.Label errorStatus;
        private System.Windows.Forms.Label errorLastName;
        private System.Windows.Forms.Label errorFirstName;
        private System.Windows.Forms.Label errorUserName;
        private System.Windows.Forms.Label lblSubmitUserError;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        public System.Windows.Forms.TextBox txtPhone;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtLastName;
        public System.Windows.Forms.TextBox txtFirstName;
        public System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Panel panelUserDetails;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelPageBottom;
        private System.Windows.Forms.Label lblPageInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.BindingSource userDetailsByUserNameBindingSource;
        private System.Windows.Forms.BindingSource userDetailsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
    }
}