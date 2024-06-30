using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyQuanCafe.DTO
{
    public class BillInfoDTO
    {
        public BillInfoDTO(int id, int idBill, int idFood, int count)
        {
            this.Id = id;
            this.IdBill = idBill;
            this.IdFood = idFood;
            this.count = count;
        }

        public BillInfoDTO(DataRow dataRow) 
        {
            this.id = (int)dataRow["id"];
            this.idBill = (int)dataRow["idBill"];
            this.idFood = dataRow["idFood"] != DBNull.Value ? (int)dataRow["idFood"] : 0;
            this.count = (int)dataRow["count"];
        }

        private int id;
        private int idBill;
        private int idFood;
        private int count;

        public int Id { get => id; set => id = value; }

        public int IdBill { get => idBill; set => idBill = value; }

        public int IdFood { get => idFood; set => idFood = value; }

        public int Count { get => count; set => count = value; }

        
    }
}
