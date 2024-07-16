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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dgvProductList = new DataGridView();
            txtProductID = new MaskedTextBox();
            txtProductName = new TextBox();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtUnitPrice = new TextBox();
            txtWeight = new TextBox();
            txtUnitInStock = new TextBox();
            txtSearchProduct = new TextBox();
            btnSearch = new Button();
            cboCategory = new ComboBox();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 106);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Product ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 172);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 1;
            label2.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 436);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Unit Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 304);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 3;
            label4.Text = "Category Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cooper Black", 20.25F);
            label5.Location = new Point(31, 37);
            label5.Name = "label5";
            label5.Size = new Size(385, 39);
            label5.TabIndex = 4;
            label5.Text = "Product Management";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 370);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 5;
            label6.Text = "Weight";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 238);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 6;
            label7.Text = "Unit in stock";
            // 
            // dgvProductList
            // 
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Location = new Point(443, 117);
            dgvProductList.Margin = new Padding(3, 4, 3, 4);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.RowHeadersWidth = 51;
            dgvProductList.RowTemplate.Height = 25;
            dgvProductList.Size = new Size(610, 436);
            dgvProductList.TabIndex = 7;
            dgvProductList.CellClick += dgvProductList_CellClick;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(155, 103);
            txtProductID.Margin = new Padding(3, 4, 3, 4);
            txtProductID.Name = "txtProductID";
            txtProductID.ReadOnly = true;
            txtProductID.Size = new Size(238, 27);
            txtProductID.TabIndex = 8;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(156, 165);
            txtProductName.Margin = new Padding(3, 4, 3, 4);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(238, 27);
            txtProductName.TabIndex = 9;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(9, 503);
            btnCreate.Margin = new Padding(3, 4, 3, 4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(86, 31);
            btnCreate.TabIndex = 10;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(123, 503);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 31);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(237, 503);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(155, 429);
            txtUnitPrice.Margin = new Padding(3, 4, 3, 4);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(238, 27);
            txtUnitPrice.TabIndex = 13;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(156, 367);
            txtWeight.Margin = new Padding(3, 4, 3, 4);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(238, 27);
            txtWeight.TabIndex = 15;
            // 
            // txtUnitInStock
            // 
            txtUnitInStock.Location = new Point(155, 231);
            txtUnitInStock.Margin = new Padding(3, 4, 3, 4);
            txtUnitInStock.Name = "txtUnitInStock";
            txtUnitInStock.Size = new Size(238, 27);
            txtUnitInStock.TabIndex = 16;
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Location = new Point(443, 70);
            txtSearchProduct.Margin = new Padding(3, 4, 3, 4);
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.Size = new Size(407, 27);
            txtSearchProduct.TabIndex = 17;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(881, 70);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(154, 296);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(239, 28);
            cboCategory.TabIndex = 19;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(351, 503);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 31);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 604);
            Controls.Add(btnClear);
            Controls.Add(cboCategory);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchProduct);
            Controls.Add(txtUnitInStock);
            Controls.Add(txtWeight);
            Controls.Add(txtUnitPrice);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(txtProductName);
            Controls.Add(txtProductID);
            Controls.Add(dgvProductList);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProducts";
            Load += frmProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.MaskedTextBox txtProductID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtUnitInStock;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboCategory;
        private Button btnClear;
    }
}