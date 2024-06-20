using AppQuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyQuanCafe.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
            private set { CategoryDAO.instance = value; }
        }

        private CategoryDAO() { }

        public List<FoodCategoryDTO> getListCategory()
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
