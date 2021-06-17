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
public partial class Admin_CommodityInfoManger : System.Web.UI.Page
{
    SqlHelper data = new SqlHelper();
    Alert alert = new Alert();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           
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
        Model.Car car = new Model.Car();
        car.Cp = TextBox1.Text;
        car.Qy = "地上";
        car.Weizhi = DropDownList1.SelectedValue;
        if (TextBox1.Text == "")
        {
            Alert.AlertAndRedirect("车牌不能为空", "CommodityInfoManger.aspx");
            return;
        }
        string sql = "select cp from car ";
        string text = string.Format("cp= '{0}'", car.Cp);
        DataSet dt = Sql.Daset(sql);
        if (dt.Tables[0].Select(text).Length > 0)
        {
            Alert.AlertAndRedirect("车辆已存在", "CommodityInfoManger.aspx");
            return;

        }
        string sql1 = string.Format("insert into car (cp,qy,weizhi,itime)values('{0}','{1}','{2}','{3}')", car.Cp, car.Qy, car.Weizhi,DateTime.Now);
     int row=   Sql.NonQuery(sql1);
        if (row>0)
        {
            Alert.AlertAndRedirect("车辆进入小区", "CommodityInfoManger.aspx");
        }

    }
}
