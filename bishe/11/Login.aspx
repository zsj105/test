<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Admin_Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>小区停车管理系统</title>
    	<link rel="stylesheet" href="CSS/layui.css" media="all" />
		<link rel="stylesheet" href="CSS/login.css" media="all" >
 
</head>
<body>
    <form id="form1" class="layui-form"  runat="server">
  <div class="container" style="left: 0px; top: 0px">
				<div class=" layui-word-aux">
					小区停车管理系统
				</div>

				<div class="layui-form-item">
					<label class="layui-form-label">用户名</label>
					<div class="layui-input-block">
						<input type="text" name="username" required lay-verify="required|username" placeholder="用户名" autocomplete="off"
						 class="layui-input" runat="server" id="Text1">
					</div>
				</div>
				<div class="layui-form-item">
					<label class="layui-form-label">密 &nbsp;&nbsp;码</label>
					<div class="layui-input-block">
						<input type="password" name="userpassword" required lay-verify="required|pass" placeholder="密码" autocomplete="off"
						 class="layui-input" runat="server" id="Text2">
					</div>
					<!-- <div class="layui-form-mid layui-word-aux">辅助文字</div> -->
				</div>
				<div class="layui-form-item">
					<label class="layui-form-label">角 &nbsp;&nbsp;色</label>
					<div class="layui-input-block">
						<asp:DropDownList ID="DropDownList1" runat="server"   class="layui-input"
          Width="107px">
          <asp:ListItem>超级管理员</asp:ListItem>
                                       
                                        <asp:ListItem Value="管理员">管理员</asp:ListItem>
                                        
       
      </asp:DropDownList>
					</div>
					<!-- <div class="layui-form-mid layui-word-aux">辅助文字</div> -->
				</div>
				<div class="layui-form-item">
					<label class="layui-form-label">验证码</label>
					<div class="layui-input-block" style="width: auto;">
						<input type="text" id="userImg" runat="server"  name="verifycode" required lay-verify="required" placeholder="验证码" autocomplete="off" class="layui-input verity" style="width: 154px">
						 
		
		<img style="border:0px;cursor:hand" src="CheckImage.aspx" onclick="this.src=this.src+'?'" id="checkImg"  class="verifyimage" border="0"/>				
					</div>

				</div>

				<button class="layui-btn" lay-submit lay-filter="formDemo" id="BUTTON1" onserverclick="BUTTON1_ServerClick" runat="server">登&nbsp;&nbsp;录</button>
	<br />			
	
	 			
			</div>
    </form>	<div class="loginBg"></div>
		<canvas id="bgCanvas"></canvas>
</body>
</html>
