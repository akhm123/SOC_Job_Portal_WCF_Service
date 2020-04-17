<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Jobportalclient.WebForm3" %>

<!DOCTYPE html>

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Sign Up Form by Colorlib</title>

    <!-- Font Icon -->
    <link rel="stylesheet" href="fonts/material-icon/css/material-design-iconic-font.min.css">

    <!-- Main css -->
    <link rel="stylesheet" href="css/style.css">
</head>
<body>
    <form id="form1" runat="server">
        <div class="main">

        <!-- Sign up form -->
        <section class="signup">
            <div class="container">
                <div class="signup-content">
                    <div class="signup-form">
                        <h2 class="form-title">Sign up</h2>
                        <form method="POST" class="register-form" id="register-form">
                            <div class="form-group">
                                <label for="name"><i class="zmdi zmdi-account material-icons-name"></i></label>
                                <asp:TextBox ID="TextBox1" runat="server" placeholder="username"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="email"><i class="zmdi zmdi-email"></i></label>
                                <asp:TextBox ID="TextBox2" runat="server" placeholder="email"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="pass"><i class="zmdi zmdi-lock"></i></label>
                                <asp:TextBox ID="TextBox3" runat="server" placeholder="password"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="re-pass"><i class="zmdi zmdi-lock-outline"></i></label>
                                <asp:TextBox ID="TextBox4" runat="server" placeholder="reenter password"></asp:TextBox>
                            </div>
                         <div class="form-group">
                                <label for="name"><i class="zmdi zmdi-account material-icons-name"></i></label>
                                <asp:TextBox ID="TextBox5" runat="server" placeholder="contact"></asp:TextBox>
                            </div>
                             <div class="form-group">
                                <label for="name"><i class="zmdi zmdi-account material-icons-name"></i></label>
                                <asp:TextBox ID="TextBox6" runat="server" placeholder="role"></asp:TextBox>
                            </div>

                            
                            <div class="form-group form-button">
                                <asp:Button ID="Button1" runat="server" Text="Register"  class="form-submit" OnClick="Button1_Click"/>
                                <%--<input type="submit" name="signup" id="signup" value="Register"/>--%>
                            </div>
                        </form>
                    </div>
                    <div class="signup-image">
                        <figure><img src="images/signup-image.jpg" alt="sing up image"></figure>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Login.aspx">I am already member</asp:HyperLink>
                        <%--<a href="#" class="signup-image-link"></a>--%>
                    </div>
                </div>
            </div>
        </section>

        <!-- Sing in  Form -->
        

    </div>
    </form>
</body>
</html>
