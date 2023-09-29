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
            this.loginBtn.Location = new System.Drawing.Point(81, 256);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(153, 40);
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
            this.passwordTextBox.Location = new System.Drawing.Point(25, 176);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(217, 29);
            this.passwordTextBox.TabIndex = 2;
            // 
            // createAccountLbl
            // 
            this.createAccountLbl.AutoSize = true;
            this.createAccountLbl.Font = new System.Drawing.Font("Simple Handmade", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountLbl.Location = new System.Drawing.Point(158, 8);
            this.createAccountLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.createAccountLbl.Name = "createAccountLbl";
            this.createAccountLbl.Size = new System.Drawing.Size(117, 21);
            this.createAccountLbl.TabIndex = 4;
            this.createAccountLbl.TabStop = true;
            this.createAccountLbl.Text = "Create Account";
            this.createAccountLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createAccountLbl_LinkClicked);
            // 
            // forgotPasswordLbl
            // 
            this.forgotPasswordLbl.AutoSize = true;
            this.forgotPasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPasswordLbl.Location = new System.Drawing.Point(132, 206);
            this.forgotPasswordLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.forgotPasswordLbl.Name = "forgotPasswordLbl";
            this.forgotPasswordLbl.Size = new System.Drawing.Size(122, 17);
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
            this.usernameLbl.Location = new System.Drawing.Point(21, 78);
            this.usernameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(94, 25);
            this.usernameLbl.TabIndex = 7;
            this.usernameLbl.Text = "Username";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Simple Handmade", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.ForeColor = System.Drawing.Color.White;
            this.passwordLbl.Location = new System.Drawing.Point(21, 142);
            this.passwordLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(91, 25);
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
            this.loginFormBackgroundPnl.Location = new System.Drawing.Point(438, 0);
            this.loginFormBackgroundPnl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginFormBackgroundPnl.MaximumSize = new System.Drawing.Size(316, 392);
            this.loginFormBackgroundPnl.MinimumSize = new System.Drawing.Size(316, 392);
            this.loginFormBackgroundPnl.Name = "loginFormBackgroundPnl";
            this.loginFormBackgroundPnl.Size = new System.Drawing.Size(316, 392);
            this.loginFormBackgroundPnl.TabIndex = 9;
            // 
            // rememberCheckBox
            // 
            this.rememberCheckBox.AutoSize = true;
            this.rememberCheckBox.Font = new System.Drawing.Font("Simple Handmade", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rememberCheckBox.ForeColor = System.Drawing.Color.White;
            this.rememberCheckBox.Location = new System.Drawing.Point(26, 209);
            this.rememberCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rememberCheckBox.Name = "rememberCheckBox";
            this.rememberCheckBox.Size = new System.Drawing.Size(101, 20);
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
            this.usernameComboBox.Location = new System.Drawing.Point(26, 106);
            this.usernameComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameComboBox.Name = "usernameComboBox";
            this.usernameComboBox.Size = new System.Drawing.Size(217, 26);
            this.usernameComboBox.TabIndex = 12;
            // 
            // closeBtn
            // 
            this.closeBtn.Image = global::ActivityNumber1.Properties.Resources.ClosePassword;
            this.closeBtn.Location = new System.Drawing.Point(245, 176);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(42, 28);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBtn.TabIndex = 11;
            this.closeBtn.TabStop = false;
            this.closeBtn.Visible = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // showBtn
            // 
            this.showBtn.Image = global::ActivityNumber1.Properties.Resources.ShowPassword;
            this.showBtn.Location = new System.Drawing.Point(245, 176);
            this.showBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(42, 28);
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
            this.panel1.Location = new System.Drawing.Point(1, 353);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 37);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simple Handmade", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Account?";
            // 
            // loginFormBackground
            // 
            this.loginFormBackground.Image = global::ActivityNumber1.Properties.Resources.Moonbase_login3;
            this.loginFormBackground.Location = new System.Drawing.Point(0, 0);
            this.loginFormBackground.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginFormBackground.Name = "loginFormBackground";
            this.loginFormBackground.Size = new System.Drawing.Size(440, 388);
            this.loginFormBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginFormBackground.TabIndex = 6;
            this.loginFormBackground.TabStop = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 395);
            this.Controls.Add(this.loginFormBackground);
            this.Controls.Add(this.loginFormBackgroundPnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(770, 434);
            this.MinimumSize = new System.Drawing.Size(770, 434);
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

