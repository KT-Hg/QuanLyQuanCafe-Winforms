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
    public partial class frmAccountProfile : Form
    {
        private AccountDTO accountDTO;

        public frmAccountProfile(AccountDTO accountDTO)
        {
            InitializeComponent();
            this.accountDTO = accountDTO;
            LoadInfomation(accountDTO);
        }

        void LoadInfomation(AccountDTO accountDTO)
        {
            txbUserName.Text = accountDTO.UserName;
            txbDisplayName.Text = accountDTO.DisplayName;
            txbPassWord.Text = accountDTO.PassWord;
            txbNewPassWord.Text = "";
            txbConfirmNewPassWord.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txbNewPassWord.Text != txbConfirmNewPassWord.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu không khớp với mật khẩu mới.", "Thông báo");
                LoadInfomation(accountDTO);
                return;
            }
            
            if(AccountDAO.Instance.UpdateAccount(accountDTO, txbDisplayName.Text, txbUserName.Text, txbNewPassWord.Text,null))
            {
                MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo");
                accountDTO = AccountDAO.Instance.GetAccountByUserNameAbsolute(txbUserName.Text);
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại.", "Thông báo");
            }
            LoadInfomation(accountDTO);
        }
    }
}
