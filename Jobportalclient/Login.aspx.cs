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
<<<<<<< HEAD
            ServiceReference2.Service1Client s = new ServiceReference2.Service1Client("BasicHttpBinding_IService1");
            ServiceReference2.User u = new ServiceReference2.User();
=======
            JobPortalRef.Service1Client s = new JobPortalRef.Service1Client("BasicHttpBinding_IService1");
            JobPortalRef.User u = new JobPortalRef.User();
>>>>>>> 75131fa61f20113d733be844fbb8e9ea071441f3
            u.UserName = TextBox1.Text;
            u.Password = TextBox2.Text;
            u.Role = TextBox3.Text;
            string st=s.Login(u);
            if(st.Equals("login"))
            {
<<<<<<< HEAD
                Session["username"] = u.UserName.ToString();
=======

>>>>>>> 75131fa61f20113d733be844fbb8e9ea071441f3
                Response.Redirect("UserHome.aspx");
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
            
        }
    }
}