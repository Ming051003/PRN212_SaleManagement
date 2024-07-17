namespace WinformApp
{
    partial class frmOrder
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
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            btnReload = new Button();
            btnSearch = new Button();
            label1 = new Label();
            dgvOrders = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(340, 94);
            dtpEndDate.Margin = new Padding(3, 4, 3, 4);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(228, 27);
            dtpEndDate.TabIndex = 84;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(33, 94);
            dtpStartDate.Margin = new Padding(3, 4, 3, 4);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(228, 27);
            dtpStartDate.TabIndex = 83;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(340, 70);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 82;
            label2.Text = "End Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 70);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 81;
            label3.Text = "Start Date";
            // 
            // btnReload
            // 
            btnReload.BackColor = SystemColors.Highlight;
            btnReload.FlatStyle = FlatStyle.Flat;
            btnReload.ForeColor = Color.White;
            btnReload.Location = new Point(718, 89);
            btnReload.Margin = new Padding(3, 4, 3, 4);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(96, 32);
            btnReload.TabIndex = 80;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = false;
            btnReload.Click += btnReload_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Highlight;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(607, 89);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(96, 32);
            btnSearch.TabIndex = 79;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            label1.Location = new Point(18, -1);
            label1.Name = "label1";
            label1.Size = new Size(229, 60);
            label1.TabIndex = 78;
            label1.Text = "List Order";
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AllowUserToResizeColumns = false;
            dgvOrders.AllowUserToResizeRows = false;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.BackgroundColor = SystemColors.ControlLightLight;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(33, 140);
            dgvOrders.Margin = new Padding(3, 4, 3, 4);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.RowTemplate.Height = 25;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(856, 479);
            dgvOrders.TabIndex = 77;
            // 
            // frmOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 641);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(btnReload);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(dgvOrders);
            Name = "frmOrder";
            Text = "frmOrder";
            Load += frmOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private Label label2;
        private Label label3;
        private Button btnReload;
        private Button btnSearch;
        private Label label1;
        private DataGridView dgvOrders;
    }
}