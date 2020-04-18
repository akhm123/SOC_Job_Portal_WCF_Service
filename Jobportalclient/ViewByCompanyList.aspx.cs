using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Jobportalclient
{
    public partial class ViewByCompanyList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            ServiceReference2.Service1Client c = new ServiceReference2.Service1Client("BasicHttpBinding_IService1");
=======
            JobPortalRef.Service1Client c = new JobPortalRef.Service1Client("BasicHttpBinding_IService1");
>>>>>>> 75131fa61f20113d733be844fbb8e9ea071441f3
            
            GridView1.DataSource = c.SelectUserbyCompany(Session["companyname"].ToString());
            Label1.Text = Session["companyname"].ToString();
            GridView1.DataBind();
        }
    }
}