namespace ActivityNumber1
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.loginBtn = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.createAccountLbl = new System.Windows.Forms.LinkLabel();
            this.forgotPasswordLbl = new System.Windows.Forms.LinkLabel();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.loginFormBackgroundPnl = new System.Windows.Forms.Panel();
            this.rememberCheckBox = new System.Windows.Forms.CheckBox();
            this.usernameComboBox = new System.Windows.Forms.ComboBox();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.showBtn = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.loginFormBackground = new System.Windows.Forms.PictureBox();
            this.loginFormBackgroundPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showBtn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginFormBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Simple Handmade", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(108, 315);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(204, 49);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Log-In";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(87)))), ((int)(((byte)(85)))));
            this.passwordTextBox.Font = new System.Drawing.Font("Simple Handmade", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(33, 216);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(288, 35);
            this.passwordTextBox.TabIndex = 2;
            // 
            // createAccountLbl
            // 
            this.createAccountLbl.AutoSize = true;
            this.createAccountLbl.Font = new System.Drawing.Font("Simple Handmade", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountLbl.Location = new System.Drawing.Point(210, 10);
            this.createAccountLbl.Name = "createAccountLbl";
            this.createAccountLbl.Size = new System.Drawing.Size(143, 25);
            this.createAccountLbl.TabIndex = 4;
            this.createAccountLbl.TabStop = true;
            this.createAccountLbl.Text = "Create Account";
            this.createAccountLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createAccountLbl_LinkClicked);
            // 
            // forgotPasswordLbl
            // 
            this.forgotPasswordLbl.AutoSize = true;
            this.forgotPasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPasswordLbl.Location = new System.Drawing.Point(176, 254);
            this.forgotPasswordLbl.Name = "forgotPasswordLbl";
            this.forgotPasswordLbl.Size = new System.Drawing.Size(145, 20);
            this.forgotPasswordLbl.TabIndex = 5;
            this.forgotPasswordLbl.TabStop = true;
            this.forgotPasswordLbl.Text = "Forgot Password?";
            this.forgotPasswordLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPasswordLbl_LinkClicked);
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Simple Handmade", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.ForeColor = System.Drawing.Color.White;
            this.usernameLbl.Location = new System.Drawing.Point(28, 96);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(119, 32);
            this.usernameLbl.TabIndex = 7;
            this.usernameLbl.Text = "Username";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Simple Handmade", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.ForeColor = System.Drawing.Color.White;
            this.passwordLbl.Location = new System.Drawing.Point(28, 175);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(118, 32);
            this.passwordLbl.TabIndex = 8;
            this.passwordLbl.Text = "Password";
            // 
            // loginFormBackgroundPnl
            // 
            this.loginFormBackgroundPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(87)))), ((int)(((byte)(85)))));
            this.loginFormBackgroundPnl.Controls.Add(this.rememberCheckBox);
            this.loginFormBackgroundPnl.Controls.Add(this.usernameComboBox);
            this.loginFormBackgroundPnl.Controls.Add(this.closeBtn);
            this.loginFormBackgroundPnl.Controls.Add(this.showBtn);
            this.loginFormBackgroundPnl.Controls.Add(this.panel1);
            this.loginFormBackgroundPnl.Controls.Add(this.passwordLbl);
            this.loginFormBackgroundPnl.Controls.Add(this.usernameLbl);
            this.loginFormBackgroundPnl.Controls.Add(this.forgotPasswordLbl);
            this.loginFormBackgroundPnl.Controls.Add(this.passwordTextBox);
            this.loginFormBackgroundPnl.Controls.Add(this.loginBtn);
            this.loginFormBackgroundPnl.Location = new System.Drawing.Point(584, 0);
            this.loginFormBackgroundPnl.MaximumSize = new System.Drawing.Size(421, 482);
            this.loginFormBackgroundPnl.MinimumSize = new System.Drawing.Size(421, 482);
            this.loginFormBackgroundPnl.Name = "loginFormBackgroundPnl";
            this.loginFormBackgroundPnl.Size = new System.Drawing.Size(421, 482);
            this.loginFormBackgroundPnl.TabIndex = 9;
            // 
            // rememberCheckBox
            // 
            this.rememberCheckBox.AutoSize = true;
            this.rememberCheckBox.Font = new System.Drawing.Font("Simple Handmade", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rememberCheckBox.ForeColor = System.Drawing.Color.White;
            this.rememberCheckBox.Location = new System.Drawing.Point(34, 257);
            this.rememberCheckBox.Name = "rememberCheckBox";
            this.rememberCheckBox.Size = new System.Drawing.Size(120, 23);
            this.rememberCheckBox.TabIndex = 13;
            this.rememberCheckBox.Text = "Remember me";
            this.rememberCheckBox.UseVisualStyleBackColor = true;
            // 
            // usernameComboBox
            // 
            this.usernameComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(87)))), ((int)(((byte)(85)))));
            this.usernameComboBox.Font = new System.Drawing.Font("Simple Handmade", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameComboBox.ForeColor = System.Drawing.Color.White;
            this.usernameComboBox.FormattingEnabled = true;
            this.usernameComboBox.Location = new System.Drawing.Point(34, 131);
            this.usernameComboBox.Name = "usernameComboBox";
            this.usernameComboBox.Size = new System.Drawing.Size(288, 31);
            this.usernameComboBox.TabIndex = 12;
            // 
            // closeBtn
            // 
            this.closeBtn.Image = global::ActivityNumber1.Properties.Resources.ClosePassword;
            this.closeBtn.Location = new System.Drawing.Point(327, 216);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(56, 35);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBtn.TabIndex = 11;
            this.closeBtn.TabStop = false;
            this.closeBtn.Visible = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // showBtn
            // 
            this.showBtn.Image = global::ActivityNumber1.Properties.Resources.ShowPassword;
            this.showBtn.Location = new System.Drawing.Point(327, 216);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(56, 35);
            this.showBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showBtn.TabIndex = 10;
            this.showBtn.TabStop = false;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.createAccountLbl);
            this.panel1.Location = new System.Drawing.Point(1, 434);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 45);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simple Handmade", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Account?";
            // 
            // loginFormBackground
            // 
            this.loginFormBackground.Image = global::ActivityNumber1.Properties.Resources.Moonbase_login3;
            this.loginFormBackground.Location = new System.Drawing.Point(0, 0);
            this.loginFormBackground.Name = "loginFormBackground";
            this.loginFormBackground.Size = new System.Drawing.Size(586, 477);
            this.loginFormBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginFormBackground.TabIndex = 6;
            this.loginFormBackground.TabStop = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 478);
            this.Controls.Add(this.loginFormBackground);
            this.Controls.Add(this.loginFormBackgroundPnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1021, 525);
            this.MinimumSize = new System.Drawing.Size(1021, 525);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Moonbase Login";
            this.loginFormBackgroundPnl.ResumeLayout(false);
            this.loginFormBackgroundPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginFormBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.LinkLabel createAccountLbl;
        private System.Windows.Forms.LinkLabel forgotPasswordLbl;
        private System.Windows.Forms.PictureBox loginFormBackground;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Panel loginFormBackgroundPnl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.PictureBox showBtn;
        private System.Windows.Forms.ComboBox usernameComboBox;
        //private CustomComboBox usernameComboBox;
        private System.Windows.Forms.CheckBox rememberCheckBox;
    }
}

