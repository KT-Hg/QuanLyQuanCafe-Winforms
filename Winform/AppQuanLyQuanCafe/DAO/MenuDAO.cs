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

        public List<MenuDTO> GetListMenuByTable(int idTable) 
        {
            List<MenuDTO> menuDTOs = new List<MenuDTO>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("EXEC GetListMenuByTable @idTable", new object[] {idTable});
            foreach (DataRow row in dataTable.Rows)
            {
                MenuDTO menuDTO = new MenuDTO(row);
                menuDTOs.Add(menuDTO);
            }
            return menuDTOs;
        }
    }
}
