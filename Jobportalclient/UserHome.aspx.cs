using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Jobportalclient
{
    public partial class UserHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
<<<<<<< HEAD
                ServiceReference2.Service1Client s = new ServiceReference2.Service1Client("BasicHttpBinding_IService1");
=======
                JobPortalRef.Service1Client s = new JobPortalRef.Service1Client("BasicHttpBinding_IService1");
>>>>>>> 75131fa61f20113d733be844fbb8e9ea071441f3
                DataSet ds = s.GetCompanyData();
                DataTable dt = ds.Tables[0];
                List<string> l = (from DataRow dr in dt.Rows

                                  select (string)dr["name"]).ToList<string>();
<<<<<<< HEAD
              
=======
                DropDownList1.DataSource = l;
                DropDownList1.DataBind();
>>>>>>> 75131fa61f20113d733be844fbb8e9ea071441f3
            }

        }

<<<<<<< HEAD
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("profile.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }
=======
        

        protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            JobPortalRef.Service1Client s = new JobPortalRef.Service1Client("BasicHttpBinding_IService1");
            string c = DropDownList1.SelectedValue;//.Text;
            Label1.Text = c;
            DataSet ds = s.GetCompanyData();
            DataTable dt = ds.Tables[0];
            string SearchByColumn = "name = name";// + c;
            var rows = dt.AsEnumerable()
               .Where(r => r.Field<string>("name") == c);

            //  DataRow[] hasRows = dt.Rows.Find(c);// (Select(SearchByColumn)''

            GridView1.DataSource = rows.CopyToDataTable();
            GridView1.DataBind();
        }

       
>>>>>>> 75131fa61f20113d733be844fbb8e9ea071441f3
    }
}