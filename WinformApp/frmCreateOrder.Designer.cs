namespace WinformApp
{
    partial class frmCreateOrder
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
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnRefresh = new Button();
            dgvProducts = new DataGridView();
            label1 = new Label();
            rtbAction = new RichTextBox();
            label5 = new Label();
            txtQuantity = new TextBox();
            label4 = new Label();
            txtUnitInStock = new TextBox();
            txtUnitPrice = new TextBox();
            txtProductName = new TextBox();
            txtProductID = new MaskedTextBox();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            button2 = new Button();
            btnBuy = new Button();
            btnCart = new Button();
            btnLoadProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Highlight;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(415, 107);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(96, 32);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(73, 111);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Product Name";
            txtSearch.Size = new Size(281, 27);
            txtSearch.TabIndex = 8;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.Highlight;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(532, 107);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(91, 31);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AllowUserToResizeColumns = false;
            dgvProducts.AllowUserToResizeRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = SystemColors.ControlLightLight;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(27, 147);
            dgvProducts.Margin = new Padding(3, 4, 3, 4);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 25;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(772, 508);
            dgvProducts.TabIndex = 13;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            label1.Location = new Point(5, 3);
            label1.Name = "label1";
            label1.Size = new Size(145, 60);
            label1.TabIndex = 15;
            label1.Text = "Order";
            // 
            // rtbAction
            // 
            rtbAction.BackColor = Color.WhiteSmoke;
            rtbAction.Font = new Font("BIZ UDPGothic", 21.75F, FontStyle.Bold);
            rtbAction.ForeColor = Color.CornflowerBlue;
            rtbAction.Location = new Point(156, 12);
            rtbAction.Margin = new Padding(3, 4, 3, 4);
            rtbAction.Name = "rtbAction";
            rtbAction.ReadOnly = true;
            rtbAction.Size = new Size(621, 51);
            rtbAction.TabIndex = 17;
            rtbAction.Text = "Action";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(73, 86);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 23;
            label5.Text = "Search:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(959, 400);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(141, 27);
            txtQuantity.TabIndex = 45;
            txtQuantity.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(819, 407);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 44;
            label4.Text = "Quantity";
            // 
            // txtUnitInStock
            // 
            txtUnitInStock.Location = new Point(955, 339);
            txtUnitInStock.Margin = new Padding(3, 4, 3, 4);
            txtUnitInStock.Name = "txtUnitInStock";
            txtUnitInStock.ReadOnly = true;
            txtUnitInStock.Size = new Size(145, 27);
            txtUnitInStock.TabIndex = 43;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(961, 280);
            txtUnitPrice.Margin = new Padding(3, 4, 3, 4);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(139, 27);
            txtUnitPrice.TabIndex = 42;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(955, 220);
            txtProductName.Margin = new Padding(3, 4, 3, 4);
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(145, 27);
            txtProductName.TabIndex = 41;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(953, 160);
            txtProductID.Margin = new Padding(3, 4, 3, 4);
            txtProductID.Name = "txtProductID";
            txtProductID.ReadOnly = true;
            txtProductID.Size = new Size(147, 27);
            txtProductID.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(819, 346);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 39;
            label7.Text = "Unit in stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(819, 287);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 38;
            label3.Text = "Unit Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(818, 227);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 37;
            label2.Text = "Product Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(819, 167);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 36;
            label6.Text = "Product ID";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(979, 553);
            button2.Name = "button2";
            button2.Size = new Size(123, 36);
            button2.TabIndex = 49;
            button2.Text = "Logout";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnBuy
            // 
            btnBuy.BackColor = Color.Turquoise;
            btnBuy.ForeColor = SystemColors.ActiveCaptionText;
            btnBuy.Location = new Point(821, 551);
            btnBuy.Margin = new Padding(3, 4, 3, 4);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(123, 35);
            btnBuy.TabIndex = 46;
            btnBuy.Text = "Buy";
            btnBuy.UseVisualStyleBackColor = false;
            btnBuy.Click += btnBuy_Click;
            // 
            // btnCart
            // 
            btnCart.BackColor = Color.Orange;
            btnCart.Location = new Point(979, 486);
            btnCart.Margin = new Padding(3, 4, 3, 4);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(123, 32);
            btnCart.TabIndex = 48;
            btnCart.Text = "Cart";
            btnCart.UseVisualStyleBackColor = false;
            btnCart.Click += btnCart_Click;
            // 
            // btnLoadProduct
            // 
            btnLoadProduct.Location = new Point(819, 486);
            btnLoadProduct.Margin = new Padding(3, 4, 3, 4);
            btnLoadProduct.Name = "btnLoadProduct";
            btnLoadProduct.Size = new Size(123, 32);
            btnLoadProduct.TabIndex = 47;
            btnLoadProduct.Text = "Load";
            btnLoadProduct.UseVisualStyleBackColor = true;
            btnLoadProduct.Click += btnLoadProduct_Click;
            // 
            // frmCreateOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1142, 705);
            Controls.Add(button2);
            Controls.Add(btnBuy);
            Controls.Add(btnCart);
            Controls.Add(btnLoadProduct);
            Controls.Add(txtQuantity);
            Controls.Add(label4);
            Controls.Add(txtUnitInStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtProductName);
            Controls.Add(txtProductID);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(rtbAction);
            Controls.Add(label1);
            Controls.Add(dgvProducts);
            Controls.Add(btnRefresh);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCreateOrder";
            Load += frmCreateOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbAction;
        private System.Windows.Forms.Label label5;
        private TextBox txtQuantity;
        private Label label4;
        private TextBox txtUnitInStock;
        private TextBox txtUnitPrice;
        private TextBox txtProductName;
        private MaskedTextBox txtProductID;
        private Label label7;
        private Label label3;
        private Label label2;
        private Label label6;
        private Button button2;
        private Button btnBuy;
        private Button btnCart;
        private Button btnLoadProduct;
    }
}