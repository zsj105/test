<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin_main.aspx.cs" Inherits="Admin_admin_main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>宜天超市销售管理系统</title>
<link rel="stylesheet" type="text/css" href="css/common.css" />
   
   
</head>
<body>
    <form id="form1" runat="server">
    <div>

<table cellspacing="1" cellpadding="5" bgcolor="#999999" align="center" style="width: 100%">
<tr bgcolor=#cccccc><td><center><b>
    欢迎使用宜天超市销售管理系统</td></tr>
<tr bgcolor=#ffffff><td>
    <table align="center" bgcolor="#d5d4d4" border="0" cellpadding="0" cellspacing="1"
        style="width: 100%">
        <tr>
            <td align="left" colspan="4" style="width: 102px; height: 28px; background-color: #ffffff">
                <strong>当前角色</strong>：</td>
            <td align="left" colspan="1" style="width: 632px; height: 28px; background-color: #ffffff">
                <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label></td>
        </tr>
        <tr style="color: #000000">
            <td align="left" colspan="4" style="width: 102px; height: 33px; background-color: #ffffff">
                 <strong>当前用户</strong>： &nbsp;</td>
            <td align="left" colspan="1" style="width: 632px; height: 33px; background-color: #ffffff">
                &nbsp;<asp:Label ID="Label2" runat="server" ForeColor="Red"></asp:Label></td>
        </tr>
        <tr>
            <td align="center" colspan="5" style="height: 25px; background-color: #ffffff">
                </td>
        </tr>
    </table>
</td></tr>
<tr bgcolor=#eeeeee><td>

<a href=# target=_blank><font color=blue></font></a>
 </table></div>
    </form>
    
</body>
</html>
