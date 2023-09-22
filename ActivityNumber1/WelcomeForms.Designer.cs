namespace ActivityNumber1
{
    partial class WelcomeForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForms));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BackLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ActivityNumber1.Properties.Resources.TUBA_Greetings;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1036, 499);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BackLbl
            // 
            this.BackLbl.AutoSize = true;
            this.BackLbl.BackColor = System.Drawing.Color.Transparent;
            this.BackLbl.Font = new System.Drawing.Font("Simple Handmade", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackLbl.ForeColor = System.Drawing.Color.White;
            this.BackLbl.Location = new System.Drawing.Point(11, 112);
            this.BackLbl.Name = "BackLbl";
            this.BackLbl.Size = new System.Drawing.Size(92, 48);
            this.BackLbl.TabIndex = 1;
            this.BackLbl.Text = "Back";
            this.BackLbl.Click += new System.EventHandler(this.BackLbl_Click);
            // 
            // WelcomeForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 497);
            this.Controls.Add(this.BackLbl);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1051, 544);
            this.MinimumSize = new System.Drawing.Size(1051, 544);
            this.Name = "WelcomeForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.WelcomeForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label BackLbl;
    }
}