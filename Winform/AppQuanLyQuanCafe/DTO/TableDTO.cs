using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyQuanCafe.DTO
{
    public class TableDTO
    {
        public TableDTO(int id,string name, string staus) 
        {
            this.id = id;
            this.name = name;
            this.status = staus;
        }

        public TableDTO(DataRow dataRow) 
        {
            this.id = (int)dataRow["id"];
            this.name = (string)dataRow["name"];
            this.status = (string)dataRow["status"];
        }

        private int id;
        private string name;
        private string status;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
    }
}
