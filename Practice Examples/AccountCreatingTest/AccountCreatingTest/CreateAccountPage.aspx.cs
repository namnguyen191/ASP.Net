using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
{
    public partial class CreateAccountPage : System.Web.UI.Page
    {
        string cs, query;
        protected void Page_Load(object sender, EventArgs e)
        {
            cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            
            using(SqlConnection con = new SqlConnection(cs))
            {
                query = "INSERT INTO UserAccount(username, password) VALUES(@username, @password) ";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue
            }
        }
    }
}