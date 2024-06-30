using AppQuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace AppQuanLyQuanCafe.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }

        private TableDAO() { }

        public static int tableWidth = 90;
        public static int tableHeigth = 90;

        public List<TableDTO> LoadTableList()
        {
            List<TableDTO> tableDTOs = new List<TableDTO>();

            string query = "EXEC GetTableFood";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                TableDTO tableDTO = new TableDTO(row);
                tableDTOs.Add(tableDTO);
            }

            return tableDTOs;
        }

        public DataTable GetTable()
        {
            string query = "EXEC GetTableFood";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }

        public DataTable GetTableByName(string name)
        {
            string query = "EXEC SearchTableFoodByName @name";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { name });
            return dataTable;
        }

        public bool InsertTable(string name, string status = "Trống")
        {
            string query = "EXEC InsertTableFood @name , @status";
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, status });
            return result > 0;
        }

        public bool DeleteTable(int id)
        {
            List<BillDTO> billDTOs = BillDAO.Instance.GetListBillByIdTable(id);
            foreach (BillDTO billDTO in billDTOs)
            {
                BillDAO.Instance.UpdateIdTableBill(billDTO.Id, null);
            }
            string query = "EXEC DeleteTableFood @id";
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result > 0;
        }

        public bool UpdateTable(int id, string name, string status = "Trống")
        {
            string query = "EXEC UpdateTableFood @id , @name , @status";
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, name, status });
            return result > 0;
        }

        public void UpdateTableStatus(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC UpdateTableStatus @id", new object[] { id });
        }

        public void SwapTableStatus(int idTableA, int idTableB)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC SwapTableStatus @TableAId , @TableBId", new object[] { idTableA, idTableB });
        }
    }
}
