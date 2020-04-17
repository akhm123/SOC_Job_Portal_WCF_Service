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
                JobPortalRef.Service1Client s = new JobPortalRef.Service1Client("BasicHttpBinding_IService1");
                DataSet ds = s.GetCompanyData();
                DataTable dt = ds.Tables[0];
                List<string> l = (from DataRow dr in dt.Rows

                                  select (string)dr["name"]).ToList<string>();
                DropDownList1.DataSource = l;
                DropDownList1.DataBind();
            }

        }

        

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

       
    }
}