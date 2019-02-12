using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment1_Updated_
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        HttpCookie cookie;
        int userId;
        Patient pat;
        static string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        protected void Page_Init(object sender, EventArgs e)
        {
            cookie = Request.Cookies["userid"];
            userId = Convert.ToInt16(cookie.Value);
            pat = new Patient();
            pat = pat.GetPatient(userId);
            patientlbl.Text = "Welcome " + pat.FName + "! How are you to day?";
            firstnametxt.Text = pat.FName;
            lastnametxt.Text = pat.LName;
            addresstxt.Text = pat.Address;
            postalcodetxt.Text = pat.Postal;

        }

        protected void updatebtn_Click(object sender, EventArgs e)
        {
            lblMessage.Text = pat.UpdatePatient(userId, firstnametxt.Text, lastnametxt.Text, addresstxt.Text, postalcodetxt.Text, pat.Doctor);
        }

        protected void viewallbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {


                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [Visit History] WHERE [Patient's Id] = @id", con);
                da.SelectCommand.Parameters.AddWithValue("@id", userId);
                DataSet ds = new DataSet();
                da.Fill(ds, "history");
                if (ds.Tables[0].Rows.Count != 0)
                {
                    GridView1.DataSource = ds;
                    GridView1.DataBind();
                }
                else
                {
                    lblHistoryMessage.Text = "No data found";
                }

            }
        }

        protected void searchbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {


                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [Visit History] WHERE [Doctor's Id] = @id And [Patient's Id] = @pid", con);
                da.SelectCommand.Parameters.AddWithValue("@pid", userId);
                da.SelectCommand.Parameters.AddWithValue("@id", txtDocId.Text);
                DataSet ds = new DataSet();
                da.Fill(ds, "history");
                if (ds.Tables[0].Rows.Count != 0)
                {
                    GridView1.DataSource = ds;
                    GridView1.DataBind();
                }
                else
                {
                    lblHistoryMessage.Text = "No data found";
                }

            }
        }
    }
}