namespace WinformApp
{
    partial class frmMember
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtRole = new TextBox();
            txtId = new TextBox();
            txtEmail = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            btnSearchMember = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            dgvMemberList = new DataGridView();
            label6 = new Label();
            tbSearch = new TextBox();
            btnAdd = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 154);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "Member ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 201);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 342);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 2;
            label3.Text = "Role";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 248);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 3;
            label4.Text = "City";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 295);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 4;
            label5.Text = "Country";
            // 
            // txtRole
            // 
            txtRole.Location = new Point(165, 335);
            txtRole.Margin = new Padding(3, 4, 3, 4);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(237, 27);
            txtRole.TabIndex = 5;
            // 
            // txtId
            // 
            txtId.Location = new Point(165, 147);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(237, 27);
            txtId.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(165, 194);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(237, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(165, 241);
            txtCity.Margin = new Padding(3, 4, 3, 4);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(237, 27);
            txtCity.TabIndex = 8;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(165, 288);
            txtCountry.Margin = new Padding(3, 4, 3, 4);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(237, 27);
            txtCountry.TabIndex = 9;
            // 
            // btnSearchMember
            // 
            btnSearchMember.Location = new Point(775, 42);
            btnSearchMember.Margin = new Padding(3, 4, 3, 4);
            btnSearchMember.Name = "btnSearchMember";
            btnSearchMember.Size = new Size(155, 31);
            btnSearchMember.TabIndex = 10;
            btnSearchMember.Text = "Search";
            btnSearchMember.UseVisualStyleBackColor = true;
            btnSearchMember.Click += btnSearchMember_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(242, 408);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDeleteMember_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(131, 408);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 31);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new Point(446, 115);
            dgvMemberList.Margin = new Padding(3, 4, 3, 4);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.RowHeadersWidth = 51;
            dgvMemberList.RowTemplate.Height = 25;
            dgvMemberList.Size = new Size(692, 324);
            dgvMemberList.TabIndex = 14;
            dgvMemberList.CellClick += clickCellShowInfo;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cooper Black", 18F, FontStyle.Bold);
            label6.Location = new Point(46, 38);
            label6.Name = "label6";
            label6.Size = new Size(356, 35);
            label6.TabIndex = 15;
            label6.Text = "Member Management";
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(446, 44);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(297, 27);
            tbSearch.TabIndex = 16;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(20, 408);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 31);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(353, 408);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 31);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // frmMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 550);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(tbSearch);
            Controls.Add(label6);
            Controls.Add(dgvMemberList);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSearchMember);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtEmail);
            Controls.Add(txtId);
            Controls.Add(txtRole);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMember";
            Load += frmMember_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvMemberList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSearch;
        private Button btnAdd;
        private Button btnClear;
    }
}