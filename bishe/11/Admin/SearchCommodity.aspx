<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SearchCommodity.aspx.cs" Inherits="Admin_SearchCommodity" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>商品管理</title>
        <script language="javascript" type="text/javascript" src="../js/Calendar.js"></script>
   
    <style type="text/css">
<!--
body {
	margin-left: 0px;
	margin-top: 0px;
	margin-right: 0px;
	margin-bottom: 0px;
	 
}
        .auto-style1 {
            height: 20px;
        }
        .auto-style2 {
            height: 22px;
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
    <td width="17" valign="top" background="images/mail_leftbg.gif" style="height: 49px"><img src="images/left-top-right.gif" width="17" height="29" /></td>
    <td valign="top" background="images/content-bg.gif" style="height: 49px"><table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="left_topbg" id="table2">
      <tr>
        <td height="31"><div class="titlebt">
            业主资料修改</div></td>
      </tr>
    </table></td>
    <td width="16" valign="top" background="images/mail_rightbg.gif" style="height: 49px"><img src="images/nav-right-bg.gif" width="16" height="29" /></td>
  </tr>
  <tr>
    <td valign="middle" background="images/mail_leftbg.gif">&nbsp;</td>
    <td valign="top" bgcolor="#F7F8F9">
    <table align="center" border="0" cellpadding="0" cellspacing="0" width="100%">
            <tr>
                <td lang="zh-cn" class="auto-style1">
                    姓名：<asp:TextBox ID="txtname" runat="server" Width="353px"></asp:TextBox>
                </td>
            </tr>
            <tr height="20">
                <td>
                    车牌号<span lang="zh-cn">：</span><asp:TextBox ID="TextBox1" runat="server" Width="212px"></asp:TextBox>
                </td>
            </tr>
        <tr height="20">
            <td style="height: 20px">
                地下车位：<asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource1" DataTextField="weizhi" DataValueField="weizhi">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BisheConnectionString %>" SelectCommand="SELECT [weizhi] FROM [car1] WHERE ([qy] = @qy)">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="地下" Name="qy" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
        <tr height="20">
            <td style="height: 20px">
                电话：<asp:TextBox ID="TextBox3" runat="server" Width="212px"></asp:TextBox></td>
        </tr>
            <tr>
                <td class="auto-style2">
                    性别<span lang="zh-cn">：</span><asp:DropDownList ID="DropDownList1" runat="server"
                        Width="276px">
                        <asp:ListItem>男</asp:ListItem>
                        <asp:ListItem>女</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr height="20">
                <td>
                    家庭住址<span lang="zh-cn">：</span><asp:TextBox ID="txtSpecification" runat="server" Width="189px"></asp:TextBox>
                </td>
            </tr>
        </table>
    </td>
    <td background="images/mail_rightbg.gif">&nbsp;</td>
  </tr>
        <tr>
            <td background="images/mail_leftbg.gif" valign="middle" style="height: 19px">
            </td>
            <td align="center" bgcolor="#f7f8f9" valign="top" style="height: 19px">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="修改" style="height: 33px" />
                &nbsp;<asp:Label ID="Label4" runat="server" ForeColor="Red"></asp:Label>
            </td>
            <td background="images/mail_rightbg.gif" style="height: 19px">
            </td>
        </tr>
  <tr>
    <td valign="bottom" background="images/mail_leftbg.gif"><img src="images/buttom_left2.gif" width="17" height="17" /></td>
    <td background="images/buttom_bgs.gif"><img src="images/buttom_bgs.gif" width="17" height="17"></td>
    <td valign="bottom" background="images/mail_rightbg.gif"><img src="images/buttom_right2.gif" width="16" height="17" /></td>
  </tr>
</table>
    </div>
    </form>
</body>
</html>
