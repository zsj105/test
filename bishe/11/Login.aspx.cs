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

public partial class Admin_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    private void chkADmin()
    {
        Model.User user = new Model.User
        {
            Name = Text1.Value,
            PassWord = Text2.Value
        };

        if (Text1.Value == "" && Text2.Value == "")
        {
            Alert.AlertAndRedirect("没有输入账号和密码！", "Login.aspx");


        }
        else
        {
            if (Session["CheckCode"].ToString() != userImg.Value)
            {
                Alert.AlertAndRedirect("验证码错误请重新输入", "Login.aspx");
            }
            else
            {
                if (DropDownList1.SelectedValue == "超级管理员")
                {
                    bool res = DAL.User.Dengru(user);
                    if (res)
                    {
                        Response.Redirect("Admin/index.html");
                    }
                    else
                    {
                        Alert.AlertAndRedirect("用户的账号或者密码不对请重新登陆！", "login.aspx");
                    }
                }
                if (DropDownList1.SelectedValue == "管理员")
                {
                    bool res = DAL.User.Dengru1(user);
                    if (res)
                    {
                        Response.Redirect("Admin/Default.html");
                    }
                    else
                    {
                        Alert.AlertAndRedirect("用户的账号或者密码不对请重新登陆！", "login.aspx");
                    }

                }

            }
        }
    }

    protected void BUTTON1_ServerClick(object sender, EventArgs e)
    {
        chkADmin();


    }

}
