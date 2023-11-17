using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCF
{
    class FoodDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        ketnoi kn = new ketnoi();
        public FoodDAO()
        {
            conn = kn.getconnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public DataTable LoadFoodList()
        {
            string sql = null;
            sql = "SELECT Food.idFood,Food.name,FoodCategory.name AS CateName,Food.price  FROM Food";
            sql += " INNER JOIN FoodCategory ON Food.idCategory=FoodCategory.idCategory";
            //
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            apt.Fill(data);
            return data;
        }
        public DataRow getRow(string id)
        {
            string sql = "SELECT Food.idFood, Food.name, Food.idCategory, Food.price";
            sql += " FROM Food INNER JOIN FoodCategory ON FoodCategory.idCategory=Food.idCategory WHERE Food.idFood='" + id + "'";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            DataRow row = dt.Rows[0];
            return row;
        }
        public void Insert(Food f)
        {
            string sql = "INSERT INTO Food(idFood,name,idCategory,price) VALUES (@IDFOOD,@NAME,@IDCATEGORY,@PRICE)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@IDFOOD", f.idFood);
            cmd.Parameters.AddWithValue("@NAME", f.name);
            cmd.Parameters.AddWithValue("@IDCATEGORY", f.idCategory);
            cmd.Parameters.AddWithValue("@PRICE", f.price);
            cmd.ExecuteNonQuery();
        }
        public void Update(Food f)
        {
            string sql = "UPDATE Food SET name=@NAME, idCategory=@IDCATEGORY, price=@PRICE WHERE idFood=@IDFOOD";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@IDFOOD", f.idFood);
            cmd.Parameters.AddWithValue("@NAME", f.name);
            cmd.Parameters.AddWithValue("@IDCATEGORY", f.idCategory);
            cmd.Parameters.AddWithValue("@PRICE", f.price);
            cmd.ExecuteNonQuery();
        }
        public void Delete(string maf)
        {
            string sql = "DELETE FROM Food WHERE idFood=@IDFOOD";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@IDFOOD", maf);
            cmd.ExecuteNonQuery();

        }
        public DataTable Id()
        {
            string sql = "SELECT Food.idFood FROM Food";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            apt.Fill(data);
            return data;
        }
    }
}
