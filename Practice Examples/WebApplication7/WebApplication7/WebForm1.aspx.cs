using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string cs;
        protected void Page_Load(object sender, EventArgs e)
        {
            cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            /*using(SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select count(id) from students";
                cmd.Connection = con;
                con.Open();
                int rows = (int)cmd.ExecuteScalar();
                Response.Write("The number of students is: " + rows + "<br>");
                cmd = new SqlCommand("insert into students values('Bob','XX','Accounting')",con);
                int rowsAffected = cmd.ExecuteNonQuery();
                Response.Write("The number of rows affected is: " + rowsAffected.ToString() + "<br>");
                SqlCommand cmd2 = new SqlCommand("update students set program='HR' where id = 1",con);
                rows = cmd2.ExecuteNonQuery();
                Response.Write("The number of rows updated is: " + rowsAffected.ToString() + "<br>");
                SqlCommand cmd3 = new SqlCommand("delete from students where id = 3", con);
                rowsAffected = cmd3.ExecuteNonQuery();
                Response.Write("The number of rows deleted is: " + rowsAffected.ToString());
        } */
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text;

            //string query = "select username from users where username='"+username+"' AND password='"+password+"'";
            string query = "select username from users where username=@username and password=@password";
            using(SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    lblMessage.Text = "Login was successful";
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblMessage.Text = "Incorrect username and/or password";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
            }
        }
    }
}