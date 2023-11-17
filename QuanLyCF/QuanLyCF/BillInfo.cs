using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCF
{
    class BillInfo
    {
        public int idInfo { get; set; }
        public int idBill { get; set; }
        public int idFood { get; set; }
        public int COUNT { get; set; }
        public BillInfo(int idI,int idB,int idF,int count)
        {
            this.idInfo = idI;
            this.idBill = idB;
            this.idFood = idF;
            this.COUNT = count;
        }
    }
}
