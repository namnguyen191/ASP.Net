using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Week5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Humber\ASP\VSProjects\Week5\Week5\App_Data\Database1.mdf;Integrated Security=True";
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                //SqlConnection con = new SqlConnection();
                //con.ConnectionString = cs;
                SqlCommand cmd = new SqlCommand("SELECT * FROM students", con);
                // SqlDataReader rdr = cmd.ExecuteReader();
                //GridView1.DataSource = rdr;
                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
            }
        }
    }
}