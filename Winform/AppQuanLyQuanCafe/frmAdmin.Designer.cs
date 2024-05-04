namespace AppQuanLyQuanCafe
{
    partial class frmAdmin
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
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tabIncome = new System.Windows.Forms.TabPage();
            this.tabCategory = new System.Windows.Forms.TabPage();
            this.tabFood = new System.Windows.Forms.TabPage();
            this.tabTable = new System.Windows.Forms.TabPage();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.dgvIncome = new System.Windows.Forms.DataGridView();
            this.pnlIncomeCondition = new System.Windows.Forms.Panel();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.dtpEnđate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.tabControlAdmin.SuspendLayout();
            this.tabIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).BeginInit();
            this.pnlIncomeCondition.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.tabIncome);
            this.tabControlAdmin.Controls.Add(this.tabCategory);
            this.tabControlAdmin.Controls.Add(this.tabFood);
            this.tabControlAdmin.Controls.Add(this.tabTable);
            this.tabControlAdmin.Controls.Add(this.tabAccount);
            this.tabControlAdmin.Location = new System.Drawing.Point(13, 13);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(775, 475);
            this.tabControlAdmin.TabIndex = 0;
            // 
            // tabIncome
            // 
            this.tabIncome.Controls.Add(this.dgvIncome);
            this.tabIncome.Controls.Add(this.pnlIncomeCondition);
            this.tabIncome.Location = new System.Drawing.Point(4, 22);
            this.tabIncome.Name = "tabIncome";
            this.tabIncome.Padding = new System.Windows.Forms.Padding(3);
            this.tabIncome.Size = new System.Drawing.Size(767, 449);
            this.tabIncome.TabIndex = 0;
            this.tabIncome.Text = "Thống kê";
            this.tabIncome.UseVisualStyleBackColor = true;
            // 
            // tabCategory
            // 
            this.tabCategory.Location = new System.Drawing.Point(4, 22);
            this.tabCategory.Name = "tabCategory";
            this.tabCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategory.Size = new System.Drawing.Size(767, 449);
            this.tabCategory.TabIndex = 1;
            this.tabCategory.Text = "Danh mục";
            this.tabCategory.UseVisualStyleBackColor = true;
            // 
            // tabFood
            // 
            this.tabFood.Location = new System.Drawing.Point(4, 22);
            this.tabFood.Name = "tabFood";
            this.tabFood.Padding = new System.Windows.Forms.Padding(3);
            this.tabFood.Size = new System.Drawing.Size(767, 449);
            this.tabFood.TabIndex = 2;
            this.tabFood.Text = "Thức ăn";
            this.tabFood.UseVisualStyleBackColor = true;
            // 
            // tabTable
            // 
            this.tabTable.Location = new System.Drawing.Point(4, 22);
            this.tabTable.Name = "tabTable";
            this.tabTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabTable.Size = new System.Drawing.Size(767, 449);
            this.tabTable.TabIndex = 3;
            this.tabTable.Text = "Bàn ăn";
            this.tabTable.UseVisualStyleBackColor = true;
            // 
            // tabAccount
            // 
            this.tabAccount.Location = new System.Drawing.Point(4, 22);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccount.Size = new System.Drawing.Size(767, 449);
            this.tabAccount.TabIndex = 4;
            this.tabAccount.Text = "Tài khoản";
            this.tabAccount.UseVisualStyleBackColor = true;
            // 
            // dgvIncome
            // 
            this.dgvIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncome.Location = new System.Drawing.Point(8, 42);
            this.dgvIncome.Name = "dgvIncome";
            this.dgvIncome.Size = new System.Drawing.Size(750, 400);
            this.dgvIncome.TabIndex = 3;
            // 
            // pnlIncomeCondition
            // 
            this.pnlIncomeCondition.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlIncomeCondition.Controls.Add(this.btnStatistics);
            this.pnlIncomeCondition.Controls.Add(this.dtpEnđate);
            this.pnlIncomeCondition.Controls.Add(this.dtpStartDate);
            this.pnlIncomeCondition.Location = new System.Drawing.Point(8, 7);
            this.pnlIncomeCondition.Name = "pnlIncomeCondition";
            this.pnlIncomeCondition.Size = new System.Drawing.Size(750, 30);
            this.pnlIncomeCondition.TabIndex = 2;
            // 
            // btnStatistics
            // 
            this.btnStatistics.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStatistics.Location = new System.Drawing.Point(335, 5);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(80, 20);
            this.btnStatistics.TabIndex = 2;
            this.btnStatistics.Text = "Thống kê";
            this.btnStatistics.UseVisualStyleBackColor = true;
            // 
            // dtpEnđate
            // 
            this.dtpEnđate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEnđate.Location = new System.Drawing.Point(545, 5);
            this.dtpEnđate.Name = "dtpEnđate";
            this.dtpEnđate.Size = new System.Drawing.Size(200, 20);
            this.dtpEnđate.TabIndex = 1;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(5, 5);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 0;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.tabControlAdmin);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.tabControlAdmin.ResumeLayout(false);
            this.tabIncome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).EndInit();
            this.pnlIncomeCondition.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage tabIncome;
        private System.Windows.Forms.TabPage tabCategory;
        private System.Windows.Forms.TabPage tabFood;
        private System.Windows.Forms.TabPage tabTable;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.DataGridView dgvIncome;
        private System.Windows.Forms.Panel pnlIncomeCondition;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.DateTimePicker dtpEnđate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
    }
}