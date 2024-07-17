namespace WinformApp
{
    partial class frmProducts
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
            label11 = new Label();
            txtSearchProduct = new TextBox();
            btnSearch = new Button();
            dgvProductList = new DataGridView();
            label12 = new Label();
            btnDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lbCate = new Label();
            txtProductID = new TextBox();
            txtProductName = new TextBox();
            txtUnitPrice = new TextBox();
            txtUnitInStock = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            cboCategory = new ComboBox();
            label6 = new Label();
            btnRefresh = new Button();
            txtWeight = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(477, 60);
            label11.TabIndex = 35;
            label11.Text = "Product Management";
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Location = new Point(141, 86);
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.Size = new Size(261, 27);
            txtSearchProduct.TabIndex = 38;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Highlight;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(437, 76);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 37);
            btnSearch.TabIndex = 40;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvProductList
            // 
            dgvProductList.AllowUserToAddRows = false;
            dgvProductList.AllowUserToDeleteRows = false;
            dgvProductList.AllowUserToResizeColumns = false;
            dgvProductList.AllowUserToResizeRows = false;
            dgvProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductList.BackgroundColor = Color.White;
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Location = new Point(11, 131);
            dgvProductList.Margin = new Padding(3, 5, 3, 5);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.ReadOnly = true;
            dgvProductList.RowHeadersWidth = 51;
            dgvProductList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductList.Size = new Size(623, 518);
            dgvProductList.TabIndex = 41;
            dgvProductList.CellClick += dgvProductList_CellClick;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold);
            label12.ForeColor = SystemColors.Highlight;
            label12.Location = new Point(11, 74);
            label12.Name = "label12";
            label12.Size = new Size(124, 45);
            label12.TabIndex = 43;
            label12.Text = "Search";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Highlight;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(774, 602);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 37);
            btnDelete.TabIndex = 44;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(657, 131);
            label1.Name = "label1";
            label1.Size = new Size(432, 45);
            label1.TabIndex = 46;
            label1.Text = "Product detail information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(707, 225);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 47;
            label2.Text = "Product ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(682, 276);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 48;
            label3.Text = "Product Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(744, 328);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 49;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(694, 387);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 50;
            label5.Text = "Unit in stock";
            // 
            // lbCate
            // 
            lbCate.AutoSize = true;
            lbCate.Location = new Point(672, 438);
            lbCate.Name = "lbCate";
            lbCate.Size = new Size(113, 20);
            lbCate.TabIndex = 52;
            lbCate.Text = "Category Name";
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(808, 224);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(225, 27);
            txtProductID.TabIndex = 54;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(808, 274);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(225, 27);
            txtProductName.TabIndex = 55;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(808, 326);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(225, 27);
            txtUnitPrice.TabIndex = 56;
            // 
            // txtUnitInStock
            // 
            txtUnitInStock.Location = new Point(808, 385);
            txtUnitInStock.Name = "txtUnitInStock";
            txtUnitInStock.Size = new Size(231, 27);
            txtUnitInStock.TabIndex = 57;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Highlight;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(774, 538);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 37);
            btnAdd.TabIndex = 61;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Highlight;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(902, 538);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 37);
            btnUpdate.TabIndex = 62;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { "1. Drinks", "2. Food", "3. Electronics" });
            cboCategory.Location = new Point(808, 431);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(231, 28);
            cboCategory.TabIndex = 64;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(728, 490);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 65;
            label6.Text = "Weight";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.Highlight;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(901, 602);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 37);
            btnRefresh.TabIndex = 67;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(808, 487);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(231, 27);
            txtWeight.TabIndex = 68;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 676);
            Controls.Add(txtWeight);
            Controls.Add(btnRefresh);
            Controls.Add(label6);
            Controls.Add(cboCategory);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtUnitInStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtProductName);
            Controls.Add(txtProductID);
            Controls.Add(lbCate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(label12);
            Controls.Add(dgvProductList);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchProduct);
            Controls.Add(label11);
            Name = "frmProducts";
            Load += frmProducts_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbCate;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtUnitInStock;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cboCategory;
        private Label label6;
        private Button btnRefresh;
        private TextBox txtWeight;
    }
}