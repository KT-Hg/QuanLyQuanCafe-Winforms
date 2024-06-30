using AppQuanLyQuanCafe.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyQuanCafe.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }
        }

        private AccountDAO() { }
        
        public bool Login(string userName, string passWord)
        {
            int result = (int)DataProvider.Instance.ExecuteScalar("EXEC LoginAccount @userName , @passWord", new object[] { userName, passWord });
            return result > 0;
        }

        public AccountDTO GetAccountByUserNameAbsolute(string userName)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("SELECT * FROM Account WHERE [userName] = @userName", new object[] { userName });
            foreach (DataRow row in dataTable.Rows)
            {
                return new AccountDTO(row);
            }

            return null;
        }
        public DataTable GetAccountByUserName(string userName)
        {
            DataTable dataTable = new DataTable();
            string query = "EXEC SearchAccountByUserName @userName";
            dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { userName });
            return dataTable;
        }
        public DataTable GetAccount()
        {
            string query = "EXEC GetAccount";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }

        public bool UpdateAccount(AccountDTO accountDTO, string displayName, string userName, string passWord, int? type)
        {
            if(accountDTO == null) accountDTO = GetAccountByUserNameAbsolute(userName);
            if(type == null) type = accountDTO.Type;
            if (passWord == "")
            {
                passWord = accountDTO.PassWord;
            }


            try 
            {
                int result = (int)DataProvider.Instance.ExecuteNonQuery("EXEC UpdateAccount @userNameOld , @passWordOld , @displayNameNew , @userNameNew , @passWordNew , @type"
                    , new object[] { accountDTO.UserName, accountDTO.PassWord, displayName, userName, passWord, type});
                return (result > 0);
            }
            catch 
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại.", "Thông báo");
                return false;
            }
        }
        
        public bool InsertAccount(string displayName, string userName, int type)
        {
            string query = "EXEC InsertAccount @displayName , @userName , @type";
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query, new object[] { displayName, userName, type });
            return result > 0;
        }

        public bool DeleteAccount(string userName)
        {
            string query = "EXEC DeleteAccount @userName";
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName });
            return result > 0;
        }
    }
}
