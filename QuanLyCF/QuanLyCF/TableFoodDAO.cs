using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCF
{
    class TableFoodDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        ketnoi kn = new ketnoi();

        public static int TableWidth = 90;
        public static int TableHeight = 90;

        public TableFoodDAO()
        {
            conn = kn.getconnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public DataTable LoadTableList()
        {
            string sql = null;
            sql = "SELECT TableFood.idTable,TableFood.name,TableFood.status FROM TableFood";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            apt.Fill(data);
            return data;
        }
        public DataRow getRow(string id)
        {
            string sql = "SELECT TableFood.idTable,TableFood.idTable, TableFood.name";
            sql += " FROM TableFood WHERE TableFood.idTable='" + id + "'";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            DataRow row = dt.Rows[0];
            return row;
        }
        public void Insert(TableFood tbf)
        {
            string sql = "INSERT INTO TableFood(idTable,name,status) VALUES (@IDTABLE,@NAME,@STATUS)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@IDTABLE", tbf.idTable);
            cmd.Parameters.AddWithValue("@NAME", tbf.name);
            cmd.Parameters.AddWithValue("@STATUS", tbf.status);
            cmd.ExecuteNonQuery();
        }
        public void Update(TableFood tbf)
        {
            string sql = "UPDATE TableFood SET name=@NAME,status=@STATUS WHERE idTable=@IDTABLE";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@IDTABLE", tbf.idTable);
            cmd.Parameters.AddWithValue("@NAME", tbf.name);
            cmd.Parameters.AddWithValue("@STATUS", tbf.status);

            cmd.ExecuteNonQuery();
        }
        public void Delete(string maf)
        {
            string sql = "DELETE FROM TableFood WHERE idTable=@IDTABLE";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@IDTABLE", maf);
            cmd.ExecuteNonQuery();
        }
        
    }
}
