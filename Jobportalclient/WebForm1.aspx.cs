using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Jobportalclient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            ServiceReference2.Service1Client s = new ServiceReference2.Service1Client("BasicHttpBinding_IService1");
=======
            JobPortalRef.Service1Client s = new JobPortalRef.Service1Client("BasicHttpBinding_IService1");
>>>>>>> 75131fa61f20113d733be844fbb8e9ea071441f3
            DataSet ds = s.SelectUserbyCompany("amazon");
            GridView1.DataSource = ds;///.SelectUserbyCompany("yt").Tables[0];
            GridView1.DataBind();
        }
    }
}