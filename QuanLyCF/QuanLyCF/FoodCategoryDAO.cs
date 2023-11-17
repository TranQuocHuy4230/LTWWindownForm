using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCF
{
    class FoodCategoryDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        ketnoi kn = new ketnoi();
        public FoodCategoryDAO()
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
            sql = "SELECT FoodCategory.idCategory,FoodCategory.name FROM FoodCategory";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            apt.Fill(data);
            return data;
        }
        public DataRow getRow(string id)
        {
            string sql = "SELECT FoodCategory.idCategory, FoodCategory.name";
            sql += " FROM FoodCategory WHERE FoodCategory.idCategory='" + id + "'";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            DataRow row = dt.Rows[0];
            return row;
        }
        public void Insert(FoodCategory fc)
        {
            string sql = "INSERT INTO FoodCategory(idCategory,name) VALUES (@IDCATEGORY,@NAME)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@IDCATEGORY", fc.idCategory);
            cmd.Parameters.AddWithValue("@NAME", fc.name);
            cmd.ExecuteNonQuery();
        }
        public void Update(FoodCategory fc)
        {
            string sql = "UPDATE FoodCategory SET name=@NAME WHERE idCategory=@IDCATEGORY";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@IDCATEGORY", fc.idCategory);
            cmd.Parameters.AddWithValue("@NAME", fc.name);
            cmd.ExecuteNonQuery();
        }
        public void Delete(string maf)
        {
            string sql = "DELETE FROM FoodCategory WHERE idCategory=@IDCATEGORY";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@IDCATEGORY", maf);
            cmd.ExecuteNonQuery();

        }
    }
}
