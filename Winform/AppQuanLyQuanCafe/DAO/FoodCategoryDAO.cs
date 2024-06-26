using AppQuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyQuanCafe.DAO
{
    public class FoodCategoryDAO
    {
        private static FoodCategoryDAO instance;

        public static FoodCategoryDAO Instance
        {
            get { if (instance == null) instance = new FoodCategoryDAO(); return FoodCategoryDAO.instance; }
            private set { FoodCategoryDAO.instance = value; }
        }

        private FoodCategoryDAO() { }

        public List<FoodCategoryDTO> GetListCategory()
        {
            List<FoodCategoryDTO> foodCategoryDTOs = new List<FoodCategoryDTO>();
            string query = "SELECT * FROM FoodCategory";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                FoodCategoryDTO foodCategoryDTO = new FoodCategoryDTO(row);
                foodCategoryDTOs.Add(foodCategoryDTO);
            }
            return foodCategoryDTOs;
        }
    }
}
