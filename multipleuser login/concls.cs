using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace multipleuser_login
{


    public class concls
    {
        SqlConnection con;
        SqlCommand cmd;

        public concls()
        {
            con = new SqlConnection(@"server=SASIKALA\SQLEXPRESS;database=DBDec;Integrated security=true");

        }
        public int Fun_Non_Query(string sql)
        {
            cmd = new SqlCommand(sql, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public string Fn_Scalar(string sql)
        {
            
            cmd = new SqlCommand(sql, con);
            con.Open();
            string i = cmd.ExecuteScalar().ToString();
            con.Close();
            return i;
        }
    }
}