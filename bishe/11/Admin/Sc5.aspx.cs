using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Admin_Sc5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request.QueryString["id"].ToString().Trim();
        string sql = string.Format("select * from car where id='{0}'", id);
        DataSet dt = Sql.Daset(sql);
        Model.Jl jl = new Model.Jl
        {
            Cp = dt.Tables[0].Rows[0]["cp"].ToString(),
            Qy = dt.Tables[0].Rows[0]["qy"].ToString(),
            Weizhi = dt.Tables[0].Rows[0]["weizhi"].ToString(),
            Itime = (DateTime)dt.Tables[0].Rows[0]["itime"],
            Otime = DateTime.Now
            
    }; TimeSpan ts = DateTime.Now - (DateTime)dt.Tables[0].Rows[0]["itime"];
        string sql1 = string.Format("select * from car where cp='{0}'  ",jl.Cp);
        SqlDataReader sdr = Sql.Reader(sql1);
        if (sdr.HasRows)
        {
            jl.Pay = string.Format("{0}", ((int)ts.TotalHours + 1) * 4);
            if (int.Parse(jl.Pay)>=30)
            {
                jl.Pay = "30";
            }
            DAL.Car.Ls(jl);
        }
        else
        {
            jl.Pay = string.Format("{0}", ((int)ts.TotalHours + 1) * 10);
            if (int.Parse(jl.Pay) >= 30)
            {
                jl.Pay = "30";
            }
            DAL.Car.Ls(jl);
        }
        string sql2 = string.Format("delete from car where id='{0}'",id);
        Sql.NonQuery(sql2);
        Alert.AlertAndRedirect("车辆离开", "CommodityInfoManger.aspx");
    } 
}