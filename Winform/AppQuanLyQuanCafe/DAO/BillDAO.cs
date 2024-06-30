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
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }

        public int GetUncheckBillIdByTableId(int tableId)
        {
            string query = "SELECT * FROM Bill WHERE idTable = " + tableId + " AND status = 0";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            if (dataTable.Rows.Count > 0)
            {
                BillDTO billDTO = new BillDTO(dataTable.Rows[0]);
                return billDTO.Id;
            }
            return -1;
        }

        public DataTable GetListBillByDate(DateTime startDate, DateTime endDate) 
        {
            DataTable dataTable;
            dataTable = DataProvider.Instance.ExecuteQuery("EXEC GetListBillByDate @StartDate , @EndDate", new object[] { startDate, endDate });
            return dataTable;
        }

        public void InsertBill(int idTable)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC InsertBill @idTable", new object[] { idTable });
        }

        public int GetMaxIdBill()
        {
            return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM Bill");
        }

        public void UpdateBill(int id, int discount = 0, float totalPrice = 0)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC UpdateBill @id , @discount , @totalPrice", new object[] { id , discount , totalPrice});
        }

        public void SwapBill(int idTableA, int idTableB)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC SwapTableBill @TableAId , @TableBId", new object[] { idTableA, idTableB });
        }

        public bool UpdateIdTableBill(int id, int? idTable)
        {
            string query = "EXEC UpdateIdTableBill @id , @idTable";
            int result;
            if (idTable == null)
                result = (int)DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, DBNull.Value });
            else
                result = (int)DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, idTable });
            
            return result > 0;
        }

        public List<BillDTO> GetListBillByIdTable(int idTable) 
        {
            List<BillDTO> billDTOs = new List<BillDTO>();
            string query = "EXEC GetBillByIdTable @idTable";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { idTable });
            foreach (DataRow row in dataTable.Rows)
            {
                BillDTO billDTO = new BillDTO(row);
                billDTOs.Add(billDTO);
            }
            return billDTOs;
        }
    }
}
