<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewByCompanyList.aspx.cs" Inherits="Jobportalclient.ViewByCompanyList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
<!--===============================================================================================-->
	<link rel="icon" type="image/png" href="Theme/images/icons/favicon.ico"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="Theme/vendor/bootstrap/css/bootstrap.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="Theme/fonts/font-awesome-4.7.0/css/font-awesome.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="Theme/fonts/iconic/css/material-design-iconic-font.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="Theme/fonts/Linearicons-Free-v1.0.0/icon-font.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="Theme/vendor/animate/animate.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="Theme/vendor/css-hamburgers/hamburgers.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="Theme/vendor/animsition/css/animsition.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="Theme/vendor/select2/select2.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="Theme/vendor/daterangepicker/daterangepicker.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="Theme/css/util.css">
	<link rel="stylesheet" type="text/css" href="Theme/css/main.css">

    <style>

        .Grid {background-color: #fff; margin: 5px 0 10px 0; border: solid 1px #525252; border-collapse:collapse; font-family:Calibri; color: #474747;}

.Grid td {

      padding: 2px;

      border: solid 1px #c1c1c1; }

.Grid th  {

      padding : 4px 2px;

      color: #fff;

      background: #363670 url(Images/grid-header.png) repeat-x top;

      border-left: solid 1px #525252;

      font-size: 0.9em; }

.Grid .alt {

      background: #fcfcfc url(Images/grid-alt.png) repeat-x top; }

.Grid .pgr {background: #363670 url(Images/grid-pgr.png) repeat-x top; }

.Grid .pgr table { margin: 3px 0; }

.Grid .pgr td { border-width: 0; padding: 0 6px; border-left: solid 1px #666; font-weight: bold; color: #fff; line-height: 12px; }  

.Grid .pgr a { color: Gray; text-decoration: none; }

.Grid .pgr a:hover { color: #000; text-decoration: none; }
    </style>
</head>
<body>
    
    <div class="bg-container-contact100" style="background-image: url(Theme/images/bg-01.jpg);">
		<div class="contact100-header flex-sb-m">
			<a href="#" class="contact100-header-logo">
				<img src="Theme/images/icons/logo.png" alt="LOGO"/>
			</a>
           
			
		</div>
	</div>
                   
<div class="container-contact100">
		<div class="wrap-contact100">
		

			<div class="contact100-form-title" style="background-image: url(Theme/images/bg-02.jpg);">
				<span>Company Dashboard</span>
			</div>
          
                  <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server"

                    
                      CssClass="Grid"                    

                      AlternatingRowStyle-CssClass="alt"

                      PagerStyle-CssClass="pgr">
            </asp:GridView>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>

		
		</div>
               
                
	</div>
   
 
</body>
</html>
