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
            this.approvalBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.tableFormsBackground = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.refreshBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableFormsBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(723, 370);
            this.dataGridView1.TabIndex = 7;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Font = new System.Drawing.Font("Simple Handmade", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(796, 259);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(148, 48);
            this.refreshBtn.TabIndex = 8;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // TableForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 463);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.approvalBtn);
            this.Controls.Add(this.tableFormsBackground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(770, 422);
            this.MinimumSize = new System.Drawing.Size(770, 422);
            this.Name = "TableForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Account Control";
            this.Load += new System.EventHandler(this.TableForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableFormsBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button approvalBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.PictureBox tableFormsBackground;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button refreshBtn;

    }
}