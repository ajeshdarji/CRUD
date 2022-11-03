using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace CRUD
{
    public class ConnectionClass
    {
        SqlConnection con;
        public ConnectionClass()
        {
            con = new SqlConnection(@"server=DESKTOP-2MGREGR\SQLEXPRESS; database=CRUD;Integrated security = true");
        }
        public int Fn_Executenonquery(String sqlquery)
        {
            SqlCommand cmd = new SqlCommand(sqlquery, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public String Fn_ExecuteScalar(String sqlquery)
        {
            SqlCommand cmd = new SqlCommand(sqlquery, con);
            con.Open();
            String s = cmd.ExecuteScalar().ToString();
            con.Close();
            return s;
        }
        public DataSet Exce_DataSet(String sqlquery)
        {
            SqlDataAdapter da = new SqlDataAdapter(sqlquery, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

    }
}