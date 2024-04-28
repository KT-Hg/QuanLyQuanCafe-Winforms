﻿namespace AppQuanLyQuanCafe
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
            this.lsvBill = new System.Windows.Forms.ListView();
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
            this.tsmAccountProfile.Size = new System.Drawing.Size(180, 22);
            this.tsmAccountProfile.Text = "Thông tin cá nhân";
            this.tsmAccountProfile.Click += new System.EventHandler(this.tsmAccountProfile_Click);
            // 
            // tsmLogout
            // 
            this.tsmLogout.Name = "tsmLogout";
            this.tsmLogout.Size = new System.Drawing.Size(180, 22);
            this.tsmLogout.Text = "Đăng xuất";
            // 
            // flpTable
            // 
            this.flpTable.Location = new System.Drawing.Point(20, 30);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(420, 440);
            this.flpTable.TabIndex = 4;
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
            this.cbbCategory.TabIndex = 0;
            // 
            // cbbFood
            // 
            this.cbbFood.FormattingEnabled = true;
            this.cbbFood.Location = new System.Drawing.Point(5, 35);
            this.cbbFood.Name = "cbbFood";
            this.cbbFood.Size = new System.Drawing.Size(185, 21);
            this.cbbFood.TabIndex = 1;
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(275, 20);
            this.nudAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(50, 20);
            this.nudAmount.TabIndex = 3;
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
            this.btnAddFood.TabIndex = 2;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.UseVisualStyleBackColor = true;
            // 
            // pnlBill
            // 
            this.pnlBill.Controls.Add(this.lsvBill);
            this.pnlBill.Location = new System.Drawing.Point(450, 100);
            this.pnlBill.Name = "pnlBill";
            this.pnlBill.Size = new System.Drawing.Size(330, 300);
            this.pnlBill.TabIndex = 3;
            // 
            // lsvBill
            // 
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(5, 5);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(320, 290);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
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
            this.pnlPayment.TabIndex = 3;
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.Location = new System.Drawing.Point(5, 5);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.Size = new System.Drawing.Size(75, 25);
            this.btnSwitchTable.TabIndex = 7;
            this.btnSwitchTable.Text = "Chuyển bàn";
            this.btnSwitchTable.UseVisualStyleBackColor = true;
            // 
            // cbbSwitchTable
            // 
            this.cbbSwitchTable.FormattingEnabled = true;
            this.cbbSwitchTable.Location = new System.Drawing.Point(5, 35);
            this.cbbSwitchTable.Name = "cbbSwitchTable";
            this.cbbSwitchTable.Size = new System.Drawing.Size(75, 21);
            this.cbbSwitchTable.TabIndex = 4;
            // 
            // btnDiscount
            // 
            this.btnDiscount.Location = new System.Drawing.Point(100, 5);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(75, 25);
            this.btnDiscount.TabIndex = 4;
            this.btnDiscount.Text = "Giảm giá";
            this.btnDiscount.UseVisualStyleBackColor = true;
            // 
            // nudDiscount
            // 
            this.nudDiscount.Location = new System.Drawing.Point(100, 35);
            this.nudDiscount.Name = "nudDiscount";
            this.nudDiscount.Size = new System.Drawing.Size(75, 20);
            this.nudDiscount.TabIndex = 4;
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(195, 5);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(130, 50);
            this.btnPayment.TabIndex = 5;
            this.btnPayment.Text = "Thanh toán";
            this.btnPayment.UseVisualStyleBackColor = true;
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
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnlAddFood.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.pnlBill.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlPayment;
        private System.Windows.Forms.Button btnSwitchTable;
        private System.Windows.Forms.ComboBox cbbSwitchTable;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.NumericUpDown nudDiscount;
        private System.Windows.Forms.Button btnPayment;
    }
}