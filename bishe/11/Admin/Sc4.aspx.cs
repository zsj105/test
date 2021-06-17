using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Admin_Sc4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request.QueryString["id"].ToString().Trim();
        string sql = string.Format("select * from car where id='{0}'",id);
        DataSet dt = Sql.Daset(sql);
        Model.Jl jl = new Model.Jl();

       jl.Cp = dt.Tables[0].Rows[0]["cp"].ToString();
        jl.Qy = dt.Tables[0].Rows[0]["qy"].ToString();
        jl.Weizhi = dt.Tables[0].Rows[0]["weizhi"].ToString();
        jl.Itime = (DateTime)dt.Tables[0].Rows[0]["itime"];
        jl.Otime = DateTime.Now;
        jl.Pay = "0";
        string sql1 = string.Format("delete from car where id='{0}'", id);
        Sql.NonQuery(sql1);
       int row= DAL.Car.Ls(jl);
        if (row>0)
        {
            Alert.AlertAndRedirect("车辆离开", "CommodityInfoManger.aspx");
        }

    }
}