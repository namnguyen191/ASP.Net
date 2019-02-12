using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ApointmentSystemTest
{
    public partial class Appointment : System.Web.UI.Page
    {
        string cs, query;
        protected void Page_Load(object sender, EventArgs e)
        {
            cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtDate.Text = Calendar1.SelectedDate.ToString("d");
            using(SqlConnection con = new SqlConnection(cs))
            {
                query = "INSERT INTO [Appointment] VALUES (@date, @from, @to)";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@date", txtDate.Text);
                cmd.Parameters.AddWithValue("@from", txtFrom.Text);
                cmd.Parameters.AddWithValue("@to", txtTo.Text);
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}