namespace ActivityNumber1
{
    partial class RecoveryForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecoveryForms));
            this.usernameTextBoxRF = new System.Windows.Forms.TextBox();
            this.emailTextBoxRF = new System.Windows.Forms.TextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.verifyBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.recoveryFormBackground2 = new System.Windows.Forms.PictureBox();
            this.recoveryFormBackground1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.recoveryFormBackground2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recoveryFormBackground1)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameTextBoxRF
            // 
            this.usernameTextBoxRF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(154)))), ((int)(((byte)(122)))));
            this.usernameTextBoxRF.Font = new System.Drawing.Font("Simple Handmade", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBoxRF.ForeColor = System.Drawing.Color.White;
            this.usernameTextBoxRF.Location = new System.Drawing.Point(130, 249);
            this.usernameTextBoxRF.Multiline = true;
            this.usernameTextBoxRF.Name = "usernameTextBoxRF";
            this.usernameTextBoxRF.Size = new System.Drawing.Size(267, 39);
            this.usernameTextBoxRF.TabIndex = 0;
            // 
            // emailTextBoxRF
            // 
            this.emailTextBoxRF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(154)))), ((int)(((byte)(122)))));
            this.emailTextBoxRF.Font = new System.Drawing.Font("Simple Handmade", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBoxRF.ForeColor = System.Drawing.Color.White;
            this.emailTextBoxRF.Location = new System.Drawing.Point(130, 294);
            this.emailTextBoxRF.Multiline = true;
            this.emailTextBoxRF.Name = "emailTextBoxRF";
            this.emailTextBoxRF.Size = new System.Drawing.Size(267, 39);
            this.emailTextBoxRF.TabIndex = 1;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.BackColor = System.Drawing.Color.White;
            this.usernameLbl.Font = new System.Drawing.Font("Simple Handmade", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.Location = new System.Drawing.Point(12, 249);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(119, 32);
            this.usernameLbl.TabIndex = 2;
            this.usernameLbl.Text = "Username";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.BackColor = System.Drawing.Color.White;
            this.emailLbl.Font = new System.Drawing.Font("Simple Handmade", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.Location = new System.Drawing.Point(54, 294);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(74, 32);
            this.emailLbl.TabIndex = 3;
            this.emailLbl.Text = "E-mail";
            // 
            // verifyBtn
            // 
            this.verifyBtn.BackColor = System.Drawing.Color.Black;
            this.verifyBtn.Font = new System.Drawing.Font("Simple Handmade", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyBtn.ForeColor = System.Drawing.Color.White;
            this.verifyBtn.Location = new System.Drawing.Point(128, 337);
            this.verifyBtn.Name = "verifyBtn";
            this.verifyBtn.Size = new System.Drawing.Size(129, 42);
            this.verifyBtn.TabIndex = 4;
            this.verifyBtn.Text = "Verify";
            this.verifyBtn.UseVisualStyleBackColor = false;
            this.verifyBtn.Click += new System.EventHandler(this.verifyBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Black;
            this.BackBtn.Font = new System.Drawing.Font("Simple Handmade", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(268, 337);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(129, 42);
            this.BackBtn.TabIndex = 5;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // recoveryFormBackground2
            // 
            this.recoveryFormBackground2.Image = global::ActivityNumber1.Properties.Resources.TUBA_ForgotPass;
            this.recoveryFormBackground2.Location = new System.Drawing.Point(0, 385);
            this.recoveryFormBackground2.Name = "recoveryFormBackground2";
            this.recoveryFormBackground2.Size = new System.Drawing.Size(420, 58);
            this.recoveryFormBackground2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.recoveryFormBackground2.TabIndex = 7;
            this.recoveryFormBackground2.TabStop = false;
            // 
            // recoveryFormBackground1
            // 
            this.recoveryFormBackground1.Image = global::ActivityNumber1.Properties.Resources.TUBA_Forgot;
            this.recoveryFormBackground1.Location = new System.Drawing.Point(0, -2);
            this.recoveryFormBackground1.Name = "recoveryFormBackground1";
            this.recoveryFormBackground1.Size = new System.Drawing.Size(420, 430);
            this.recoveryFormBackground1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.recoveryFormBackground1.TabIndex = 6;
            this.recoveryFormBackground1.TabStop = false;
            // 
            // RecoveryForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 440);
            this.Controls.Add(this.recoveryFormBackground2);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.verifyBtn);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.emailTextBoxRF);
            this.Controls.Add(this.usernameTextBoxRF);
            this.Controls.Add(this.recoveryFormBackground1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(437, 487);
            this.MinimumSize = new System.Drawing.Size(437, 487);
            this.Name = "RecoveryForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Recovery";
            this.Load += new System.EventHandler(this.RecoveryForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recoveryFormBackground2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recoveryFormBackground1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextBoxRF;
        private System.Windows.Forms.TextBox emailTextBoxRF;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Button verifyBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.PictureBox recoveryFormBackground1;
        private System.Windows.Forms.PictureBox recoveryFormBackground2;
    }
}