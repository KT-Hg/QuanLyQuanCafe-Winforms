using AppQuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyQuanCafe.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;
        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            private set { FoodDAO.instance = value; }
        }

        private FoodDAO() { }

        public List<FoodDTO> GetListFoodByCategoryId(int categoryId)
        {
            List<FoodDTO> foodDTOs = new List<FoodDTO>();
            string query = "SELECT * FROM Food WHERE idCategory = " + categoryId;
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                FoodDTO foodDTO = new FoodDTO(row);
                foodDTOs.Add(foodDTO);
            }
            return foodDTOs;
        }
    }
}
