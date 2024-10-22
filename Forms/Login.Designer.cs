namespace UserCRUD.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.PictureBox();
            this.btnminimize = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimize)).BeginInit();
            this.SuspendLayout();
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(125, 315);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(116, 19);
            this.lblErrorMessage.TabIndex = 13;
            this.lblErrorMessage.Text = "Error Message";
            this.lblErrorMessage.Visible = false;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(85)))));
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(337, 363);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(125, 40);
            this.btnlogin.TabIndex = 11;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label1.Location = new System.Drawing.Point(279, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 49);
            this.label1.TabIndex = 12;
            this.label1.Text = "User Login";
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.txtpass.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.Black;
            this.txtpass.Location = new System.Drawing.Point(128, 269);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(547, 33);
            this.txtpass.TabIndex = 10;
            this.txtpass.Text = "Password";
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txtpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpass_KeyPress);
            this.txtpass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.txtuser.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.Color.Black;
            this.txtuser.Location = new System.Drawing.Point(128, 216);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(547, 33);
            this.txtuser.TabIndex = 9;
            this.txtuser.Text = "Username";
            this.txtuser.Enter += new System.EventHandler(this.txtuser_Enter);
            this.txtuser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtuser_KeyPress);
            this.txtuser.Leave += new System.EventHandler(this.txtuser_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.btnminimize);
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 53);
            this.panel1.TabIndex = 15;
            // 
            // btnclose
            // 
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(710, 11);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(29, 36);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnclose.TabIndex = 8;
            this.btnclose.TabStop = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnminimize
            // 
            this.btnminimize.Image = ((System.Drawing.Image)(resources.GetObject("btnminimize.Image")));
            this.btnminimize.Location = new System.Drawing.Point(672, 12);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(29, 36);
            this.btnminimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimize.TabIndex = 9;
            this.btnminimize.TabStop = false;
            this.btnminimize.Click += new System.EventHandler(this.btnminimize_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 494);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtpass;
        public System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnminimize;
        private System.Windows.Forms.PictureBox btnclose;
    }
}