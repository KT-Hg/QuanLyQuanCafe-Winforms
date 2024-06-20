using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyQuanCafe.DTO
{
    public class MenuDTO
    {
        public MenuDTO(string foodName, int count, float price, float totalPrice = 0)
        {
            this.foodName = foodName;
            this.count = count;
            this.price = price;
            this.totalPrice = totalPrice;
        }

        public MenuDTO(DataRow dataRow)
        {
            this.foodName = dataRow["name"].ToString();
            this.count = (int)dataRow["count"];
            this.price = (float)Convert.ToDouble(dataRow["price"].ToString());
            this.totalPrice = (float)Convert.ToDouble(dataRow["totalPrice"].ToString());
        }

        private string foodName;
        private int count;
        private float price;
        private float totalPrice;

        public string FoodName { get => foodName; set => foodName = value; }

        public int Count { get => count; set => count = value; }

        public float Price { get => price; set => price = value; }

        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
