using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Addyz : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void btnAdd_Click(object sender, EventArgs e)
    {
       
            Model.Yz yz = new Model.Yz();
            yz.Car = txtPwd.Text;
            yz.Name = txtUser.Text;
            yz.CW = DropDownList3.SelectedValue;
            yz.Sex = DropDownList2.SelectedValue;
            yz.Dizhi = TextBox2.Text;
            yz.Dh = TextBox3.Text;
            if (DAL.Yz.Pd(yz.Car).HasRows)
            {
                Alert.AlertAndRedirect("已登记", "Addyz.aspx");
                return;
            }
            DAL.Yz.Dengji1(yz);
            Alert.AlertAndRedirect("成功", "StoreInfo.aspx");
        
    }
}