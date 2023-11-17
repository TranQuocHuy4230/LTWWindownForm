using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCF
{
    class BillInfoDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        ketnoi kn = new ketnoi();
        public BillInfoDAO()
        {
            conn = kn.getconnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public DataTable LoadBInfoList()
        {
            string sql = null;
            sql = "SELECT BillInfo.idInfo,BillInfo.idBill,Food.name AS FoodName,BillInfo.COUNT,Food.price*BillInfo.COUNT AS Price  FROM BillInfo";
            sql += " INNER JOIN Food ON BillInfo.idFood=Food.idFood";
            //
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            apt.Fill(data);
            return data;
        }
    }
}
