<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Jobportalclient.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="fonts/material-icon/css/material-design-iconic-font.min.css">

    <!-- Main css -->
    <link rel="stylesheet" href="css/style.css">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <section class="sign-in">
            <div class="container">
                <div class="signin-content">
                    <div class="signin-image">
                        <figure><img src="images/signin-image.jpg" alt="sing up image"></figure>
                                                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Registration.aspx">Create an account</asp:HyperLink>

                    </div>

                    <div class="signin-form">
                        <h2 class="form-title">Sign in</h2>
                        <form method="POST" class="register-form" id="login-form">
                            <div class="form-group">
                                <label for="your_name"><i class="zmdi zmdi-account material-icons-name"></i></label>
                                <asp:TextBox ID="TextBox1" runat="server" placeholder="username"></asp:TextBox>
                                
                                <%--<input type="text" name="your_name" id="your_name" placeholder="Your Name"/>--%>
                            </div>
                            <div class="form-group">
                                <label for="your_pass"><i class="zmdi zmdi-lock"></i></label>
                                <asp:TextBox ID="TextBox2" runat="server" placeholder="password"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="your_pass"><i class="zmdi zmdi-lock"></i></label>
                                <asp:TextBox ID="TextBox3" runat="server" placeholder="role"></asp:TextBox>
                            </div> 
                            <div class="form-group form-button">
                                <asp:Button ID="Button1" runat="server" Text="login" class="form-submit" OnClick="Button1_Click"/>
                                <%--<input type="submit" name="signin" id="signin" class="form-submit" value="Log in"/>--%>
                            </div>
                        </form>
                       <%-- <div class="social-login">
                            <span class="social-label">Or login with</span>
                            <ul class="socials">
                                <li><a href="#"><i class="display-flex-center zmdi zmdi-facebook"></i></a></li>
                                <li><a href="#"><i class="display-flex-center zmdi zmdi-twitter"></i></a></li>
                                <li><a href="#"><i class="display-flex-center zmdi zmdi-google"></i></a></li>
                            </ul>
                        </div>--%>
                    </div>
                </div>
            </div>
        </section>
    </form>
</body>
</html>
