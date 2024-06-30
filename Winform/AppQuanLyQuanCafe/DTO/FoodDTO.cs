using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyQuanCafe.DTO
{
    public class FoodDTO
    {
        public FoodDTO(int id, string name, int idCategory, float price)
        {
            this.id = id;
            this.name = name;
            this.idCategory = idCategory;
            this.price = price;
        }

        public FoodDTO(DataRow dataRow)
        {
            this.id = (int)dataRow["id"];
            this.name = dataRow["name"].ToString();
            this.idCategory = dataRow["idCategory"] != DBNull.Value ? (int)dataRow["idCategory"] : 0;
            this.price = (float)Convert.ToDouble(dataRow["price"].ToString());
        }

        private int id;
        private string name;
        private int idCategory;
        private float price;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int IdCategory { get => idCategory; set => idCategory = value; }
        public float Price { get => price; set => price = value; }
    }
}
