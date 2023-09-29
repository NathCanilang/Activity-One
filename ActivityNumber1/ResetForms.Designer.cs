namespace ActivityNumber1
{
    partial class ResetForms
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
            this.Changebtn = new System.Windows.Forms.Button();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.newpasslbl = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.showBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newpasstextBox = new System.Windows.Forms.TextBox();
            this.showBtn1 = new System.Windows.Forms.PictureBox();
            this.closeBtn1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showBtn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Changebtn
            // 
            this.Changebtn.BackColor = System.Drawing.Color.Black;
            this.Changebtn.Font = new System.Drawing.Font("Simple Handmade", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Changebtn.ForeColor = System.Drawing.Color.White;
            this.Changebtn.Location = new System.Drawing.Point(173, 288);
            this.Changebtn.Name = "Changebtn";
            this.Changebtn.Size = new System.Drawing.Size(97, 34);
            this.Changebtn.TabIndex = 0;
            this.Changebtn.Text = "Change";
            this.Changebtn.UseVisualStyleBackColor = false;
            this.Changebtn.Click += new System.EventHandler(this.Changebtn_Click);
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Font = new System.Drawing.Font("Simple Handmade", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtextBox.Location = new System.Drawing.Point(173, 209);
            this.passwordtextBox.Multiline = true;
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.PasswordChar = '*';
            this.passwordtextBox.Size = new System.Drawing.Size(170, 32);
            this.passwordtextBox.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(276, 301);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(100, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "common passwords";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // newpasslbl
            // 
            this.newpasslbl.AutoSize = true;
            this.newpasslbl.BackColor = System.Drawing.Color.White;
            this.newpasslbl.Font = new System.Drawing.Font("Simple Handmade", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpasslbl.Location = new System.Drawing.Point(37, 209);
            this.newpasslbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newpasslbl.Name = "newpasslbl";
            this.newpasslbl.Size = new System.Drawing.Size(131, 25);
            this.newpasslbl.TabIndex = 3;
            this.newpasslbl.Text = "New Password";
            // 
            // closeBtn
            // 
            this.closeBtn.Image = global::ActivityNumber1.Properties.Resources.ClosePassword;
            this.closeBtn.Location = new System.Drawing.Point(343, 209);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(42, 32);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBtn.TabIndex = 12;
            this.closeBtn.TabStop = false;
            this.closeBtn.Visible = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // showBtn
            // 
            this.showBtn.Image = global::ActivityNumber1.Properties.Resources.ShowPassword;
            this.showBtn.Location = new System.Drawing.Point(343, 209);
            this.showBtn.Margin = new System.Windows.Forms.Padding(2);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(42, 32);
            this.showBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showBtn.TabIndex = 13;
            this.showBtn.TabStop = false;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Simple Handmade", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 256);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Re-enter Password";
            // 
            // newpasstextBox
            // 
            this.newpasstextBox.Font = new System.Drawing.Font("Simple Handmade", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpasstextBox.Location = new System.Drawing.Point(173, 250);
            this.newpasstextBox.Multiline = true;
            this.newpasstextBox.Name = "newpasstextBox";
            this.newpasstextBox.PasswordChar = '*';
            this.newpasstextBox.Size = new System.Drawing.Size(170, 32);
            this.newpasstextBox.TabIndex = 15;
            this.newpasstextBox.TextChanged += new System.EventHandler(this.newpasstextBox_TextChanged);
            // 
            // showBtn1
            // 
            this.showBtn1.Image = global::ActivityNumber1.Properties.Resources.ShowPassword;
            this.showBtn1.Location = new System.Drawing.Point(343, 250);
            this.showBtn1.Margin = new System.Windows.Forms.Padding(2);
            this.showBtn1.Name = "showBtn1";
            this.showBtn1.Size = new System.Drawing.Size(42, 32);
            this.showBtn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showBtn1.TabIndex = 16;
            this.showBtn1.TabStop = false;
            this.showBtn1.Click += new System.EventHandler(this.showBtn1_Click);
            // 
            // closeBtn1
            // 
            this.closeBtn1.Image = global::ActivityNumber1.Properties.Resources.ClosePassword;
            this.closeBtn1.Location = new System.Drawing.Point(343, 250);
            this.closeBtn1.Margin = new System.Windows.Forms.Padding(2);
            this.closeBtn1.Name = "closeBtn1";
            this.closeBtn1.Size = new System.Drawing.Size(42, 32);
            this.closeBtn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBtn1.TabIndex = 17;
            this.closeBtn1.TabStop = false;
            this.closeBtn1.Visible = false;
            this.closeBtn1.Click += new System.EventHandler(this.closeBtn1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 333);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // ResetForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 328);
            this.Controls.Add(this.closeBtn1);
            this.Controls.Add(this.newpasstextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.newpasslbl);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.Changebtn);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.showBtn1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ResetForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Reset";
            this.Load += new System.EventHandler(this.ResetForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showBtn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Changebtn;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label newpasslbl;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.PictureBox showBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newpasstextBox;
        private System.Windows.Forms.PictureBox showBtn1;
        private System.Windows.Forms.PictureBox closeBtn1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}