using AppQuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyQuanCafe.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }

        private MenuDAO() { }

        public List<MenuDTO> GetListMenuByTable(int id) 
        {
            List<MenuDTO> menuDTOs = new List<MenuDTO>();
            string query = "SELECT f.name, bi.count, f.price, f.price * bi.count AS totalPrice FROM dbo. BillInfo AS bi, dbo. Bill AS b, dbo. Food AS f " +
                "WHERE bi.idBill = b.id AND bi.idFood = f.id AND b.status = 0 AND b.idTable = " + id;
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                MenuDTO menuDTO = new MenuDTO(row);
                menuDTOs.Add(menuDTO);
            }
            return menuDTOs;
        }
    }
}
