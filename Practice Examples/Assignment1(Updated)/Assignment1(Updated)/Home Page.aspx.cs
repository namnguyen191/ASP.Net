using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Assignment1_Updated_
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string cs, query;
        protected void Page_Load(object sender, EventArgs e)
        {
            cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection(cs))
            {
                query = "SELECT * FROM [User] WHERE [User's Name] = @username AND [User's Password] = @password";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@username", txtName.Text);
                cmd.Parameters.AddWithValue("@password", txtPass.Text);
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    HttpCookie cookie = new HttpCookie("userid");
                    cookie.Value = rdr[2].ToString();
                    switch (rdr[3].ToString())
                    {
                        case "Admin":
                            Response.Cookies.Add(cookie);
                            Response.Redirect("~/Admin Form.aspx");
                            break;
                        case "Patient":
                            Response.Cookies.Add(cookie);
                            Response.Redirect("~/Patient Form.aspx");
                            break;
                        case "Doctor":
                            Response.Cookies.Add(cookie);
                            Response.Redirect("~/Doctor Form.aspx");
                            break;
                        default: break;
                    }                    
                }
                else
                {
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    lblMessage.Text = "Login failed! Invalid username or password.";
                }
            }
        }
    }
}