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
public partial class AdminManger_AddAdminInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    { 
        if (!IsPostBack)
        {
          
            
        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Model.User user = new Model.User 
        {
            Name = txtUser.Text,
            PassWord = txtPwd.Text,
            State = DropDownList2.SelectedValue,
            Mz=TextBox1.Text
        };
        if ( DAL.User.Pd(user.Name).HasRows)
        {
            Alert.AlertAndRedirect("用户已存在", "AddAdminInfo.aspx");
            return;
            
        }


        bool res = DAL.User.Zhuce(user);
        if (res)
        {
            Alert.AlertAndRedirect("添加成功", "AdminManger.aspx");
        }
        }
    }
