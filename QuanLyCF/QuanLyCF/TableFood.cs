using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCF
{
    class TableFood
    {
        public int idTable { get; set; }
        public string name { get; set; }
        public string status { get; set; }
       
        public TableFood(int id,string n, string s)
        {
            this.idTable = id;
            this.name = n;
            this.status = s;
        }
        public TableFood(DataRow row)
        {
            this.idTable = (int)row["id"];
            this.name = row["n"].ToString();
            this.status = row["s"].ToString();

        }
    }
}
