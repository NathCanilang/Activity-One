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
            this.removeBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.tableFormsBackground = new System.Windows.Forms.PictureBox();
            this.appbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableFormsBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // userAccountsTable
            // 
            this.userAccountsTable.AllowUserToAddRows = false;
            this.userAccountsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userAccountsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userAccountsTable.Location = new System.Drawing.Point(11, 39);
            this.userAccountsTable.Margin = new System.Windows.Forms.Padding(2);
            this.userAccountsTable.Name = "userAccountsTable";
            this.userAccountsTable.ReadOnly = true;
            this.userAccountsTable.RowHeadersWidth = 51;
            this.userAccountsTable.RowTemplate.Height = 24;
            this.userAccountsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userAccountsTable.Size = new System.Drawing.Size(574, 301);
            this.userAccountsTable.TabIndex = 0;
            // 
            // removeBtn
            // 
            this.removeBtn.Font = new System.Drawing.Font("Simple Handmade", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.Location = new System.Drawing.Point(597, 140);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(111, 39);
            this.removeBtn.TabIndex = 2;
            this.removeBtn.Text = "Reject";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Simple Handmade", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(597, 264);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(111, 39);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // tableFormsBackground
            // 
            this.tableFormsBackground.Image = global::ActivityNumber1.Properties.Resources.TUBA_OuterSpace;
            this.tableFormsBackground.Location = new System.Drawing.Point(0, -2);
            this.tableFormsBackground.Margin = new System.Windows.Forms.Padding(2);
            this.tableFormsBackground.Name = "tableFormsBackground";
            this.tableFormsBackground.Size = new System.Drawing.Size(754, 379);
            this.tableFormsBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tableFormsBackground.TabIndex = 6;
            this.tableFormsBackground.TabStop = false;
            // 
            // appbtn
            // 
            this.appbtn.Font = new System.Drawing.Font("Simple Handmade", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appbtn.Location = new System.Drawing.Point(597, 39);
            this.appbtn.Margin = new System.Windows.Forms.Padding(2);
            this.appbtn.Name = "appbtn";
            this.appbtn.Size = new System.Drawing.Size(111, 39);
            this.appbtn.TabIndex = 7;
            this.appbtn.Text = "Approve";
            this.appbtn.UseVisualStyleBackColor = true;
            this.appbtn.Click += new System.EventHandler(this.Approvebtn_Click);
            // 
            // TableForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 383);
            this.Controls.Add(this.appbtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.userAccountsTable);
            this.Controls.Add(this.tableFormsBackground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(770, 422);
            this.MinimumSize = new System.Drawing.Size(770, 422);
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
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.PictureBox tableFormsBackground;
        private System.Windows.Forms.Button appbtn;
    }
}