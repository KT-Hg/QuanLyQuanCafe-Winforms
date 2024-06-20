using AppQuanLyQuanCafe.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public AccountDTO GetAccountByUserName(string userName)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("SELECT * FROM Account WHERE [userName] = @userName", new object[] { userName });
            foreach (DataRow row in dataTable.Rows)
            {
                return new AccountDTO(row);
            }

            return null;
        }


    }
}
