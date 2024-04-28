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

            // Convert the password string to byte array
            byte[] inputBytes = Encoding.Unicode.GetBytes(input);

            // Create a new instance of SHA1 algorithm
            using (SHA1 sha1 = SHA1.Create())
            {
                // Compute the hash value of the password bytes
                byte[] hashBytes = sha1.ComputeHash(inputBytes);

                // Convert the byte array to a hexadecimal string
                string hashedInput = BitConverter.ToString(hashBytes).Replace("-", "").ToUpper();

                // Print the hashed password
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

            string username = txbUserName.Text.Trim(); // Thay thế bằng tên đăng nhập được cung cấp
            string password = txbPassWord.Text.Trim(); // Thay thế bằng mật khẩu được cung cấp

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            string querySinhVien = "SELECT COUNT(*) FROM SINHVIEN WHERE TENDN = @Username AND MATKHAU = 0x" + CalculateSHA1(password);
            SqlCommand commandSinhVien = new SqlCommand(querySinhVien, sqlConnection);
            commandSinhVien.Parameters.AddWithValue("@Username", username);
            int countSinhVien = (int)commandSinhVien.ExecuteScalar();

            // Kiểm tra xem có tồn tại trong bảng NHANVIEN không
            string queryNhanVien = "SELECT COUNT(*) FROM NHANVIEN WHERE TENDN = @Username AND MATKHAU = 0x" + CalculateSHA1(password);
            SqlCommand commandNhanVien = new SqlCommand(queryNhanVien, sqlConnection);
            commandNhanVien.Parameters.AddWithValue("@Username", username);
            int countNhanVien = (int)commandNhanVien.ExecuteScalar();

            if (countSinhVien > 0 || countNhanVien > 0)
            {
                MessageBox.Show("Đăng Nhập Thành Công");
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
    }
}
