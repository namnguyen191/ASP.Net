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
    public partial class WebForm2 : System.Web.UI.Page
    {
        Patient pat;
        private string cs, query;
        HttpCookie cookie;
        
        protected void Page_Init(object sender, EventArgs e)
        {

            cookie = Request.Cookies["userid"];
            int id = Convert.ToInt16(cookie.Value);
            pat = new Patient();
            pat = pat.GetPatient(id);
            patientlbl.Text = "Welcome " + pat.FName + "" +pat.LName;
            firstnametxt.Text = pat.FName;
            firstnametxt.Text = pat.FName;
            lastnametxt.Text = pat.LName;
            addresstxt.Text = pat.Address;
            postalcodetxt.Text = pat.Postal;
        }


        protected void searchbtn_Click(object sender, EventArgs e)
        {
            cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            HttpCookie cookie = Request.Cookies["userid"];
            query = "SELECT * FROM [Visit History] WHERE [Doctor's Id] = @id And [Patient's Id] = @pid";
            using (SqlConnection con = new SqlConnection(cs))
            {


                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@pid", cookie.Value);
                da.SelectCommand.Parameters.AddWithValue("@id", doctoridtxt.Text);
                DataSet ds = new DataSet();
                da.Fill(ds, "history");
                ViewState["query"] = query;
                if (ds.Tables[0].Rows.Count != 0)
                {
                    viewallgv.DataSource = ds;
                    viewallgv.DataBind();
                }
                else
                {
                    patientlbl.Text = "No data found";
                }

            }
        }

        protected void updatebtn_Click(object sender, EventArgs e)
        {

            patientlbl.Text = pat.UpdatePatient(Convert.ToInt32(cookie.Value), firstnametxt.Text, lastnametxt.Text, addresstxt.Text, postalcodetxt.Text);
        }

        protected void viewallbtn_Click(object sender, EventArgs e)
        {
            cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            HttpCookie cookie = Request.Cookies["userid"];
            query = "SELECT * FROM [Visit History] WHERE [Patient's Id] = @id";
           

            using (SqlConnection con = new SqlConnection(cs))
            {
               

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@id", cookie.Value);
                DataSet ds = new DataSet();
                da.Fill(ds, "history");
                ViewState["query"] = query;
                if(ds.Tables[0].Rows.Count != 0)
                {
                    viewallgv.DataSource = ds;
                    viewallgv.DataBind();
                }
                else
                {
                    patientlbl.Text = "No data found";
                }

            }
        }

    }
        
    
}