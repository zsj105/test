using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Admin_Dm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Model.Car car = new Model.Car();
        car.Cp = DropDownList1.SelectedValue;
        car.Qy = "地下";
        string sql = string.Format("select cw from yz where cp='{0}'",DropDownList1.SelectedValue);
        DataSet ds = Sql.Daset(sql);
        car.Weizhi = ds.Tables[0].Rows[0]["cw"].ToString();

        string sql2 = "select cp from car ";
        string text = string.Format("cp= '{0}'", car.Cp);
        DataSet dt = Sql.Daset(sql2);
        if (dt.Tables[0].Select(text).Length > 0)
        {
            Alert.AlertAndRedirect("车辆已存在", "CommodityInfoManger.aspx");
            return;

        }
        string sql1 = string.Format("insert into car (cp,qy,weizhi,itime)values('{0}','{1}','{2}','{3}')", car.Cp, car.Qy, car.Weizhi, DateTime.Now);
        int row = Sql.NonQuery(sql1);
        if (row > 0)
        {
            Alert.AlertAndRedirect("车辆进入小区", "CommodityInfoManger.aspx");
        }
    }
}