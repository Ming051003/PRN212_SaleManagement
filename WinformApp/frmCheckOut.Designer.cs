namespace WinformApp
{
    partial class frmCheckOut
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
            cboPaymentMethod = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txtCustomerName = new TextBox();
            label2 = new Label();
            label7 = new Label();
            btnCheckout = new Button();
            btnRemoveCart = new Button();
            dgvOrderDetails = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).BeginInit();
            SuspendLayout();
            // 
            // cboPaymentMethod
            // 
            cboPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPaymentMethod.FormattingEnabled = true;
            cboPaymentMethod.Items.AddRange(new object[] { "Cash", "Online" });
            cboPaymentMethod.Location = new Point(388, -97);
            cboPaymentMethod.Margin = new Padding(3, 4, 3, 4);
            cboPaymentMethod.Name = "cboPaymentMethod";
            cboPaymentMethod.Size = new Size(205, 28);
            cboPaymentMethod.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(207, -93);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 32;
            label4.Text = "Payment Method";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, -132);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 31;
            label3.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(388, -136);
            txtCustomerName.Margin = new Padding(3, 4, 3, 4);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(205, 27);
            txtCustomerName.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(207, -69);
            label2.Name = "label2";
            label2.Size = new Size(38, 28);
            label2.TabIndex = 29;
            label2.Text = "Biil";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(113, 40);
            label7.Name = "label7";
            label7.Size = new Size(38, 28);
            label7.TabIndex = 48;
            label7.Text = "Biil";
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = SystemColors.Highlight;
            btnCheckout.FlatStyle = FlatStyle.Flat;
            btnCheckout.ForeColor = Color.White;
            btnCheckout.Location = new Point(419, 524);
            btnCheckout.Margin = new Padding(3, 4, 3, 4);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(179, 72);
            btnCheckout.TabIndex = 41;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnRemoveCart
            // 
            btnRemoveCart.BackColor = SystemColors.Highlight;
            btnRemoveCart.FlatStyle = FlatStyle.Flat;
            btnRemoveCart.ForeColor = Color.White;
            btnRemoveCart.Location = new Point(113, 524);
            btnRemoveCart.Margin = new Padding(3, 4, 3, 4);
            btnRemoveCart.Name = "btnRemoveCart";
            btnRemoveCart.Size = new Size(171, 72);
            btnRemoveCart.TabIndex = 39;
            btnRemoveCart.Text = "Remove";
            btnRemoveCart.UseVisualStyleBackColor = false;
            btnRemoveCart.Click += btnRemoveCart_Click;
            // 
            // dgvOrderDetails
            // 
            dgvOrderDetails.AllowUserToAddRows = false;
            dgvOrderDetails.AllowUserToDeleteRows = false;
            dgvOrderDetails.AllowUserToResizeColumns = false;
            dgvOrderDetails.AllowUserToResizeRows = false;
            dgvOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderDetails.BackgroundColor = SystemColors.ControlLightLight;
            dgvOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetails.Location = new Point(113, 72);
            dgvOrderDetails.Margin = new Padding(3, 4, 3, 4);
            dgvOrderDetails.MultiSelect = false;
            dgvOrderDetails.Name = "dgvOrderDetails";
            dgvOrderDetails.ReadOnly = true;
            dgvOrderDetails.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvOrderDetails.RowHeadersVisible = false;
            dgvOrderDetails.RowHeadersWidth = 51;
            dgvOrderDetails.RowTemplate.Height = 25;
            dgvOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderDetails.Size = new Size(485, 401);
            dgvOrderDetails.TabIndex = 34;
            dgvOrderDetails.CellClick += dgvOrderDetails_CellClick;
            // 
            // frmCheckOut
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 643);
            Controls.Add(label7);
            Controls.Add(btnCheckout);
            Controls.Add(btnRemoveCart);
            Controls.Add(dgvOrderDetails);
            Controls.Add(cboPaymentMethod);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtCustomerName);
            Controls.Add(label2);
            Name = "frmCheckOut";
            Text = "Checkout";
            Load += frmCheckOut_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboPaymentMethod;
        private Label label4;
        private Label label3;
        private TextBox txtCustomerName;
        private Label label2;
        private Label label7;
        private Button btnCheckout;
        private Button btnRemoveCart;
        private DataGridView dgvOrderDetails;
    }
}