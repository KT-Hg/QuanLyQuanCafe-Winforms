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
    public partial class frmTableManager : Form
    {
        public frmTableManager()
        {
            InitializeComponent();
            loadTable();
        }

        private void frmTableManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        #region Method

        void loadTable()
        {
            List<TableDTO> tableDTOs = TableDAO.Instance.LoadTableList();
            foreach (TableDTO tableDTO in tableDTOs) 
            {
                Button button = new Button() { Width = TableDAO.tableWidth, Height = TableDAO.tableHeigth };
                button.Text = tableDTO.Name + Environment.NewLine + tableDTO.Status;
                button.Click += btn_Click;
                button.Tag = tableDTO;
                flpTable.Controls.Add(button);
            }
        }

        void showBill(int id)
        {

        }
        

        #endregion

        #region Event
        private void btn_Click(object sender, EventArgs e)
        {
            int tableId=(sender as TableDTO).Id;
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
        #endregion
    }
}


