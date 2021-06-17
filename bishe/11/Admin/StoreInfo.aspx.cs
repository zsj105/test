using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
public partial class Admin_StoreInfo : System.Web.UI.Page
{
    SqlHelper data = new SqlHelper();
    Alert alert = new Alert();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string sql = string.Format("select * from yz where name  like '%{0}%' and dizhi like '%{1}%'", TextBox1.Text, TextBox2.Text);
        SqlDataSource1.SelectCommand = sql;
        dlinfo.DataSourceID = SqlDataSource1.ID;
        dlinfo.DataBind();
    }
}
