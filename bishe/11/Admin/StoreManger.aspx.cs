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
public partial class Admin_StoreManger : System.Web.UI.Page
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
 
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Model.Car car = new Model.Car();
        car.Qy = DropDownList1.SelectedValue;
        car.Weizhi = TextBox2.Text;
        if (DAL.Car.Pd(car).HasRows)
        {
            Alert.AlertAndRedirect("车位已存在", "StoreManger.aspx");
            return;
        }
      int row=  DAL.Car.Tianjia(car);
        if (row>0)
        {
            Alert.AlertAndRedirect("添加成功", "StoreManger.aspx");
        }
        
        
    }
}
