using AppQuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AppQuanLyQuanCafe.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            private set { BillInfoDAO.instance = value; }
        }

        private BillInfoDAO() { }

        public List<BillInfoDTO> GetListBillInfo(int id)
        {
            List<BillInfoDTO> billInfoDTOs = new List<BillInfoDTO>();
            string query = "SELECT * FROM BillInfo WHERE idBill = " + id;
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                BillInfoDTO billInfoDTO = new BillInfoDTO(row);
                billInfoDTOs.Add(billInfoDTO);
            }
            return billInfoDTOs;
        }

        public bool InsertBillInfo(int idBill, int idFood, int count)
        {
            int result = (int)DataProvider.Instance.ExecuteNonQuery("EXEC InsertBillInfo @idBill , @idFood , @count", new object[] { idBill, idFood, count });
            return result > 0;
        }

        public bool UpdateBillInfo(int id, int idBill, int? idFood, int count)
        {
            string query = "EXEC UpdateBillInfo @id , @idBill , @idFood , @count";
            int result;
            if (idFood == null)
                result = (int)DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, idBill, DBNull.Value, count });
            else
                result = (int)DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, idBill, idFood, count });
            return result > 0;
        }

        public List<BillInfoDTO> GetListBillInfoByIdFood(int idFood)
        {
            List<BillInfoDTO> billInfoDTOs = new List<BillInfoDTO>();
            string query = "EXEC SearchBillInfoByIdFood @idFood";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { idFood });
            foreach (DataRow row in dataTable.Rows)
            {
                BillInfoDTO billInfoDTO = new BillInfoDTO(row);
                billInfoDTOs.Add(billInfoDTO);
            }
            return billInfoDTOs;
        }
    }
}
