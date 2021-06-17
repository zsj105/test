using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Sc3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request.QueryString["id"].ToString().Trim();
        string sql1 = string.Format("delete  from car1 where id='{0}'", id);
        Sql.NonQuery(sql1);
        Alert.AlertAndRedirect("删除", "StoreManger.aspx");

    }
}