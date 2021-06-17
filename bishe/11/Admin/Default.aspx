<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Admin_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<!DOCTYPE html>
<html>

	<head>
		 
			<meta http-equiv="X-UA-Compatible" content="IE=edge">
			<meta name="viewport" content="width=device-width, initial-scale=1.0">
            <title>小区停车管理系统</title>
	 
			<link href="css/bootstrap-responsive.css" rel="stylesheet">
			<link href="css/bootstrap.css" rel="stylesheet">
			<link href="css/layout.css" rel="stylesheet">
			<link href="css/menu.css" rel="stylesheet">
			<link href="css/tabs.css" rel="stylesheet">
			<link rel="shortcut icon" href="images/favicon.png">
		 
			<link href="css/pagerecord.css" rel="stylesheet">
			<link href="css/table.css" rel="stylesheet">
			<link href="css/font-awesome.css" rel="stylesheet">
			<link href="css/jquery-ui-1.10.0.custom.css" rel="stylesheet" type="text/css">
			<link href="css/images.css" rel="stylesheet">
			<link href="css/csshake.min.css" rel="stylesheet">
			<style>
				.clock {
					margin-left: 280px;
					font-family: "Lato", sans-serif;
				}
				
				.clock div {
					margin-top: 100px;
					float: left;
					background: #ffe8e8;
					border-radius: 6px;
					width: 96px;
					height: 80px;
					line-height: 80px;
					text-align: center;
					font-size: 60px;
					margin: 0px 5px;
					color: #d96457;
				}
			</style>

			<link href="css/icheck_skins/all.css" rel="stylesheet">
			<style>
				.item_content ul {
					list-style: none;
				}
				
				.item_content ul li {
					width: 370px;
					height: 430px;
					float: left;
					margin-right: 30px;
				}
			</style>
			<script src="js/jquery-1.8.3.min.js"></script>

			<script src="js/bootstrap/bootstrap.min.js"></script>
			<script src="js/jquery-ui-1.8.11.min.js" type="text/javascript"></script>
			<script src="js/jquery.configuration.js" type="text/javascript"></script>
			<script type="text/javascript" src="js/plugs/Jqueryplugs.js"></script>

		 	<script type="text/javascript" src="js/menu.js"></script>


		
		</head>
 

	<body style="-moz-user-select: none; -webkit-user-select: none;">
		<!--页面头部        开始-->
		<div class="dvheader">
			<ul id="nav">
				<li id="user-panel" style="color: white;font-size: 18px;margin-top: 30px;">
				欢迎使用小区停车管理系统
				</li>
				<li>
					<ul id="top-nav">
						<li class="nav-item">
							<a href="index.html">
							 
								<p>系统首页</p>
							</a>
						</li>
						 
						<li class="nav-item">
						<a href="../Login.aspx">
								 
								<p>退出系统</p>
							</a>
						</li>
						 
					</ul>

				</li>
			</ul>
		</div>
		<!--页面头部        结束-->

		<!---页面内容       开始-->
		<div class="wrapper">

			<div class="sidebar">
				<!--动态加载页面对应菜单      开始-->
				 <div class="menuItem menugrid">
					<div class="menu-head menuselect" onClick='showHide("items1_2")'>
						<h2>历史信息管理</h2>
					</div>
					<ul class="menu-content" style="display: block;"  id='items1_2'>
						<li>
							<a href="XiaoShouTJ.aspx" target="right">历史信息查询</a>
						</li>
						 
					</ul>
				</div>
				 <div class="menuItem menugrid">
					<div class="menu-head menuselect" onClick='showHide("items1_6")'>
						<h2>车辆管理</h2>
					</div>
					<ul class="menu-content" style="display: block;"  id='items1_6'>					
						<li>
							<a href="Dm.aspx" target="right">地面车辆管理</a>
						</li>
						<li>
							<a href="CommodityInfoManger.aspx" target="right">地下车辆管理</a>
						</li>
						 
					</ul>
				</div>			 

				<!--动态加载页面对应菜单      结束-->
			</div>

			<div class="body" >
				<iframe src="admin_main.aspx" border="none" width="100%" name="right" scrolling="no" height="1200px"></iframe>
			</div>
		</div>
		<!--页面内容        结束-->

		
	</body>

</html>