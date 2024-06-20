namespace AppQuanLyQuanCafe
{
    partial class frmTableManager
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAccountInfomation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAccountProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlAddFood = new System.Windows.Forms.Panel();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.cbbFood = new System.Windows.Forms.ComboBox();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.pnlBill = new System.Windows.Forms.Panel();
            this.txbAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.foodName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlPayment = new System.Windows.Forms.Panel();
            this.btnSwitchTable = new System.Windows.Forms.Button();
            this.cbbSwitchTable = new System.Windows.Forms.ComboBox();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.nudDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnPayment = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.pnlAddFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.pnlBill.SuspendLayout();
            this.pnlPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAdmin,
            this.tsmAccountInfomation});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // tsmAdmin
            // 
            this.tsmAdmin.Name = "tsmAdmin";
            this.tsmAdmin.Size = new System.Drawing.Size(55, 26);
            this.tsmAdmin.Text = "Admin";
            this.tsmAdmin.Click += new System.EventHandler(this.tsmAdmin_Click);
            // 
            // tsmAccountInfomation
            // 
            this.tsmAccountInfomation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAccountProfile,
            this.tsmLogout});
            this.tsmAccountInfomation.Name = "tsmAccountInfomation";
            this.tsmAccountInfomation.Size = new System.Drawing.Size(122, 26);
            this.tsmAccountInfomation.Text = "Thông tin tài khoản";
            // 
            // tsmAccountProfile
            // 
            this.tsmAccountProfile.Name = "tsmAccountProfile";
            this.tsmAccountProfile.Size = new System.Drawing.Size(170, 22);
            this.tsmAccountProfile.Text = "Thông tin cá nhân";
            this.tsmAccountProfile.Click += new System.EventHandler(this.tsmAccountProfile_Click);
            // 
            // tsmLogout
            // 
            this.tsmLogout.Name = "tsmLogout";
            this.tsmLogout.Size = new System.Drawing.Size(170, 22);
            this.tsmLogout.Text = "Đăng xuất";
            this.tsmLogout.Click += new System.EventHandler(this.tsmLogout_Click);
            // 
            // flpTable
            // 
            this.flpTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(20, 30);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(420, 440);
            this.flpTable.TabIndex = 1;
            // 
            // pnlAddFood
            // 
            this.pnlAddFood.Controls.Add(this.cbbCategory);
            this.pnlAddFood.Controls.Add(this.cbbFood);
            this.pnlAddFood.Controls.Add(this.nudAmount);
            this.pnlAddFood.Controls.Add(this.btnAddFood);
            this.pnlAddFood.Location = new System.Drawing.Point(450, 30);
            this.pnlAddFood.Name = "pnlAddFood";
            this.pnlAddFood.Size = new System.Drawing.Size(330, 60);
            this.pnlAddFood.TabIndex = 2;
            // 
            // cbbCategory
            // 
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(5, 5);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(185, 21);
            this.cbbCategory.TabIndex = 3;
            this.cbbCategory.SelectedIndexChanged += new System.EventHandler(this.cbbCategory_SelectedIndexChanged);
            // 
            // cbbFood
            // 
            this.cbbFood.FormattingEnabled = true;
            this.cbbFood.Location = new System.Drawing.Point(5, 35);
            this.cbbFood.Name = "cbbFood";
            this.cbbFood.Size = new System.Drawing.Size(185, 21);
            this.cbbFood.TabIndex = 4;
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(275, 20);
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(50, 20);
            this.nudAmount.TabIndex = 5;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(195, 5);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(75, 50);
            this.btnAddFood.TabIndex = 6;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // pnlBill
            // 
            this.pnlBill.Controls.Add(this.txbAmount);
            this.pnlBill.Controls.Add(this.lblAmount);
            this.pnlBill.Controls.Add(this.lsvBill);
            this.pnlBill.Location = new System.Drawing.Point(450, 100);
            this.pnlBill.Name = "pnlBill";
            this.pnlBill.Size = new System.Drawing.Size(330, 300);
            this.pnlBill.TabIndex = 7;
            // 
            // txbAmount
            // 
            this.txbAmount.Location = new System.Drawing.Point(110, 275);
            this.txbAmount.Name = "txbAmount";
            this.txbAmount.ReadOnly = true;
            this.txbAmount.Size = new System.Drawing.Size(215, 20);
            this.txbAmount.TabIndex = 10;
            this.txbAmount.Text = "0";
            // 
            // lblAmount
            // 
            this.lblAmount.Location = new System.Drawing.Point(5, 275);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(100, 20);
            this.lblAmount.TabIndex = 9;
            this.lblAmount.Text = "Thành tiền:";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.foodName,
            this.count,
            this.price,
            this.totalPrice});
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(5, 4);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(320, 265);
            this.lsvBill.TabIndex = 8;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // foodName
            // 
            this.foodName.Text = "Tên món";
            this.foodName.Width = 130;
            // 
            // count
            // 
            this.count.Text = "Số lượng";
            this.count.Width = 55;
            // 
            // price
            // 
            this.price.Text = "Giá";
            this.price.Width = 65;
            // 
            // totalPrice
            // 
            this.totalPrice.Text = "Thành tiền";
            this.totalPrice.Width = 65;
            // 
            // pnlPayment
            // 
            this.pnlPayment.Controls.Add(this.btnSwitchTable);
            this.pnlPayment.Controls.Add(this.cbbSwitchTable);
            this.pnlPayment.Controls.Add(this.btnDiscount);
            this.pnlPayment.Controls.Add(this.nudDiscount);
            this.pnlPayment.Controls.Add(this.btnPayment);
            this.pnlPayment.Location = new System.Drawing.Point(450, 410);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Size = new System.Drawing.Size(330, 60);
            this.pnlPayment.TabIndex = 9;
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.Location = new System.Drawing.Point(5, 30);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.Size = new System.Drawing.Size(75, 25);
            this.btnSwitchTable.TabIndex = 11;
            this.btnSwitchTable.Text = "Chuyển bàn";
            this.btnSwitchTable.UseVisualStyleBackColor = true;
            this.btnSwitchTable.Click += new System.EventHandler(this.btnSwitchTable_Click);
            // 
            // cbbSwitchTable
            // 
            this.cbbSwitchTable.FormattingEnabled = true;
            this.cbbSwitchTable.Location = new System.Drawing.Point(5, 5);
            this.cbbSwitchTable.Name = "cbbSwitchTable";
            this.cbbSwitchTable.Size = new System.Drawing.Size(75, 21);
            this.cbbSwitchTable.TabIndex = 10;
            // 
            // btnDiscount
            // 
            this.btnDiscount.Location = new System.Drawing.Point(100, 30);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(75, 25);
            this.btnDiscount.TabIndex = 13;
            this.btnDiscount.Text = "Giảm giá";
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // nudDiscount
            // 
            this.nudDiscount.Location = new System.Drawing.Point(100, 5);
            this.nudDiscount.Name = "nudDiscount";
            this.nudDiscount.Size = new System.Drawing.Size(75, 20);
            this.nudDiscount.TabIndex = 12;
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(195, 5);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(130, 50);
            this.btnPayment.TabIndex = 14;
            this.btnPayment.Text = "Thanh toán";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // frmTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.pnlAddFood);
            this.Controls.Add(this.pnlBill);
            this.Controls.Add(this.pnlPayment);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán cafe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTableManager_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnlAddFood.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.pnlBill.ResumeLayout(false);
            this.pnlBill.PerformLayout();
            this.pnlPayment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmAccountInfomation;
        private System.Windows.Forms.ToolStripMenuItem tsmAccountProfile;
        private System.Windows.Forms.ToolStripMenuItem tsmLogout;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Panel pnlAddFood;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.ComboBox cbbFood;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Panel pnlBill;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txbAmount;
        private System.Windows.Forms.Panel pnlPayment;
        private System.Windows.Forms.ComboBox cbbSwitchTable;
        private System.Windows.Forms.Button btnSwitchTable;
        private System.Windows.Forms.NumericUpDown nudDiscount;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.ColumnHeader foodName;
        private System.Windows.Forms.ColumnHeader count;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader totalPrice;
    }
}