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
    public partial class WebForm3 : System.Web.UI.Page
    {

        Doctor doc;
        private string cs, query;
        HttpCookie cookie;

        protected void Page_Init(object sender, EventArgs e)
        {
            cookie = Request.Cookies["userid"];
            doc = new Doctor();
            doc = doc.GetDoctor(Convert.ToInt16(cookie.Value));
            doctormessagelbl.Text = "Welcome " + doc.FName + "" + doc.LName;
            firstnametxt.Text = doc.FName;
            firstnametxt.Text = doc.FName;
            lastnametxt.Text = doc.LName;
            addresstxt.Text = doc.Address;
            postalcodetxt.Text = doc.Postal;

        }
        protected void updatebtn_Click(object sender, EventArgs e)
        {
            doctormessagelbl.Text = doc.UpdateDoctor(Convert.ToInt32(cookie.Value), firstnametxt.Text, lastnametxt.Text, addresstxt.Text, postalcodetxt.Text);
        }

        protected void deletebtn_Click(object sender, EventArgs e)
        {
            cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM [Visit History] WHERE [Patient's Id] = @pid");
                cmd.Parameters.AddWithValue("@pid", patientidtxt.Text);
                cmd.Connection = con;
                con.Open();
                int rowsDel = cmd.ExecuteNonQuery();
                if (rowsDel > 0)
                {
                    doctormessagelbl.Text = "Delete Successfully!";
                }
                else
                {
                    doctormessagelbl.Text = "Delete Failed!";
                }
            }
        }

        protected void modifybtn_Click(object sender, EventArgs e)
        {
            cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("UPDATE [Visit History] SET [Start Time] = @starttime, [End Time] = @endtime WHERE [Patient's Id] = @pid");
                cmd.Parameters.AddWithValue("@starttime", starttimetxt.Text);
                cmd.Parameters.AddWithValue("@endtime", endtimetxt.Text);
                cmd.Parameters.AddWithValue("@pid", patientidtxt.Text);
                cmd.Connection = con;
                con.Open();
                int rowsUp = cmd.ExecuteNonQuery();
                if (rowsUp > 0)
                {
                    doctormessagelbl.Text = "Modify Successfully!";
                }
                else
                {
                    doctormessagelbl.Text = "Modify Failed!";
                }
            }
        }

        protected void updatepatientstatusbtn_Click(object sender, EventArgs e)
        {
            cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("UPDATE [Patient] SET [Status] = @status WHERE [Id] = @pid");
                cmd.Parameters.AddWithValue("@status", patientstatustxt.Text);
                cmd.Parameters.AddWithValue("@pid", patientidtxt.Text);
                cmd.Connection = con;
                con.Open();
                int rowsUp = cmd.ExecuteNonQuery();
                if (rowsUp > 0)
                {
                    doctormessagelbl.Text = "Update status Successfully!";
                }
                else
                {
                    doctormessagelbl.Text = "Update status Failed!";
                }
            }
        }

        protected void searchhistorytxt_Click(object sender, EventArgs e)
        {
            cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            cookie = Request.Cookies["userid"];
            query = "SELECT * FROM [Visit History] WHERE ([Patient's Id] = @pid AND [Start Time] = @starttime AND [Doctor's Id] = @did)";


            using (SqlConnection con = new SqlConnection(cs))
            {


                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@did", cookie.Value);
                da.SelectCommand.Parameters.AddWithValue("@pid", patientidtxt.Text);
                da.SelectCommand.Parameters.AddWithValue("@starttime", starttimetxt.Text);
                DataSet ds = new DataSet();
                da.Fill(ds, "history");
                ViewState["query"] = query;
                if (ds.Tables[0].Rows.Count != 0)
                {
                    GridView.DataSource = ds;
                    GridView.DataBind();
                }
                else
                {
                    doctormessagelbl.Text = "No data found";
                }

            }
        }

        protected void addbtn_Click(object sender, EventArgs e)
        {
            cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                cookie = Request.Cookies["userid"];
                SqlCommand cmd = new SqlCommand("INSERT INTO [Visit History] ([Start Time], [End Time], [Patient's Id], [Doctor's Id]) VALUES (@starttime, @endtime, @pid, @did)");
                cmd.Parameters.AddWithValue("@starttime", starttimetxt.Text);
                cmd.Parameters.AddWithValue("@endtime", endtimetxt.Text);
                cmd.Parameters.AddWithValue("@pid", patientidtxt.Text);
                cmd.Parameters.AddWithValue("@did", cookie.Value);
                cmd.Connection = con;
                con.Open();
                int rowInst = cmd.ExecuteNonQuery();
                if (rowInst > 0)
                {
                    doctormessagelbl.Text = "Insert successfully ";
                }
                else
                {
                    doctormessagelbl.Text = "Insert Failed!";
                }
            }
        }

        
    }
}