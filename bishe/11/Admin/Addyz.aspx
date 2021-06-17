<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Addyz.aspx.cs" Inherits="Admin_Addyz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>小区停车管理系统</title>
    <style type="text/css">
<!--
body {
	margin-left: 0px;
	margin-top: 0px;
	margin-right: 0px;
	margin-bottom: 0px;
	 
}
-->
</style>
    <link rel="stylesheet" type="text/css" href="css/common.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table width="100%" border="0" cellpadding="0" cellspacing="0">
  <tr>
    <td height="29" valign="top" background="images/mail_leftbg.gif" style="width: 8px"><img src="images/left-top-right.gif" width="17" height="29" /></td>
    <td width="935" height="29" valign="top" background="images/content-bg.gif"><table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="left_topbg" id="table2">
      <tr>
        <td style="height: 31px"><div class="titlebt">添加账号</div></td>
      </tr>
    </table></td>
    <td width="16" valign="top" background="images/mail_rightbg.gif"><img src="images/nav-right-bg.gif" width="16" height="29" /></td>
  </tr>
  <tr>
    <td height="71" valign="middle" background="images/mail_leftbg.gif" style="width: 8px">&nbsp;</td>
    <td valign="top" bgcolor="#F7F8F9"><table width="100%" border="0" cellpadding="0" cellspacing="0" style="height: 72px">
      <tr>
        <td valign="top" style="width: 998px; height: 20px">
            姓名：<asp:TextBox ID="txtUser" runat="server" Width="148px"></asp:TextBox>
            &nbsp;
            <br />
            车牌号：<asp:TextBox ID="txtPwd" runat="server" Width="148px"></asp:TextBox>
            &nbsp;
            <span lang="zh-cn">
                <br />
                </span>车位<span lang="zh-cn">：</span><asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource1" DataTextField="weizhi" DataValueField="weizhi">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BisheConnectionString %>" SelectCommand="SELECT [weizhi] FROM [car1] WHERE ([qy] = @qy)">
                <SelectParameters>
                    <asp:Parameter DefaultValue="地下" Name="qy" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
            性别：<asp:DropDownList ID="DropDownList2" runat="server" Width="124px">
        <asp:ListItem>男</asp:ListItem>
                  <asp:ListItem Value="女">女</asp:ListItem>
                 
                  
                       
               
            </asp:DropDownList>
            <br />
            地址<span lang="zh-cn">：</span><asp:TextBox ID="TextBox2" runat="server" Width="148px"></asp:TextBox>&nbsp;&nbsp;<br />
            电话<span lang="zh-cn">：</span><asp:TextBox ID="TextBox3" runat="server" Width="148px"></asp:TextBox>&nbsp;&nbsp;</td>
      </tr>
        <tr>
            <td align="center" style="width: 998px; height: 24px;" valign="top">
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="添 加" />
                <span lang="zh-cn">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </span></td>
        </tr>
    </table></td>
    <td background="images/mail_rightbg.gif">&nbsp;</td>
  </tr>
  <tr>
    <td valign="middle" background="images/mail_leftbg.gif" style="width: 8px"><img src="images/buttom_left2.gif" width="17" height="17" /></td>
      <td height="17" valign="top" background="images/buttom_bgs.gif"><img src="images/buttom_bgs.gif" width="17" height="17" /></td>
    <td background="images/mail_rightbg.gif"><img src="images/buttom_right2.gif" width="16" height="17" /></td>
  </tr>
</table>
    </div>
    </form>
</body>
</html>
