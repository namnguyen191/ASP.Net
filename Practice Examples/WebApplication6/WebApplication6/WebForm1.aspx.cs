using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                //SqlCommand cmd = new SqlCommand("select count(id) from table");
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select count(Id) from students";
                cmd.Connection = con;
                con.Open();
                int rows = (int)cmd.ExecuteScalar(); // for 1 value
                Response.Write("The number of students is " + rows.ToString() + "<br>");
                cmd = new SqlCommand("insert into student values('Bob','xx','Accounting')");
                int rowsAffected = cmd.ExecuteNonQuery();
                Response.Write("The number of rows inserted is: " + rowsAffected.ToString() + "<br>");
            }

        }
    }
}