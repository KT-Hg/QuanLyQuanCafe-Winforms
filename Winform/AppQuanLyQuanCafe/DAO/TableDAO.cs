using AppQuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public List<TableDTO> loadTableList()
        {
            List<TableDTO> tableDTOs = new List<TableDTO>();

            string query = "EXEC GetTableFood";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                TableDTO tableDTO = new TableDTO(row);
                tableDTOs.Add(tableDTO);
            }

            return tableDTOs;
        }
    }
}
