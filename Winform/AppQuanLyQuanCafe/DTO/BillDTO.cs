﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyQuanCafe.DTO
{
    public class BillDTO
    {
        public BillDTO(int id, DateTime dateCheckIn, DateTime? dateCheckOut, int idTable, int status, int discount, float totalPrice)
        {
            this.id = id;
            this.dateCheckIn = dateCheckIn;
            this.dateCheckOut = dateCheckOut;
            this.idTable = idTable;
            this.status = status;
            this.discount = discount;
            this.totalPrice = totalPrice;
        }

        public BillDTO(DataRow dataRow)
        {
            this.id = (int)dataRow["id"];
            this.dateCheckIn = (DateTime)dataRow["dateCheckIn"];
            this.dateCheckOut = dataRow["dateCheckOut"] != DBNull.Value ? (DateTime?)dataRow["dateCheckOut"] : null;
            this.idTable = dataRow["idTable"] != DBNull.Value ? (int)dataRow["idTable"] : 0;
            this.status = (int)dataRow["status"];
            this.discount = (int)dataRow["discount"];
            this.totalPrice = (float)Convert.ToDouble(dataRow["totalPrice"].ToString());
        }

        private int id;
        private DateTime dateCheckIn;
        private DateTime? dateCheckOut;
        private int idTable;
        private int status;
        private int discount;
        private float totalPrice;

        public int Id{ get => id; set => id = value; }

        public DateTime DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }

        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }

        public int IdTable { get => idTable; set => idTable = value; }

        public int Status { get => status; set => status = value; }

        public int Discount { get => discount; set => discount = value; }

        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
