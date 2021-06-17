using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Sql 的摘要说明
/// </summary>
public class Sql
{
   
         public static string sql = ConfigurationManager.ConnectionStrings["Bishe"].ConnectionString;
    public static string sql1 = "Data Source=.;Initial Catalog=Bishe;Integrated Security=True";
    public static int NonQuery(string sql)
    {
        SqlConnection con = new SqlConnection(Sql.sql);
        con.Open();
        SqlCommand cmd = new SqlCommand(sql, con);
        int row = cmd.ExecuteNonQuery();
        con.Close();
        return row;

    }
    public static SqlDataReader Reader(string sql)
    {
        SqlConnection con = new SqlConnection(Sql.sql);
        con.Open();
        SqlCommand cmd = new SqlCommand(sql, con);
        return cmd.ExecuteReader();

    }
    public static int Scalar(string sql)
    {
        SqlConnection con = new SqlConnection(Sql.sql);
        con.Open();
        SqlCommand cmd = new SqlCommand(sql, con);

        return (int)cmd.ExecuteScalar();
    }
    public static DataSet Daset(string sql)
    {
        SqlConnection con = new SqlConnection(Sql.sql);
        DataSet ds = new DataSet();

        SqlDataAdapter dap = new SqlDataAdapter(sql, con);
        dap.Fill(ds);
        con.Close();
        return ds;

    }

}
    
