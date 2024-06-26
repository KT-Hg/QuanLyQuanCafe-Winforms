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

namespace AppQuanLyQuanCafe
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            LoadIncomeByDate();
            LoadFood();
            LoadCategory();
        }

        #region Method

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
        }

        void LoadCategory()
        {
            List<FoodCategoryDTO> foodCategoryDTOs;
            foodCategoryDTOs = FoodCategoryDAO.Instance.GetListCategory();
            cbbCategoryFood.DataSource = foodCategoryDTOs;
            cbbCategoryFood.DisplayMember = "name";
        }

        void FoodBinding()
        {
            txbIdFood.DataBindings.Clear();
            txbNameFood.DataBindings.Clear();
            nudPriceFood.DataBindings.Clear();
            txbIdFood.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "Id"));
            txbNameFood.DataBindings.Add(new Binding("Text",dgvFood.DataSource, "Tên món"));
            nudPriceFood.DataBindings.Add(new Binding("Value", dgvFood.DataSource, "Giá"));
            
        }

        #endregion

        #region Event

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            LoadIncomeByDate();
        }

        private void btnShowFood_Click(object sender, EventArgs e)
        {
            LoadFood();
        }

        private void btnInsertFood_Click(object sender, EventArgs e)
        {
            string name = txbNameFood.Text;
            int idCategory = (cbbCategoryFood.SelectedItem as FoodCategoryDTO).Id;
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

        private void txbIdFood_TextChanged(object sender, EventArgs e)
        {
            FoodDTO foodDTO = FoodDAO.Instance.GetFood(Convert.ToInt32(txbIdFood.Text));
            foreach (FoodCategoryDTO foodCategoryDTO in cbbCategoryFood.Items)
            {
                if(foodCategoryDTO.Id==foodDTO.IdCategory)
                {
                    cbbCategoryFood.SelectedItem = foodCategoryDTO;
                }
            }
            
        }

        #endregion

    }
}
