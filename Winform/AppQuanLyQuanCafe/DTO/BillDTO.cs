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
        public BillDTO(int id, DateTime dateCheckIn, DateTime? dateCheckOut, int idTable, int status)
        {
            this.id = id;
            this.dateCheckIn = dateCheckIn;
            this.dateCheckOut = dateCheckOut;
            this.idTable = idTable;
            this.status = status;
        }

        public BillDTO(DataRow dataRow)
        {
            this.id = (int)dataRow["id"];
            this.dateCheckIn = (DateTime)dataRow["dateCheckIn"];
            this.dateCheckOut = dataRow["dateCheckOut"] != DBNull.Value ? (DateTime?)dataRow["dateCheckOut"] : null;
            this.idTable = (int)dataRow["idTable"];
            this.status = (int)dataRow["status"];
        }

        private int id;
        private DateTime dateCheckIn;
        private DateTime? dateCheckOut;
        private int idTable;
        private int status;

        public int Id{ get => id; set => id = value; }

        public DateTime DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }

        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }

        public int IdTable { get => idTable; set => idTable = value; }

        public int Status { get => status; set => status = value; }
    }
}