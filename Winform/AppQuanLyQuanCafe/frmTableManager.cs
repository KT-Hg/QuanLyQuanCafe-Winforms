﻿using AppQuanLyQuanCafe.DAO;
using AppQuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyQuanCafe
{
    public partial class frmTableManager : Form
    {
        private AccountDTO accountDTO;

        public frmTableManager(AccountDTO accountDTO)
        {
            InitializeComponent();
            LoadTable();
            LoadCategory();
            LoadTableList();
            this.accountDTO = accountDTO;
            ChangeAccount(accountDTO.Type);
        }

        #region Method
        
        void ChangeAccount(int type)
        {
            tsmAdmin.Enabled = type == 1;
        }

        void LoadCategory()
        {
            List<CategoryDTO> foodCategoryDTOs = CategoryDAO.Instance.GetListCategory();
            cbbCategory.DataSource = foodCategoryDTOs;
            cbbCategory.DisplayMember = "name";
        }

        void LoadFoodlistByCategoryId(int categoryId)
        {
            List<FoodDTO> foodDTOs=FoodDAO.Instance.GetListFoodByCategoryId(categoryId);
            cbbFood.DataSource = foodDTOs;
            cbbFood.DisplayMember = "name";
        }

        void LoadTable()
        {
            List<TableDTO> tableDTOs = TableDAO.Instance.LoadTableList();
            flpTable.Controls.Clear();
            foreach (TableDTO tableDTO in tableDTOs) 
            {
                Button button = new Button() { Width = TableDAO.tableWidth, Height = TableDAO.tableHeigth };
                button.Text = tableDTO.Name + Environment.NewLine + tableDTO.Status;
                button.Click += btn_Click;
                button.Tag = tableDTO;
                flpTable.Controls.Add(button);
            }
        }

        void LoadTableList()
        {
            List<TableDTO> tableDTOs = TableDAO.Instance.LoadTableList();
            cbbSwitchTable.DataSource = tableDTOs;
            cbbSwitchTable.DisplayMember = "name";
        }

        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<MenuDTO> menuDTOs = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (MenuDTO menuDTO in menuDTOs)
            {
                ListViewItem listViewItem = new ListViewItem(menuDTO.FoodName.ToString());
                listViewItem.SubItems.Add(menuDTO.Count.ToString());
                listViewItem.SubItems.Add(menuDTO.Price.ToString());
                listViewItem.SubItems.Add(menuDTO.TotalPrice.ToString());
                lsvBill.Items.Add(listViewItem);
                totalPrice += menuDTO.TotalPrice;
            }
            CultureInfo cultureInfo =new CultureInfo("vi-VN");
            totalPrice *= (1 - (int)nudDiscount.Value / 100f);
            txbAmount.Text = totalPrice.ToString("c",cultureInfo);
            txbAmount.Tag = totalPrice.ToString();
            
        }


        #endregion

        #region Event

        private void frmTableManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int tableId=((sender as Button).Tag as TableDTO).Id;
            lsvBill.Tag = (sender as Button).Tag;
            nudDiscount.Value = 0;
            ShowBill(tableId);

        }
        private void tsmAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin frmAdmin = new frmAdmin();
            this.Hide();
            frmAdmin.ShowDialog();
            this.Show();
            LoadTable();
            LoadCategory();
            LoadTableList();
        }

        private void tsmAccountProfile_Click(object sender, EventArgs e)
        {
            frmAccountProfile frmAccountProfile = new frmAccountProfile(accountDTO);
            frmAccountProfile.ShowDialog();
            this.Show();
        }

        private void tsmLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoryId = 0;
            ComboBox comboBoxCategory = sender as ComboBox;
            if (comboBoxCategory.SelectedItem == null) return;
            CategoryDTO categoryDTO = comboBoxCategory.SelectedItem as CategoryDTO;
            categoryId = categoryDTO.Id;
            LoadFoodlistByCategoryId(categoryId);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            TableDTO tableDTO=lsvBill.Tag as TableDTO;
            FoodDTO foodDTO = cbbFood.SelectedItem as FoodDTO;

            if (tableDTO == null)
            {
                MessageBox.Show("Bạn chưa chọn bàn.", "Thông báo");
                return;
            }

            int idBill = BillDAO.Instance.GetUncheckBillIdByTableId(tableDTO.Id);

            if ((int)nudAmount.Value < 1)
            {
                MessageBox.Show("Số lượng không thể âm hoặc bằng 0.", "Thông báo");
                return;
            }

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(tableDTO.Id);
                TableDAO.Instance.UpdateTableStatus(tableDTO.Id);
                LoadTable();
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIdBill(), foodDTO.Id, (int)nudAmount.Value);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodDTO.Id, (int)nudAmount.Value);
            }
            ShowBill(tableDTO.Id);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            TableDTO tableDTO = lsvBill.Tag as TableDTO;
            if (tableDTO == null)
            {
                MessageBox.Show("Bạn chưa chọn bàn.", "Thông báo");
                return;
            }

            int idBill = BillDAO.Instance.GetUncheckBillIdByTableId(tableDTO.Id);

            if (idBill == -1)
            {
                MessageBox.Show("Không có hoá đơn để thanh toán.", "Thông báo");
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc thanh toán hoá đơn cho bàn " + tableDTO.Id + ".", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.UpdateBill(idBill, (int)nudDiscount.Value,(float)Convert.ToDouble(txbAmount.Tag.ToString()));
                    TableDAO.Instance.UpdateTableStatus(tableDTO.Id);
                    LoadTable();
                }
            }
            ShowBill(tableDTO.Id);
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            TableDTO tableDTO = lsvBill.Tag as TableDTO;
            if (tableDTO == null)
            {
                MessageBox.Show("Bạn chưa chọn bàn.", "Thông báo");
                return;
            }
            ShowBill(tableDTO.Id);
        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            TableDTO tableDTO = lsvBill.Tag as TableDTO;
            if (tableDTO == null)
            {
                MessageBox.Show("Bạn chưa chọn bàn.", "Thông báo");
                return;
            }
            TableDAO.Instance.SwapTableStatus(tableDTO.Id, (cbbSwitchTable.SelectedItem as TableDTO).Id);
            BillDAO.Instance.SwapBill(tableDTO.Id, (cbbSwitchTable.SelectedItem as TableDTO).Id);
            LoadTable();
            ShowBill(tableDTO.Id);
        }

        #endregion

        
    }
}


