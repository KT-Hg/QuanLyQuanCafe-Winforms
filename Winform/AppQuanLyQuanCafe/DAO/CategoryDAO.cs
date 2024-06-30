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

        public List<CategoryDTO> GetListCategory()
        {
            List<CategoryDTO> categoryDTOs = new List<CategoryDTO>();
            string query = "SELECT * FROM FoodCategory";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                CategoryDTO categoryDTO = new CategoryDTO(row);
                categoryDTOs.Add(categoryDTO);
            }
            return categoryDTOs;
        }

        public DataTable GetCategory()
        {
            string query = "SELECT * FROM FoodCategory";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }

        public DataTable GetCategoryByName(string name) 
        {
            string query = "EXEC SearchFoodCategoryByName @name";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { name });
            return dataTable;
        }

        public bool InsertCategory(string name)
        {
            string query = "EXEC InsertFoodCategory @name";
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query, new object[] { name});
            return result > 0;
        }

        public bool DeleteCategory(int id)
        {
            List<FoodDTO> foodDTOs = FoodDAO.Instance.GetListFoodByCategoryId(id);
            foreach (FoodDTO foodDTO in foodDTOs)
            {
                FoodDAO.Instance.UpdateFood(foodDTO.Id, foodDTO.Name, null, foodDTO.Price);
            }
            string query = "EXEC DeleteFoodCategory @id";
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result > 0;
        }

        public bool UpdateCategory(int id, string name)
        {
            string query = "EXEC UpdateFoodCategory @id , @name";
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, name});
            return result > 0;
        }
    }
}
