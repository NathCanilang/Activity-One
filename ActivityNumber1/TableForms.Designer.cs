namespace ActivityNumber1
{
    partial class TableForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableForms));
            this.userAccountsTable = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvalBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.storedAccBtn = new System.Windows.Forms.Button();
            this.tableFormsBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableFormsBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // userAccountsTable
            // 
            this.userAccountsTable.AllowUserToAddRows = false;
            this.userAccountsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userAccountsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userAccountsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.ageColumn,
            this.genderColumn,
            this.usernameColumn,
            this.passwordColumn,
            this.emailColumn});
            this.userAccountsTable.Location = new System.Drawing.Point(57, 48);
            this.userAccountsTable.Name = "userAccountsTable";
            this.userAccountsTable.ReadOnly = true;
            this.userAccountsTable.RowHeadersWidth = 51;
            this.userAccountsTable.RowTemplate.Height = 24;
            this.userAccountsTable.Size = new System.Drawing.Size(723, 370);
            this.userAccountsTable.TabIndex = 0;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Full Name";
            this.nameColumn.MinimumWidth = 6;
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // ageColumn
            // 
            this.ageColumn.HeaderText = "Age";
            this.ageColumn.MinimumWidth = 6;
            this.ageColumn.Name = "ageColumn";
            this.ageColumn.ReadOnly = true;
            // 
            // genderColumn
            // 
            this.genderColumn.HeaderText = "Gender";
            this.genderColumn.MinimumWidth = 6;
            this.genderColumn.Name = "genderColumn";
            this.genderColumn.ReadOnly = true;
            // 
            // usernameColumn
            // 
            this.usernameColumn.HeaderText = "Username";
            this.usernameColumn.MinimumWidth = 6;
            this.usernameColumn.Name = "usernameColumn";
            this.usernameColumn.ReadOnly = true;
            // 
            // passwordColumn
            // 
            this.passwordColumn.HeaderText = "Password";
            this.passwordColumn.MinimumWidth = 6;
            this.passwordColumn.Name = "passwordColumn";
            this.passwordColumn.ReadOnly = true;
            this.passwordColumn.Visible = false;
            // 
            // emailColumn
            // 
            this.emailColumn.HeaderText = "E-mail";
            this.emailColumn.MinimumWidth = 6;
            this.emailColumn.Name = "emailColumn";
            this.emailColumn.ReadOnly = true;
            // 
            // approvalBtn
            // 
            this.approvalBtn.Font = new System.Drawing.Font("Simple Handmade", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approvalBtn.Location = new System.Drawing.Point(796, 48);
            this.approvalBtn.Name = "approvalBtn";
            this.approvalBtn.Size = new System.Drawing.Size(148, 48);
            this.approvalBtn.TabIndex = 1;
            this.approvalBtn.Text = "Approve";
            this.approvalBtn.UseVisualStyleBackColor = true;
            this.approvalBtn.Click += new System.EventHandler(this.approvalBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Font = new System.Drawing.Font("Simple Handmade", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.Location = new System.Drawing.Point(796, 154);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(148, 48);
            this.removeBtn.TabIndex = 2;
            this.removeBtn.Text = "Reject";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Simple Handmade", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(796, 370);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(148, 48);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // storedAccBtn
            // 
            this.storedAccBtn.Font = new System.Drawing.Font("Simple Handmade", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storedAccBtn.Location = new System.Drawing.Point(796, 265);
            this.storedAccBtn.Name = "storedAccBtn";
            this.storedAccBtn.Size = new System.Drawing.Size(148, 48);
            this.storedAccBtn.TabIndex = 5;
            this.storedAccBtn.Text = "Stored Accounts";
            this.storedAccBtn.UseVisualStyleBackColor = true;
            this.storedAccBtn.Click += new System.EventHandler(this.storedAccBtn_Click);
            // 
            // tableFormsBackground
            // 
            this.tableFormsBackground.Image = global::ActivityNumber1.Properties.Resources.TUBA_OuterSpace;
            this.tableFormsBackground.Location = new System.Drawing.Point(0, -2);
            this.tableFormsBackground.Name = "tableFormsBackground";
            this.tableFormsBackground.Size = new System.Drawing.Size(1005, 467);
            this.tableFormsBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tableFormsBackground.TabIndex = 6;
            this.tableFormsBackground.TabStop = false;
            // 
            // TableForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 463);
            this.Controls.Add(this.storedAccBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.approvalBtn);
            this.Controls.Add(this.userAccountsTable);
            this.Controls.Add(this.tableFormsBackground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1021, 510);
            this.MinimumSize = new System.Drawing.Size(1021, 510);
            this.Name = "TableForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Account Control";
            this.Load += new System.EventHandler(this.TableForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userAccountsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableFormsBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView userAccountsTable;
        private System.Windows.Forms.Button approvalBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailColumn;
        private System.Windows.Forms.Button storedAccBtn;
        private System.Windows.Forms.PictureBox tableFormsBackground;
    }
}