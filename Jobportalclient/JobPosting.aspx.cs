using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Jobportalclient
{
    public partial class JobPosting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {

<<<<<<< HEAD
            ServiceReference2.Service1Client client = new ServiceReference2.Service1Client("BasicHttpBinding_IService1");
            ServiceReference2.CompanyDetails c = new ServiceReference2.CompanyDetails();
=======
            JobPortalRef.Service1Client client = new JobPortalRef.Service1Client("BasicHttpBinding_IService1");
            JobPortalRef.CompanyDetails c = new JobPortalRef.CompanyDetails();
>>>>>>> 75131fa61f20113d733be844fbb8e9ea071441f3
            c.Name = Companyname.Text;
            c.Postname = PostName.Text;
            c.Qualification = Qualification.Text;
            c.Salary = Salary.Text;
            c.Vacancy = Int32.Parse(Vacancy.Text);
            c.Description = message.Text;
            c.Jobid = Jobid.Text;
            client.InsertData(c);


        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            Response.Redirect("ViewByCompany.aspx");
        }
    }
}