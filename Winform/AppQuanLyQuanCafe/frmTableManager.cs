using AppQuanLyQuanCafe.DAO;
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
        public frmTableManager()
        {
            InitializeComponent();
            loadTable();
            loadCategory();
            loadTableList();
        }

        private void frmTableManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        #region Method
        
        void loadCategory()
        {
            List<FoodCategoryDTO> foodCategoryDTOs = CategoryDAO.Instance.getListCategory();
            cbbCategory.DataSource = foodCategoryDTOs;
            cbbCategory.DisplayMember = "name";
        }

        void loadFoodlistByCategoryId(int categoryId)
        {
            List<FoodDTO> foodDTOs=FoodDAO.Instance.getListFoodByCategoryId(categoryId);
            cbbFood.DataSource = foodDTOs;
            cbbFood.DisplayMember = "name";
        }

        void loadTable()
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

        void loadTableList()
        {
            List<TableDTO> tableDTOs = TableDAO.Instance.LoadTableList();
            cbbSwitchTable.DataSource = tableDTOs;
            cbbSwitchTable.DisplayMember = "name";
        }

        void showBill(int id)
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

        }
        

        #endregion

        #region Event
        private void btn_Click(object sender, EventArgs e)
        {
            int tableId=((sender as Button).Tag as TableDTO).Id;
            lsvBill.Tag = (sender as Button).Tag;
            nudDiscount.Value = 0;
            showBill(tableId);

        }
        private void tsmAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin frmAdmin = new frmAdmin();
            this.Hide();
            frmAdmin.ShowDialog();
            this.Show();
        }

        private void tsmAccountProfile_Click(object sender, EventArgs e)
        {
            frmAccountProfile frmAccountProfile = new frmAccountProfile();
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
            FoodCategoryDTO categoryDTO = comboBoxCategory.SelectedItem as FoodCategoryDTO;
            categoryId = categoryDTO.Id;
            loadFoodlistByCategoryId(categoryId);
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
                BillDAO.Instance.insertBill(tableDTO.Id);
                TableDAO.Instance.updateTableStatus(tableDTO.Id);
                loadTable();
                BillInfoDAO.Instance.insertBillInfo(BillDAO.Instance.getMaxIdBill(), foodDTO.Id, (int)nudAmount.Value);
            }
            else
            {
                BillInfoDAO.Instance.insertBillInfo(idBill, foodDTO.Id, (int)nudAmount.Value);
            }
            showBill(tableDTO.Id);
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
                    BillDAO.Instance.updateBill(idBill, (int)nudDiscount.Value);
                    TableDAO.Instance.updateTableStatus(tableDTO.Id);
                    loadTable();
                }
            }
            showBill(tableDTO.Id);
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            TableDTO tableDTO = lsvBill.Tag as TableDTO;
            if (tableDTO == null)
            {
                MessageBox.Show("Bạn chưa chọn bàn.", "Thông báo");
                return;
            }
            showBill(tableDTO.Id);
        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            TableDTO tableDTO = lsvBill.Tag as TableDTO;
            if (tableDTO == null)
            {
                MessageBox.Show("Bạn chưa chọn bàn.", "Thông báo");
                return;
            }
            TableDAO.Instance.swapTableStatus(tableDTO.Id, (cbbSwitchTable.SelectedItem as TableDTO).Id);
            BillDAO.Instance.swapBill(tableDTO.Id, (cbbSwitchTable.SelectedItem as TableDTO).Id);
            loadTable();
            showBill(tableDTO.Id);
        }

        #endregion

        
    }
}


