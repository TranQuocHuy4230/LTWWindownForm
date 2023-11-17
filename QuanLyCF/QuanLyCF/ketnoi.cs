using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCF
{
    class ketnoi
    {
        String sqlConnect;
        public ketnoi()
        {
            sqlConnect = ConfigurationManager.ConnectionStrings["ChuoiKN"].ToString();
        }
        public SqlConnection getconnect()
        {
            SqlConnection conn = new SqlConnection(sqlConnect);
            return conn; 
        }
    }
}
