using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Sc2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request.QueryString["id"].ToString().Trim();
        string sql1 = string.Format("delete  from yz where id='{0}'", id);
        Sql.NonQuery(sql1);
        Alert.AlertAndRedirect("删除成功", "StoreInfo.aspx");
    }
}