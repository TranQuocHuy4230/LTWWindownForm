using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCF
{
    class AccountDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        ketnoi kn = new ketnoi();
        public AccountDAO()
        {
            conn = kn.getconnect();
            if(conn.State==ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public String checkPassword(string password)
        {
            string sql = "SELECT Account.UserName, Account.Password FROM Account WHERE Account.Password='" + password + "'";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                string result = row["Password"].ToString();
                return result;
            }
            else
                return null;
        }
        public String checkAccount(string username)
        {
            string sql = "SELECT Account.UserName, Account.Password FROM Account WHERE Account.UserName='" + username + "'";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                string result = row["UserName"].ToString();
                return result;
            }
            else
                return null;
        }
        public String checkDisplayName(string displayname)
        {
            string sql = "SELECT Account.DisplayName FROM Account WHERE Account.DisplayName='" + displayname + "'";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                string result = row["DisplayName"].ToString();
                return result;
            }
            else
                return null;
        }
        public DataTable LoadAccList()
        {
            string sql = null;
            sql = "SELECT Account.Displayname,Account.UserName,Account.Password FROM Account";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            apt.Fill(data);
            return data;
        }
        public void Update(Account acc)
        {
            string sql = "UPDATE Account SET Password=@PASSWORD";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@NAME", acc.Password);

            cmd.ExecuteNonQuery();
        }
    }
}
