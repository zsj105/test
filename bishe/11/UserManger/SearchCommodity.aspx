﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SearchCommodity.aspx.cs" Inherits="Admin_SearchCommodity" %>

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
            商品资料查询</div></td>
      </tr>
    </table></td>
    <td width="16" valign="top" background="images/mail_rightbg.gif" style="height: 49px"><img src="images/nav-right-bg.gif" width="16" height="29" /></td>
  </tr>
  <tr>
    <td valign="middle" background="images/mail_leftbg.gif">&nbsp;</td>
    <td valign="top" bgcolor="#F7F8F9">
    <table align="center" border="0" cellpadding="0" cellspacing="0" width="100%">
            <tr height="20">
                <td lang="zh-cn" style="height: 20px">
                    <span></span>商品名称：<asp:TextBox ID="txtname" runat="server" Width="353px"></asp:TextBox>
                </td>
            </tr>
            <tr height="20">
                <td>
                    <span lang="zh-cn">商品编号：</span><asp:TextBox ID="TextBox1" runat="server" Width="212px"></asp:TextBox>
                </td>
            </tr>
        <tr height="20">
            <td style="height: 20px">
                商品品牌：<asp:TextBox ID="TextBox2" runat="server" Width="212px"></asp:TextBox></td>
        </tr>
        <tr height="20">
            <td style="height: 20px">
                商品批号：<asp:TextBox ID="TextBox3" runat="server" Width="212px"></asp:TextBox></td>
        </tr>
            <tr>
                <td class="style1" style="height: 22px">
                    <span lang="zh-cn">商品类别：</span><asp:DropDownList ID="DropDownList1" runat="server"
                        Width="276px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr height="20">
                <td>
                    <span lang="zh-cn">计量单位：</span><asp:TextBox ID="txtSpecification" runat="server" Width="189px"></asp:TextBox>
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
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="查询" />
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
