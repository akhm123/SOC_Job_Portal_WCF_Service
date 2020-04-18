using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace jobportalservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\harsh\Documents\ExSoc.mdf;Integrated Security=True;Connect Timeout=30");
        public DataSet SelectUserbyCompany(string CompanyName)
        {
          
            con.Open();
           
            SqlCommand cmd = new SqlCommand("Select * from [User] where UserName in(Select UserName from JobApplication where Companyname=@Company)", con);
            cmd.Parameters.AddWithValue("@Company", CompanyName);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();
            return ds;
        }

        public DataSet SelectUserbyPostCompany(string CompanyName,string jobid)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from [User] where UserName in(Select UserName from JobApplication where Companyname=@Company and Jobid=@jobid)", con);
            cmd.Parameters.AddWithValue("@Company", CompanyName);
            cmd.Parameters.AddWithValue("@jobid", jobid);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();
            return ds;
        }

        public string UpdateUser(User user)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update [User] set Password=@Password,Contact=@Contact, Email=@Email where UserName=@UserName", con);
            cmd.Parameters.AddWithValue("@Password",user.Password);
            cmd.Parameters.AddWithValue("@Contact",user.Contact);
            cmd.Parameters.AddWithValue("@Email",user.Email);
            cmd.Parameters.AddWithValue("@UserName", user.UserName);
            cmd.ExecuteNonQuery();
            return "updated";
            //return "not update";
        }

        public string InsertData(CompanyDetails c)
        {
            string Message;
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Company(name,postname,vacancy,qualification,salary,description,jobid) values(@name,@postname,@vacancy,@qualification,@salary,@description,@jobid)", con);
            cmd.Parameters.AddWithValue("@name",c.Name);
            cmd.Parameters.AddWithValue("@postname",c.Postname );
            cmd.Parameters.AddWithValue("@vacancy",c.Vacancy);
            cmd.Parameters.AddWithValue("@qualification",c.Qualification);
            cmd.Parameters.AddWithValue("@salary", c.Salary);
            
            cmd.Parameters.AddWithValue("@description",c.Description);
            cmd.Parameters.AddWithValue("@jobid", c.Jobid);

            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Message = " Details inserted successfully";
            }
            else
            {
                Message =  " Details not inserted successfully";
            }
            con.Close();
            return Message;
        }



        public DataSet GetCompanyData()
        {
            string message;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Company", con);// (name,postname,vacancy,qualification,salary,description,jobid) values(@name,@postname,@vacancy,@qualification,@salary,@description,@jobid)", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();
            return ds;

            //SqlDataReader rd = cmd.ExecuteReader();
            //var tupleList = new List<Tuple<int, string,string>>();
            //while (rd.Read())
            //{
            //    var t= Tuple.Create(Int32.Parse(rd["Id"].ToString()), rd["name"].ToString(), rd["postname"].ToString());
            //    tupleList.Add(t);
            //}
            //return tupleList;


        }

        public string ApplyForCompany(JobApplication a)
        {
            string message;
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into JobApplication (UserName,Companyname,Jobid) values(@UserName,@Company,@Jobid)", con);
            cmd.Parameters.AddWithValue("@UserName", a.UserName);
            cmd.Parameters.AddWithValue("@Company", a.Companyname);
            cmd.Parameters.AddWithValue("@jobid", a.Jobid);
            int result = cmd.ExecuteNonQuery();
            //int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                message = a.UserName + " has applied for " + a.Companyname;
            }
            else
            {
                message = " Details not inserted successfully";
            }
            con.Close();
            return message;
        }


        public string Login(User u)
        {
            string message;
            con.Open();


            SqlCommand cmd1 = new SqlCommand("select * from [User] where UserName=@user and Password=@pass and Role=@role", con);
            cmd1.Parameters.AddWithValue("@user", u.UserName);
            cmd1.Parameters.AddWithValue("@pass", u.Password);
            cmd1.Parameters.AddWithValue("@role", u.Role);
            SqlDataReader rdr = cmd1.ExecuteReader();
            if (rdr.Read())
            {
                return "login";
            }
            con.Close();
            return "login fail";
        }


        public DataSet getUser(string username)
        {
            string message;
            con.Open();


            SqlCommand cmd1 = new SqlCommand("select * from [User] where UserName=@user", con);
            cmd1.Parameters.AddWithValue("@user", username);
            cmd1.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd1);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmd1.ExecuteNonQuery();
            con.Close();
            return ds;

        }

        public string AddUser(User u)
        {
            string message;
            con.Open();


            SqlCommand cmd1 = new SqlCommand("select * from [User] where UserName=@user", con);
            cmd1.Parameters.AddWithValue("@user", u.UserName);

            SqlDataReader rdr = cmd1.ExecuteReader();
            if (rdr.Read())
            {
                return "Username already exist";
            }
            con.Close();

            con.Open();
            SqlCommand cmd = new SqlCommand("insert into [User] (UserName,Password,Contact,Email,Role) values(@UserName,@Password,@contact,@email,@role)", con);
           // cmd.Parameters.AddWithValue("@UserId", u.UserID);
            cmd.Parameters.AddWithValue("@UserName", u.UserName);
            cmd.Parameters.AddWithValue("@Password", u.Password);
            cmd.Parameters.AddWithValue("@contact", u.Contact);
            cmd.Parameters.AddWithValue("@email", u.Email);
            cmd.Parameters.AddWithValue("@role", u.Role);
            int result = cmd.ExecuteNonQuery();
            //int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                message = u.UserName + " added";// + a.Companyname;
            }
            else
            {
                message = " Details not inserted successfully";
            }
            con.Close();
            return message;
        }
    }
}
