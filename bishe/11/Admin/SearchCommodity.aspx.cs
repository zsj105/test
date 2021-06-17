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

public partial class Admin_SearchCommodity : System.Web.UI.Page
{
    Alert alert = new Alert();
    SqlHelper data = new SqlHelper();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Xg();

    }
    protected void Xg() { Model.Yz yz = new Model.Yz();
        string id = Request.QueryString["id"];
        yz.Name = txtname.Text;
        yz.Car = TextBox1.Text;
        yz.CW = DropDownList2.SelectedValue;
        yz.Dh = TextBox3.Text;
        yz.Dizhi = txtSpecification.Text;
        yz.Sex = DropDownList1.SelectedValue;
        string sql = string.Format("update yz set cp='{0}',name='{1}',sex='{2}',cw='{3}',dianhua='{4}',dizhi='{5}'where id='{6}'", yz.Car, yz.Name, yz.Sex, yz.CW, yz.Dh, yz.Dizhi, id);
        if (DAL.Yz.Pd(yz.Car).HasRows)
        {
            Alert.AlertAndRedirect("已登记", "StoreInfo.aspx");

            return;
        }
        int row = DAL.Yz.Xiugai(yz, id);
        if (row > 0)
        {
            Alert.AlertAndRedirect("修改成功", "StoreInfo.aspx");
        }
       
    }
}
