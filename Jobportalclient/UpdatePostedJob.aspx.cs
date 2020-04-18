using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Jobportalclient
{
    public partial class UpdatePostedJob : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference2.Service1Client c = new ServiceReference2.Service1Client("BasicHttpBinding_IService1");

            GridView1.DataSource = c.GetSingleCompanyData(Session["username"].ToString());
           // Label1.Text = Session["companyname"].ToString();
            GridView1.DataBind();

        }
        protected void LnKB_Click(object sender, System.EventArgs e)
        {
            ServiceReference2.Service1Client s = new ServiceReference2.Service1Client("BasicHttpBinding_IService1");

            Button lb = sender as Button;
            GridViewRow clickedRow = ((Button)sender).NamingContainer as GridViewRow;
            int x = clickedRow.RowIndex;
            ServiceReference2.JobApplication j = new ServiceReference2.JobApplication();
            string name = GridView1.Rows[x].Cells[1].Text;
            string postname = GridView1.Rows[x].Cells[2].Text;
            string k = s.DeletePostedJob(name,postname);
            Response.Redirect("company.aspx");

        }
    }
}