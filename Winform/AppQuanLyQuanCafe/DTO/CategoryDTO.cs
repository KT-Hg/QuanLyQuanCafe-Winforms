using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyQuanCafe.DTO
{
    public class CategoryDTO
    {
        public CategoryDTO(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public CategoryDTO(DataRow dataRow)
        {
            this.id = (int)dataRow["id"];
            this.name = dataRow["name"].ToString();
        }

        private int id;
        private string name;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
