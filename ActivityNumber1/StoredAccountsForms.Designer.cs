namespace ActivityNumber1
{
    partial class StoredAccountsForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoredAccountsForms));
            this.storedAccTable = new System.Windows.Forms.DataGridView();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.storedFormBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.storedAccTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storedFormBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // storedAccTable
            // 
            this.storedAccTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.storedAccTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storedAccTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameCol,
            this.ageCol,
            this.genderCol,
            this.usernameCol,
            this.passwordCol,
            this.emailCol});
            this.storedAccTable.Location = new System.Drawing.Point(38, 31);
            this.storedAccTable.Name = "storedAccTable";
            this.storedAccTable.RowHeadersWidth = 51;
            this.storedAccTable.RowTemplate.Height = 24;
            this.storedAccTable.Size = new System.Drawing.Size(929, 334);
            this.storedAccTable.TabIndex = 0;
            // 
            // nameCol
            // 
            this.nameCol.HeaderText = "Full Name";
            this.nameCol.MinimumWidth = 6;
            this.nameCol.Name = "nameCol";
            // 
            // ageCol
            // 
            this.ageCol.HeaderText = "Age";
            this.ageCol.MinimumWidth = 6;
            this.ageCol.Name = "ageCol";
            // 
            // genderCol
            // 
            this.genderCol.HeaderText = "Gender";
            this.genderCol.MinimumWidth = 6;
            this.genderCol.Name = "genderCol";
            // 
            // usernameCol
            // 
            this.usernameCol.HeaderText = "Username";
            this.usernameCol.MinimumWidth = 6;
            this.usernameCol.Name = "usernameCol";
            // 
            // passwordCol
            // 
            this.passwordCol.HeaderText = "Password";
            this.passwordCol.MinimumWidth = 6;
            this.passwordCol.Name = "passwordCol";
            this.passwordCol.Visible = false;
            // 
            // emailCol
            // 
            this.emailCol.HeaderText = "E-mail";
            this.emailCol.MinimumWidth = 6;
            this.emailCol.Name = "emailCol";
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Simple Handmade", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(211, 392);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(148, 48);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Simple Handmade", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(653, 392);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(148, 48);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // storedFormBackground
            // 
            this.storedFormBackground.Image = global::ActivityNumber1.Properties.Resources.TUBA_OuterSpace;
            this.storedFormBackground.Location = new System.Drawing.Point(0, -1);
            this.storedFormBackground.Name = "storedFormBackground";
            this.storedFormBackground.Size = new System.Drawing.Size(1004, 465);
            this.storedFormBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.storedFormBackground.TabIndex = 3;
            this.storedFormBackground.TabStop = false;
            // 
            // StoredAccountsForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 463);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.storedAccTable);
            this.Controls.Add(this.storedFormBackground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1021, 510);
            this.MinimumSize = new System.Drawing.Size(1021, 510);
            this.Name = "StoredAccountsForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stored Accounts";
            this.Load += new System.EventHandler(this.StoredAccountsForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storedAccTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storedFormBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView storedAccTable;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailCol;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.PictureBox storedFormBackground;
    }
}