using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace AppQuanLyQuanCafe
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = null;

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(@"Data Source=HG;Initial Catalog=QLSV;Integrated Security=True");
            }
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            string username = txbUserName.Text.Trim();
            string password = txbPassWord.Text.Trim();

            /*SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            string querySinhVien = "SELECT COUNT(*) FROM SINHVIEN WHERE TENDN = @Username AND MATKHAU = 0x" + CalculateSHA1(password);
            SqlCommand commandSinhVien = new SqlCommand(querySinhVien, sqlConnection);
            commandSinhVien.Parameters.AddWithValue("@Username", username);
            int countSinhVien = (int)commandSinhVien.ExecuteScalar();


            string queryNhanVien = "SELECT COUNT(*) FROM NHANVIEN WHERE TENDN = @Username AND MATKHAU = 0x" + CalculateSHA1(password);
            SqlCommand commandNhanVien = new SqlCommand(queryNhanVien, sqlConnection);
            commandNhanVien.Parameters.AddWithValue("@Username", username);
            int countNhanVien = (int)commandNhanVien.ExecuteScalar();

            if (countSinhVien > 0 || countNhanVien > 0)*/
            if (true)
            {
                MessageBox.Show("Đăng Nhập Thành Công");
                frmTableManager frmTableManager = new frmTableManager();
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
    }   
}
