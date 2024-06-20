using AppQuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void insertBill(int idTable)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC InsertBill @idTable", new object[] { idTable });
        }

        public int getMaxIdBill()
        {
            return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM Bill");
        }

        public void updateBill(int id, int discount = 0)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC UpdateBill @id , @discount", new object[] { id , discount });
        }

        public void swapBill(int idTableA, int idTableB)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC SwapTableBill @TableAId , @TableBId", new object[] { idTableA, idTableB });
        }
    }
}
