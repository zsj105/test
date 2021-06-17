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
public partial class CaiWuManger_XiaoShouTJ : System.Web.UI.Page
{

    SqlHelper data = new SqlHelper();
    Alert alert = new Alert();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (txtbtime.Text == "")
            {
                txtbtime.Text = DateTime.Now.ToShortDateString();
            }
            if (txtEtime.Text == "")
            {
                txtEtime.Text = DateTime.Now.ToShortDateString();
            }
        }
    }
  
    protected void dlinfo_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //鼠标移动变色
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            //当鼠标放上去的时候 先保存当前行的背景计量单位 并给附一计量单位 
            e.Row.Attributes.Add("onmouseover", "currentcolor=this.style.backgroundColor;this.style.backgroundColor='#f6f6f6',this.style.fontWeight='';");
            //当鼠标离开的时候 将背景计量单位还原的以前的计量单位 
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=currentcolor,this.style.fontWeight='';");
        }
        //单击行改变行背景计量单位 
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onclick", "this.style.backgroundColor='#f6f6f6'; this.style.color='buttontext';this.style.cursor='default';");
        }

    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        string b = Convert.ToDateTime(txtbtime.Text).ToShortDateString() + " 00:00";
        string a = Convert.ToDateTime(txtEtime.Text).ToShortDateString() + " 23:59";
        string sql = string.Format("select * from jilu where itime between '{0}' and '{1}'",b,a);
        string sql1 = string.Format("select sum(cast(pay AS DECIMAL)) as totalmoney from jilu where itime between '{0}' and '{1}'", b, a);
        SqlDataSource1.SelectCommand = sql;
        dlinfo.DataSourceID = SqlDataSource1.ID;
        dlinfo.DataBind();
       Label4.Text= "asd";
    }
}
