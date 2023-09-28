namespace ActivityNumber1
{
    partial class ResetPWForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Changebtn
            // 
            this.Changebtn.Location = new System.Drawing.Point(39, 165);
            this.Changebtn.Name = "Changebtn";
            this.Changebtn.Size = new System.Drawing.Size(75, 23);
            this.Changebtn.TabIndex = 0;
            this.Changebtn.Text = "Change";
            this.Changebtn.UseVisualStyleBackColor = true;
            this.Changebtn.Click += new System.EventHandler(this.Changebtn_Click);
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Location = new System.Drawing.Point(39, 97);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordtextBox.TabIndex = 2;
            this.passwordtextBox.TextChanged += new System.EventHandler(this.passwordtextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Set New Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ResetPWForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 364);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.Changebtn);
            this.Name = "ResetPWForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Reset";
            this.Load += new System.EventHandler(this.ResetPWForms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Changebtn;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.Label label1;
    }
}