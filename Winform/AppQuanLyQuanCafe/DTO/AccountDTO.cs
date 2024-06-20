using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyQuanCafe.DTO
{
    public class AccountDTO
    {
        public AccountDTO(string displayName, string userName, int type, string passWord = null)
        {
            this.displayName = displayName;
            this.userName = userName;
            this.passWord = passWord;
            this.type = type;
        }

        public AccountDTO(DataRow dataRow)
        {
            this.displayName = dataRow["displayName"].ToString();
            this.userName = dataRow["userName"].ToString();
            this.type = (int)dataRow["type"];
            this.passWord = dataRow["passWord"].ToString();
        }

        private string displayName;
        private string userName;
        private string passWord;
        private int type;

        public string DisplayName { get => displayName; set => displayName = value; }
        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public int Type { get => type; set => type = value; }
    }
}
