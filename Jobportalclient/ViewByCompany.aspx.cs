using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Jobportalclient
<<<<<<< HEAD
{   
=======
{
>>>>>>> 75131fa61f20113d733be844fbb8e9ea071441f3
    public partial class ViewByCompany : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["companyname"] = TextBox1.Text;
           
            Response.Redirect("ViewByCompanyList.aspx");

        }
    }
}