using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using AppQuanLyQuanCafe.DAO;
using AppQuanLyQuanCafe.DTO;

namespace AppQuanLyQuanCafe
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        #region Method

        private string CalculateSHA1(string input)
        {
            byte[] inputBytes = Encoding.Unicode.GetBytes(input);
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] hashBytes = sha1.ComputeHash(inputBytes);
                string hashedInput = BitConverter.ToString(hashBytes).Replace("-", "").ToUpper();
                return hashedInput;
            }
        }

        #endregion

        #region Event

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            string password = txbPassWord.Text;

            if (AccountDAO.Instance.Login(username, password)) 
            {
                frmTableManager frmTableManager = new frmTableManager(AccountDAO.Instance.GetAccountByUserNameAbsolute(username));
                this.Hide();
                frmTableManager.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không hợp lệ");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình.", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        #endregion
    }
}
