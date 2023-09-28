using System.Drawing;

namespace ActivityNumber1
{
    partial class CreateForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateForms));
            this.nameTextBoxCF = new System.Windows.Forms.TextBox();
            this.ageTextBoxCF = new System.Windows.Forms.TextBox();
            this.usernameTextBoxCF = new System.Windows.Forms.TextBox();
            this.passwordTextBoxCF = new System.Windows.Forms.TextBox();
            this.emailTextBoxCF = new System.Windows.Forms.TextBox();
            this.createBtnCF = new System.Windows.Forms.Button();
            this.showPasswordCF = new System.Windows.Forms.CheckBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.backBtnCF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ageLbl = new System.Windows.Forms.Label();
            this.genderLbl = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.createFormsBackPic = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.createFormsBackPic)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBoxCF
            // 
            this.nameTextBoxCF.Font = new System.Drawing.Font("Simple Handmade", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBoxCF.Location = new System.Drawing.Point(433, 54);
            this.nameTextBoxCF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameTextBoxCF.Multiline = true;
            this.nameTextBoxCF.Name = "nameTextBoxCF";
            this.nameTextBoxCF.Size = new System.Drawing.Size(192, 28);
            this.nameTextBoxCF.TabIndex = 0;
            this.nameTextBoxCF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextBoxCF_KeyPress);
            // 
            // ageTextBoxCF
            // 
            this.ageTextBoxCF.Font = new System.Drawing.Font("Simple Handmade", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageTextBoxCF.Location = new System.Drawing.Point(433, 114);
            this.ageTextBoxCF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ageTextBoxCF.Multiline = true;
            this.ageTextBoxCF.Name = "ageTextBoxCF";
            this.ageTextBoxCF.Size = new System.Drawing.Size(92, 28);
            this.ageTextBoxCF.TabIndex = 1;
            this.ageTextBoxCF.TextChanged += new System.EventHandler(this.ageTextBoxCF_TextChanged);
            this.ageTextBoxCF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ageTextBoxCF_KeyPress);
            // 
            // usernameTextBoxCF
            // 
            this.usernameTextBoxCF.Font = new System.Drawing.Font("Simple Handmade", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBoxCF.Location = new System.Drawing.Point(433, 171);
            this.usernameTextBoxCF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameTextBoxCF.Multiline = true;
            this.usernameTextBoxCF.Name = "usernameTextBoxCF";
            this.usernameTextBoxCF.Size = new System.Drawing.Size(192, 28);
            this.usernameTextBoxCF.TabIndex = 2;
            // 
            // passwordTextBoxCF
            // 
            this.passwordTextBoxCF.Font = new System.Drawing.Font("Simple Handmade", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBoxCF.Location = new System.Drawing.Point(433, 229);
            this.passwordTextBoxCF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordTextBoxCF.Multiline = true;
            this.passwordTextBoxCF.Name = "passwordTextBoxCF";
            this.passwordTextBoxCF.PasswordChar = '*';
            this.passwordTextBoxCF.Size = new System.Drawing.Size(192, 28);
            this.passwordTextBoxCF.TabIndex = 3;
            // 
            // emailTextBoxCF
            // 
            this.emailTextBoxCF.Font = new System.Drawing.Font("Simple Handmade", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBoxCF.Location = new System.Drawing.Point(433, 301);
            this.emailTextBoxCF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailTextBoxCF.Multiline = true;
            this.emailTextBoxCF.Name = "emailTextBoxCF";
            this.emailTextBoxCF.Size = new System.Drawing.Size(192, 28);
            this.emailTextBoxCF.TabIndex = 4;
            // 
            // createBtnCF
            // 
            this.createBtnCF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(87)))), ((int)(((byte)(85)))));
            this.createBtnCF.Font = new System.Drawing.Font("Simple Handmade", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtnCF.ForeColor = System.Drawing.Color.White;
            this.createBtnCF.Location = new System.Drawing.Point(433, 334);
            this.createBtnCF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createBtnCF.Name = "createBtnCF";
            this.createBtnCF.Size = new System.Drawing.Size(100, 32);
            this.createBtnCF.TabIndex = 7;
            this.createBtnCF.Text = "Create Account";
            this.createBtnCF.UseVisualStyleBackColor = false;
            this.createBtnCF.Click += new System.EventHandler(this.createBtnCF_Click);
            // 
            // showPasswordCF
            // 
            this.showPasswordCF.AutoSize = true;
            this.showPasswordCF.BackColor = System.Drawing.Color.Transparent;
            this.showPasswordCF.Font = new System.Drawing.Font("Simple Handmade", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPasswordCF.ForeColor = System.Drawing.Color.White;
            this.showPasswordCF.Location = new System.Drawing.Point(433, 257);
            this.showPasswordCF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showPasswordCF.Name = "showPasswordCF";
            this.showPasswordCF.Size = new System.Drawing.Size(108, 20);
            this.showPasswordCF.TabIndex = 8;
            this.showPasswordCF.Text = "Show Password";
            this.showPasswordCF.UseVisualStyleBackColor = false;
            this.showPasswordCF.CheckedChanged += new System.EventHandler(this.showPasswordCF_CheckedChanged);
            // 
            // genderComboBox
            // 
            this.genderComboBox.Font = new System.Drawing.Font("Simple Handmade", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(533, 114);
            this.genderComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(92, 28);
            this.genderComboBox.TabIndex = 9;
            this.genderComboBox.SelectedIndexChanged += new System.EventHandler(this.genderComboBox_SelectedIndexChanged);
            // 
            // backBtnCF
            // 
            this.backBtnCF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(87)))), ((int)(((byte)(85)))));
            this.backBtnCF.Font = new System.Drawing.Font("Simple Handmade", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtnCF.ForeColor = System.Drawing.Color.White;
            this.backBtnCF.Location = new System.Drawing.Point(537, 334);
            this.backBtnCF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backBtnCF.Name = "backBtnCF";
            this.backBtnCF.Size = new System.Drawing.Size(87, 32);
            this.backBtnCF.TabIndex = 10;
            this.backBtnCF.Text = "Back";
            this.backBtnCF.UseVisualStyleBackColor = false;
            this.backBtnCF.Click += new System.EventHandler(this.backBtnCF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Simple Handmade", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(428, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Full Name";
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.BackColor = System.Drawing.Color.Transparent;
            this.ageLbl.Font = new System.Drawing.Font("Simple Handmade", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLbl.ForeColor = System.Drawing.Color.White;
            this.ageLbl.Location = new System.Drawing.Point(429, 85);
            this.ageLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(42, 25);
            this.ageLbl.TabIndex = 12;
            this.ageLbl.Text = "Age";
            // 
            // genderLbl
            // 
            this.genderLbl.AutoSize = true;
            this.genderLbl.BackColor = System.Drawing.Color.Transparent;
            this.genderLbl.Font = new System.Drawing.Font("Simple Handmade", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLbl.ForeColor = System.Drawing.Color.White;
            this.genderLbl.Location = new System.Drawing.Point(530, 85);
            this.genderLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(69, 25);
            this.genderLbl.TabIndex = 13;
            this.genderLbl.Text = "Gender";
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.BackColor = System.Drawing.Color.Transparent;
            this.usernameLbl.Font = new System.Drawing.Font("Simple Handmade", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.ForeColor = System.Drawing.Color.White;
            this.usernameLbl.Location = new System.Drawing.Point(429, 144);
            this.usernameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(94, 25);
            this.usernameLbl.TabIndex = 14;
            this.usernameLbl.Text = "Username";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.BackColor = System.Drawing.Color.Transparent;
            this.passwordLbl.Font = new System.Drawing.Font("Simple Handmade", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.ForeColor = System.Drawing.Color.White;
            this.passwordLbl.Location = new System.Drawing.Point(430, 202);
            this.passwordLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(91, 25);
            this.passwordLbl.TabIndex = 15;
            this.passwordLbl.Text = "Password";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.BackColor = System.Drawing.Color.Transparent;
            this.emailLbl.Font = new System.Drawing.Font("Simple Handmade", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.ForeColor = System.Drawing.Color.White;
            this.emailLbl.Location = new System.Drawing.Point(429, 274);
            this.emailLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(59, 25);
            this.emailLbl.TabIndex = 16;
            this.emailLbl.Text = "E-mail";
            // 
            // createFormsBackPic
            // 
            this.createFormsBackPic.Image = global::ActivityNumber1.Properties.Resources.Create_Forms_Background;
            this.createFormsBackPic.Location = new System.Drawing.Point(0, 0);
            this.createFormsBackPic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createFormsBackPic.Name = "createFormsBackPic";
            this.createFormsBackPic.Size = new System.Drawing.Size(759, 405);
            this.createFormsBackPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.createFormsBackPic.TabIndex = 17;
            this.createFormsBackPic.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Simple Handmade", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(551, 306);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "@gmail.com";
            // 
            // CreateForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 406);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.genderLbl);
            this.Controls.Add(this.ageLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtnCF);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.showPasswordCF);
            this.Controls.Add(this.createBtnCF);
            this.Controls.Add(this.emailTextBoxCF);
            this.Controls.Add(this.passwordTextBoxCF);
            this.Controls.Add(this.usernameTextBoxCF);
            this.Controls.Add(this.ageTextBoxCF);
            this.Controls.Add(this.nameTextBoxCF);
            this.Controls.Add(this.createFormsBackPic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(770, 445);
            this.MinimumSize = new System.Drawing.Size(770, 445);
            this.Name = "CreateForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Moonbase Account Creation";
            this.Load += new System.EventHandler(this.CreateForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.createFormsBackPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBoxCF;
        private System.Windows.Forms.TextBox ageTextBoxCF;
        private System.Windows.Forms.TextBox usernameTextBoxCF;
        private System.Windows.Forms.TextBox passwordTextBoxCF;
        private System.Windows.Forms.TextBox emailTextBoxCF;
        private System.Windows.Forms.Button createBtnCF;
        private System.Windows.Forms.CheckBox showPasswordCF;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Button backBtnCF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.Label genderLbl;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.PictureBox createFormsBackPic;
        private System.Windows.Forms.Label label2;
    }
}