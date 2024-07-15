namespace WinformApp
{
    partial class frmCategory
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
            label1 = new Label();
            label2 = new Label();
            tbCategory = new TextBox();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvCategory = new DataGridView();
            label3 = new Label();
            tbId = new TextBox();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 18F, FontStyle.Bold);
            label1.Location = new Point(45, 34);
            label1.Name = "label1";
            label1.Size = new Size(374, 35);
            label1.TabIndex = 0;
            label1.Text = "Category Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 187);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "Category";
            // 
            // tbCategory
            // 
            tbCategory.Location = new Point(158, 184);
            tbCategory.Name = "tbCategory";
            tbCategory.Size = new Size(233, 27);
            tbCategory.TabIndex = 2;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(9, 281);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(82, 29);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += CreateCategory;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(124, 281);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 29);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += UpdateCategory;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(239, 281);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += DeleteCategory;
            // 
            // dgvCategory
            // 
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Location = new Point(444, 34);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.RowHeadersWidth = 51;
            dgvCategory.Size = new Size(515, 370);
            dgvCategory.TabIndex = 6;
            dgvCategory.CellClick += dgvCategory_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 121);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 7;
            label3.Text = "ID";
            // 
            // tbId
            // 
            tbId.Enabled = false;
            tbId.Location = new Point(158, 121);
            tbId.Name = "tbId";
            tbId.Size = new Size(233, 27);
            tbId.TabIndex = 8;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(354, 281);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(82, 29);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // frmCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 450);
            Controls.Add(btnClear);
            Controls.Add(tbId);
            Controls.Add(label3);
            Controls.Add(dgvCategory);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(tbCategory);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCategory";
            Text = "frmCategory";
            Load += frmCategory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbId;
        private Button btnClear;
    }
}