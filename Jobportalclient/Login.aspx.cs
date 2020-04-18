using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Jobportalclient
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference2.Service1Client s = new ServiceReference2.Service1Client("BasicHttpBinding_IService1");
            ServiceReference2.User u = new ServiceReference2.User();
            u.UserName = TextBox1.Text;
            u.Password = TextBox2.Text;
            u.Role = TextBox3.Text;
            string st=s.Login(u);
            if(st.Equals("login"))
            {
                Session["username"] = u.UserName.ToString();
                Response.Redirect("UserHome.aspx");
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
            
        }
    }
}