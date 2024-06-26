using AppQuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        public DataTable GetListFood()
        {
            string query = "EXEC GetAllFood";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }

        public FoodDTO GetFood(int id)
        {
            FoodDTO foodDTO;
            string query = "EXEC SearchFoodById @id";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            foodDTO = new FoodDTO(dataTable.Rows[0]);
            return foodDTO;
        }

        public bool InsertFood(string name, int idCategory, float price)
        {
            string query = "EXEC InsertFood @name , @idCategory , @price";
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, idCategory, price });
            return result > 0;
        }

        public bool DeleteFood(int id) 
        {
            string query = "EXEC DeleteFood @id";
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result > 0;
        }


    }
}
