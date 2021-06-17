<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddXS.aspx.cs" Inherits="Admin_AddShengChan" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title> 添加销售</title>
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
            添加销售</div></td>
      </tr>
    </table></td>
    <td width="16" valign="top" background="images/mail_rightbg.gif" style="height: 49px"><img src="images/nav-right-bg.gif" width="16" height="29" /></td>
  </tr>
  <tr>
    <td valign="middle" background="images/mail_leftbg.gif" style="height: 160px">&nbsp;</td>
    <td valign="top" bgcolor="#F7F8F9" style="height: 160px">
        <table align="center" border="0" cellpadding="0" cellspacing="0" width="100%">
            <tr height="20">
                <td lang="zh-cn">
                    <span></span>商品类别：<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True"
                        OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="126px">
                    </asp:DropDownList></td>
            </tr>
            <tr height="20">
                <td lang="zh-cn" style="height: 20px">
                    选择仓库：<asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged"
                        Width="221px">
                    </asp:DropDownList></td>
            </tr>
            <tr height="20">
                <td lang="zh-cn" style="height: 20px">
                商品名称：<asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"
                        Width="192px">
                    </asp:DropDownList></td>
            </tr>
            <tr height="20">
                <td>
                    <span lang="zh-cn">商品编号：</span><asp:TextBox ID="txtCode" runat="server" Width="212px" ReadOnly="True"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1"
                        ErrorMessage="必填"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr height="20">
                <td>
                    <span lang="zh-cn">计量单位：</span><asp:TextBox ID="txtSpecification" runat="server"
                        Width="189px" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr height="20">
                <td style="height: 20px">
                    库存数量：<asp:TextBox ID="txtSL" runat="server" Width="86px" ReadOnly="True"></asp:TextBox></td>
            </tr>
            <tr height="20">
                <td align="center">
                    &nbsp;</td>
            </tr>
        </table>
    </td>
    <td background="images/mail_rightbg.gif" style="height: 160px">&nbsp;</td>
  </tr>
        <tr>
            <td background="images/mail_leftbg.gif" valign="middle" style="height: 20px">
            </td>
            <td align="center" bgcolor="#f7f8f9" valign="top" style="height: 20px">
                商品销售信息</td>
            <td background="images/mail_rightbg.gif" style="height: 20px">
            </td>
        </tr>
        <tr>
            <td background="images/mail_leftbg.gif" style="height: 24px" valign="middle">
            </td>
            <td align="left" bgcolor="#f7f8f9" style="height: 24px" valign="top">
                商品单价：<asp:TextBox ID="TextBox4" runat="server" Width="110px" ReadOnly="True"></asp:TextBox></td>
            <td background="images/mail_rightbg.gif" style="height: 24px">
            </td>
        </tr>
        <tr>
            <td background="images/mail_leftbg.gif" style="height: 24px" valign="middle">
            </td>
            <td align="left" bgcolor="#f7f8f9" style="height: 24px" valign="top">
                销售数量：<asp:TextBox ID="TextBox1" runat="server" Width="110px" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                输入盘点数量<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                    ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
            <td background="images/mail_rightbg.gif" style="height: 24px">
            </td>
        </tr>
        <tr>
            <td background="images/mail_leftbg.gif" style="height: 24px" valign="middle">
            </td>
            <td align="left" bgcolor="#f7f8f9" style="height: 24px" valign="top">
                商品总价：<asp:TextBox ID="TextBox3" runat="server" Width="151px" ReadOnly="True"></asp:TextBox></td>
            <td background="images/mail_rightbg.gif" style="height: 24px">
            </td>
        </tr>
        <tr>
            <td background="images/mail_leftbg.gif" style="height: 24px" valign="middle">
            </td>
            <td align="center" bgcolor="#f7f8f9" style="height: 24px" valign="top">
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="添加到销售单" />
                <asp:Label ID="Label3" runat="server" ForeColor="Red"></asp:Label></td>
            <td background="images/mail_rightbg.gif" style="height: 24px">
            </td>
        </tr>
        <tr>
            <td background="images/mail_leftbg.gif" style="height: 24px" valign="middle">
            </td>
            <td align="left" bgcolor="#f7f8f9" style="height: 24px" valign="top">
                <asp:GridView ID="gvOrderInfo" runat="server" AutoGenerateColumns="False" CellPadding="4"
                    CssClass="text001"  GridLines="None"  
                    PageSize="8" Width="100%" ForeColor="#333333">
                    <RowStyle BackColor="#E3EAEB" />
                    <Columns>
                        <asp:TemplateField HeaderText="商品名称">
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="商品价格">
                            <ItemTemplate>
                                <asp:Label ID="Label4" runat="server" Text='<%# Bind("danjia") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="数量">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("shuliang") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("shuliang") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    
                    </Columns>
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#7C6F57" />
                    <AlternatingRowStyle BackColor="White" />
                </asp:GridView>
            </td>
            <td background="images/mail_rightbg.gif" style="height: 24px">
            </td>
        </tr>
        <tr>
            <td background="images/mail_leftbg.gif" style="height: 25px" valign="middle">
            </td>
            <td align="left" bgcolor="#f7f8f9" style="height: 25px" valign="top">
                总金额：<asp:Label ID="Label5" runat="server" ForeColor="Red">0</asp:Label></td>
            <td background="images/mail_rightbg.gif" style="height: 25px">
            </td>
        </tr>
        <tr>
            <td background="images/mail_leftbg.gif" style="height: 25px" valign="middle">
            </td>
            <td align="left" bgcolor="#f7f8f9" style="height: 25px" valign="top">
                支付方式：<asp:DropDownList ID="DropDownList4" runat="server">
                    <asp:ListItem>微信</asp:ListItem>
                    <asp:ListItem>支付宝</asp:ListItem>
                    <asp:ListItem>现金</asp:ListItem>
                    <asp:ListItem Value="刷卡"></asp:ListItem>
                </asp:DropDownList></td>
            <td background="images/mail_rightbg.gif" style="height: 25px">
            </td>
        </tr>
        <tr>
            <td background="images/mail_leftbg.gif" style="height: 24px" valign="middle">
            </td>
            <td align="left" bgcolor="#f7f8f9" style="height: 24px" valign="top">
            </td>
            <td background="images/mail_rightbg.gif" style="height: 24px">
            </td>
        </tr>
        <tr>
            <td background="images/mail_leftbg.gif" style="height: 19px" valign="middle">
            </td>
            <td align="center" bgcolor="#f7f8f9" style="height: 19px" valign="top">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="结账" />
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
