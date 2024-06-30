using AppQuanLyQuanCafe.DAO;
using AppQuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AppQuanLyQuanCafe
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            LoadIncomeByDate();

            LoadCategory();

            LoadFood();

            LoadTable();

            LoadAccount();
        }

        #region Method

        #region Income
        void LoadIncomeByDate()
        {
            DataTable dataTable;
            dataTable = BillDAO.Instance.GetListBillByDate(dtpStartDate.Value, dtpEndDate.Value);
            dataTable.Columns[0].ColumnName="Tên bàn";
            dataTable.Columns[1].ColumnName="Id";
            dataTable.Columns[2].ColumnName="Ngày vào";
            dataTable.Columns[3].ColumnName="Ngày ra";
            dataTable.Columns[4].ColumnName="Tổng tiền";
            dataTable.Columns[5].ColumnName="Giảm giá";
            dgvIncome.DataSource = dataTable;
        }
        #endregion

        #region Category
        void LoadCategory()
        {
            DataTable dataTable;
            dataTable = CategoryDAO.Instance.GetCategory();
            dataTable.Columns[0].ColumnName = "Id";
            dataTable.Columns[1].ColumnName = "Tên loại";
            dgvCategory.DataSource = dataTable;

            CategoryBinding();
        }
        void LoadCategory(DataTable dataTable)
        {
            dataTable.Columns[0].ColumnName = "Id";
            dataTable.Columns[1].ColumnName = "Tên loại";
            dgvCategory.DataSource = dataTable;

            CategoryBinding();
        }
        void CategoryBinding()
        {
            txbIdCategory.DataBindings.Clear();
            txbNameCategory.DataBindings.Clear();
            txbIdCategory.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txbNameCategory.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "Tên loại", true, DataSourceUpdateMode.Never));
        }
        #endregion

        #region Food
        void LoadFood()
        {
            DataTable dataTable;
            dataTable = FoodDAO.Instance.GetListFood();
            dataTable.Columns[0].ColumnName = "Id";
            dataTable.Columns[1].ColumnName = "Tên món";
            dataTable.Columns[2].ColumnName = "Id loại";
            dataTable.Columns[3].ColumnName = "Giá";
            dgvFood.DataSource = dataTable;

            FoodBinding();
            LoadListCategory();
        }
        void LoadFood(DataTable dataTable)
        {
            dataTable.Columns[0].ColumnName = "Id";
            dataTable.Columns[1].ColumnName = "Tên món";
            dataTable.Columns[2].ColumnName = "Id loại";
            dataTable.Columns[3].ColumnName = "Giá";
            dgvFood.DataSource = dataTable;

            FoodBinding();
        }
        void LoadListCategory()
        {
            List<CategoryDTO> foodCategoryDTOs;
            foodCategoryDTOs = CategoryDAO.Instance.GetListCategory();
            foodCategoryDTOs.Insert(0, new CategoryDTO(0, ""));
            cbbCategoryFood.DataSource = foodCategoryDTOs;
            cbbCategoryFood.DisplayMember = "name";
        }
        void FoodBinding()
        {
            txbIdFood.DataBindings.Clear();
            txbNameFood.DataBindings.Clear();
            nudPriceFood.DataBindings.Clear();
            txbIdFood.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txbNameFood.DataBindings.Add(new Binding("Text",dgvFood.DataSource, "Tên món", true, DataSourceUpdateMode.Never));
            nudPriceFood.DataBindings.Add(new Binding("Value", dgvFood.DataSource, "Giá", true, DataSourceUpdateMode.Never));
        }
        #endregion

        #region Table
        void LoadTable() 
        {
            DataTable dataTable;
            dataTable = TableDAO.Instance.GetTable();
            dataTable.Columns[0].ColumnName = "Id";
            dataTable.Columns[1].ColumnName = "Tên bàn";
            dataTable.Columns[2].ColumnName = "Trạng thái";
            
            dgvTable.DataSource = dataTable;

            TableBinding();
        }
        void LoadTable(DataTable dataTable) 
        {
            dataTable.Columns[0].ColumnName = "Id";
            dataTable.Columns[1].ColumnName = "Tên bàn";
            dataTable.Columns[2].ColumnName = "Trạng thái";

            dgvTable.DataSource = dataTable;

            TableBinding();
        }
        void TableBinding()
        {
            txbIdTable.DataBindings.Clear();
            txbNameTable.DataBindings.Clear();
            txbStatusTable.DataBindings.Clear();
            txbIdTable.DataBindings.Add(new Binding("Text", dgvTable.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txbNameTable.DataBindings.Add(new Binding("Text", dgvTable.DataSource, "Tên bàn", true, DataSourceUpdateMode.Never));
            txbStatusTable.DataBindings.Add(new Binding("Text", dgvTable.DataSource, "Trạng thái", true, DataSourceUpdateMode.Never));
        }
        #endregion

        #region Account
        void LoadAccount()
        {
            DataTable dataTable;
            dataTable = AccountDAO.Instance.GetAccount();
            dataTable.Columns[0].ColumnName = "Tên hiển thị";
            dataTable.Columns[1].ColumnName = "Tên đăng nhập";
            dataTable.Columns[2].ColumnName = "Loại";
            dgvAccount.DataSource = dataTable;

            AccountBinding();
        }
        void LoadAccount(DataTable dataTable)
        {
            dataTable.Columns[0].ColumnName = "Tên hiển thị";
            dataTable.Columns[1].ColumnName = "Tên đăng nhập";
            dataTable.Columns[3].ColumnName = "Loại";
            dgvAccount.DataSource = dataTable;

            AccountBinding();
        }
        void AccountBinding()
        {
            txbDisplayName.DataBindings.Clear();
            txbUserName.DataBindings.Clear();
            txbType.DataBindings.Clear();
            txbDisplayName.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "Tên hiển thị", true, DataSourceUpdateMode.Never));
            txbUserName.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "Tên đăng nhập", true, DataSourceUpdateMode.Never));
            txbType.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "Loại", true, DataSourceUpdateMode.Never));
        }

        #endregion

        #endregion

        #region Event


        #region Income
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            LoadIncomeByDate();
        }
        #endregion

        #region Category
        private void btnShowCatagory_Click(object sender, EventArgs e)
        {
            LoadCategory();
        }
        private void btnSearchCategory_Click(object sender, EventArgs e)
        {
            string name = txbSearchCategory.Text.ToString();
            DataTable dataTable = CategoryDAO.Instance.GetCategoryByName(name);
            LoadCategory(dataTable);
        }
        private void btnInsertCategory_Click(object sender, EventArgs e)
        {
            string name = txbNameCategory.Text;
            if (CategoryDAO.Instance.InsertCategory(name))
            {
                MessageBox.Show("Thêm loại thành công.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm loại thất bại.", "Thông báo");
            }
            LoadCategory();
            LoadFood();
        }
        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbIdCategory.Text);
            if (CategoryDAO.Instance.DeleteCategory(id))
            {
                MessageBox.Show("Xoá loại thành công.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xoá loại thất bại.", "Thông báo");
            }
            LoadCategory();
            LoadFood();
        }
        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbIdCategory.Text);
            string name = txbNameCategory.Text;
            if (CategoryDAO.Instance.UpdateCategory(id, name)) 
            {
                MessageBox.Show("Cập nhật loại thành công.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Cập nhật loại thất bại.", "Thông báo");
            }
            LoadCategory();
            LoadFood();
        }
        #endregion

        #region Food
        private void txbIdFood_TextChanged(object sender, EventArgs e)
        {
            FoodDTO foodDTO = FoodDAO.Instance.GetFood(Convert.ToInt32(txbIdFood.Text));
            foreach (CategoryDTO foodCategoryDTO in cbbCategoryFood.Items)
            {
                if(foodCategoryDTO.Id==foodDTO.IdCategory)
                {
                    cbbCategoryFood.SelectedItem = foodCategoryDTO;
                }
            }
            
        }
        private void btnShowFood_Click(object sender, EventArgs e)
        {
            LoadFood();
        }
        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            string name = txbSearchFood.Text.ToString();
            DataTable dataTable = FoodDAO.Instance.GetFoodByName(name);
            LoadFood(dataTable);
        }
        private void btnInsertFood_Click(object sender, EventArgs e)
        {
            string name = txbNameFood.Text;
            int idCategory = (cbbCategoryFood.SelectedItem as CategoryDTO).Id;
            float price = (float)nudPriceFood.Value;
            if (FoodDAO.Instance.InsertFood(name,idCategory,price))
            {
                MessageBox.Show("Thêm món thành công.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm món thất bại.", "Thông báo");
            }
            LoadFood();
        }
        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbIdFood.Text);
            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xoá món thành công.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xoá món thất bại.", "Thông báo");
            }
            LoadFood();
        }
        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbIdFood.Text);
            string name = txbNameFood.Text;
            int idCategory = (cbbCategoryFood.SelectedItem as CategoryDTO).Id;
            float price = (float)nudPriceFood.Value;
            if (FoodDAO.Instance.UpdateFood(id, name, idCategory, price))
            {
                MessageBox.Show("Cập nhật món thành công.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Cập nhật món thất bại.", "Thông báo");
            }
            LoadFood();
        }
        #endregion

        #region Table
        private void btnShowTable_Click(object sender, EventArgs e)
        {
            LoadCategory();
        }
        private void btnSearchTable_Click(object sender, EventArgs e)
        {
            string name = txbSearchTable.Text.ToString();
            DataTable dataTable = TableDAO.Instance.GetTableByName(name);
            LoadTable(dataTable);
        }
        private void btnInsertTable_Click(object sender, EventArgs e)
        {
            string name = txbNameTable.Text;
            if (TableDAO.Instance.InsertTable(name))
            {
                MessageBox.Show("Thêm bàn thành công.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm bàn thất bại.", "Thông báo");
            }
            LoadTable();
        }
        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbIdTable.Text);
            if (TableDAO.Instance.DeleteTable(id))
            {
                MessageBox.Show("Xoá bàn thành công.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xoá bàn thất bại.", "Thông báo");
            }
            LoadTable();
        }
        private void btnUpdateTable_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbIdTable.Text);
            string name = txbNameTable.Text;
            if (TableDAO.Instance.UpdateTable(id, name))
            {
                MessageBox.Show("Cập nhật bàn thành công.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Cập nhật bàn thất bại.", "Thông báo");
            }
            LoadTable();
        }
        #endregion

        #region Account
        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }
        private void btnSearchAccount_Click(object sender, EventArgs e)
        {
            string userName = txbSearchAccout.Text;
            DataTable dataTable = AccountDAO.Instance.GetAccountByUserName(userName);
            LoadAccount(dataTable);
        }
        private void btnInsertAccount_Click(object sender, EventArgs e)
        {
            string displayName = txbDisplayName.Text;
            string userName = txbUserName.Text;
            int type = Convert.ToInt32(txbType.Text);
            if (AccountDAO.Instance.InsertAccount(displayName,userName,type))
            {
                MessageBox.Show("Thêm tài khoản thành công.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại.", "Thông báo");
            }
            LoadAccount();
        }
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xoá tài khoản thành công.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xoá tài khoản thất bại.", "Thông báo");
            }
            LoadAccount();
        }
        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            string displayName = txbDisplayName.Text;
            string userName = txbUserName.Text;
            int type = Convert.ToInt32(txbType.Text);
            AccountDTO accountDTO;
            int i;
            for (i = 0; i < dgvAccount.Rows.Count; i++) 
            {
                if (dgvAccount[0, i].Selected || dgvAccount[1, i].Selected || dgvAccount[2, i].Selected)
                {
                    break;
                }
            }
            accountDTO = AccountDAO.Instance.GetAccountByUserNameAbsolute(dgvAccount[1, i].Value.ToString());

            if (AccountDAO.Instance.UpdateAccount(accountDTO, displayName, userName, "", type)) 
            {
                MessageBox.Show("Cập nhật tài khoản thành công.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại.", "Thông báo");
            }
            LoadAccount();
        }
        #endregion

        #endregion

    }
}