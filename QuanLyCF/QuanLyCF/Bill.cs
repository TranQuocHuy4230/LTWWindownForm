using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCF
{
    class Bill
    {
        public int idBill { get; set; }
        public string DateCheckIn { get; set; }
        public int idTable { get; set; }
        public int status { get; set; }
        public Bill(int idB,int idT,int Status)
        {
            this.idBill = idB;
            this.idTable = idT;
            this.status = Status;
        }
    }
}
