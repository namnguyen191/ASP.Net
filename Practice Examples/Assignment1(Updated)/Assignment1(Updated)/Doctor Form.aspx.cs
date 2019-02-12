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
        int id;
        Doctor doc;
        Patient pat;
        string status;
        private static string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        protected void Page_Init(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["userid"];
            id = Convert.ToInt16(cookie.Value);
            doc = new Doctor();
            pat = new Patient();
            doc = doc.GetDoctor(id);
            lblWelcome.Text = "Welcome doctor " + doc.LName + "!";
            txtFName.Text = doc.FName;
            txtLName.Text = doc.LName;
            txtAddress.Text = doc.Address;
            txtPostal.Text = doc.Postal;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            status = doc.UpdateDoctor(id, txtFName.Text, txtLName.Text, txtAddress.Text, txtPostal.Text);
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + status + "');", true);
        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM [Visit History] WHERE [Doctor's Id]= @docId AND [Id] = @id");
                cmd.Parameters.AddWithValue("@docId", id);
                cmd.Parameters.AddWithValue("@id", txtVisitId.Text);
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    txtVisitDate.Text = ((DateTime)rdr[1]).ToString("d");
                    txtVisitStartTime.Text = rdr[2].ToString();
                    txtVisitEndTime.Text = rdr[3].ToString();
                    txtPatientId.Text = rdr[4].ToString();
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Data Load Successfully!" + "');", true);
                }
                else
                {
                    txtVisitDate.Text = "";
                    txtVisitStartTime.Text = "";
                    txtVisitEndTime.Text = "";
                    txtPatientId.Text = "";
                    txtVisitId.Focus();
                    txtVisitId.Attributes.Add("onfocus", "this.select();");
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "No Record Found!" + "');", true);
                }
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [Visit History] ([Date],[Start Time],[End Time],[Patient's Id], [Doctor's Id]) VALUES (@date, @start, @end, @pId, @docId)");
                cmd.Parameters.AddWithValue("@date", txtVisitDate.Text);
                cmd.Parameters.AddWithValue("@start", txtVisitStartTime.Text);
                cmd.Parameters.AddWithValue("@end", txtVisitEndTime.Text);
                cmd.Parameters.AddWithValue("@pId", txtPatientId.Text);
                cmd.Parameters.AddWithValue("@docId", id);
                cmd.Connection = con;
                con.Open();
                int rowsIns = cmd.ExecuteNonQuery();
                if (rowsIns > 0)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Visit Added Successfully" + "');", true);
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Fail to add visit!" + "');", true);
                }
            }
        }

        protected void btnModifiy_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("UPDATE [Visit History] SET [Date] = @date, [Start Time] = @start, [End Time] = @end, [Patient's Id] = @pId WHERE [Doctor's Id] = @docId AND [Id] = @id");
                cmd.Parameters.AddWithValue("@date", txtVisitDate.Text);
                cmd.Parameters.AddWithValue("@start", txtVisitStartTime.Text);
                cmd.Parameters.AddWithValue("@end", txtVisitEndTime.Text);
                cmd.Parameters.AddWithValue("@pId", txtPatientId.Text);
                cmd.Parameters.AddWithValue("@docId", id);
                cmd.Parameters.AddWithValue("@id", txtVisitId.Text);
                cmd.Connection = con;
                con.Open();
                int rowsUpd = cmd.ExecuteNonQuery();
                if (rowsUpd > 0)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Visit Updated Successfully" + "');", true);
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Fail to update visit!" + "');", true);
                }
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM [Visit History] WHERE [Doctor's Id] = @docId AND [Id] = @id");
                cmd.Parameters.AddWithValue("@id", txtVisitId.Text);
                cmd.Parameters.AddWithValue("@docId", id);
                cmd.Connection = con;
                con.Open();
                int rowsDel = cmd.ExecuteNonQuery();
                if (rowsDel > 0)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Visit Deleted Successfully" + "');", true);
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Fail to delete visit!" + "');", true);
                }
            }
        }

        protected void btnDischarge_Click(object sender, EventArgs e)
        {
            status = pat.DischargePatient(Convert.ToInt16(txtDischargePatientId.Text));
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + status + "');", true);
        }

        protected void btnViewAll_Click(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM [Visit History] WHERE [Doctor's Id] = @docId");
                cmd.Parameters.AddWithValue("@docId", id);
                cmd.Connection = con;
                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if((txtSearchDate.Text == null || txtSearchDate.Text == "") && (txtSearchPatientId.Text == null || txtSearchPatientId.Text == ""))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Please enter date or id" + "');", true);
                return;
            }
            if ((txtSearchDate.Text != null && txtSearchDate.Text != "") && (txtSearchPatientId.Text != null && txtSearchPatientId.Text != ""))
            {
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [Visit History] WHERE [Doctor's Id] = @docId AND [Patient's Id] = @pId AND [Date] = @date", con);
                    da.SelectCommand.Parameters.AddWithValue("@docId", id);
                    da.SelectCommand.Parameters.AddWithValue("@pId", txtSearchPatientId.Text);
                    da.SelectCommand.Parameters.AddWithValue("@date", txtSearchDate.Text);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "vist");
                    ViewState["query"] = "SELECT * FROM [Visit History] WHERE [Doctor's Id] = @docId AND [Patient's Id] = @pId AND [Date] = @date";
                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        GridView1.DataSource = ds;
                        GridView1.DataBind();
                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "No record found!" + "');", true);
                    }
                }
                return;
            }
                if (txtSearchDate.Text == null || txtSearchDate.Text == "")
            {
                using(SqlConnection con = new SqlConnection(CS))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [Visit History] WHERE [Doctor's Id] = @docId AND [Patient's Id] = @pId", con);
                    da.SelectCommand.Parameters.AddWithValue("@docId", id);
                    da.SelectCommand.Parameters.AddWithValue("@pId", txtSearchPatientId.Text);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "vist");
                    ViewState["query"] = "SELECT * FROM [Visit History] WHERE [Doctor's Id] = @docId AND [Patient's Id] = @pId";
                    if(ds.Tables[0].Rows.Count != 0)
                    {
                        GridView1.DataSource = ds;
                        GridView1.DataBind();
                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "No record found!" + "');", true);
                    }
                }
            }
            else
            {
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [Visit History] WHERE [Doctor's Id] = @docId AND [Date] = @date", con);
                    da.SelectCommand.Parameters.AddWithValue("@docId", id);
                    da.SelectCommand.Parameters.AddWithValue("@date", txtSearchDate.Text);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "vist");
                    ViewState["query"] = "SELECT * FROM [Visit History] WHERE [Doctor's Id] = @docId AND [Date] = @date";
                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        GridView1.DataSource = ds;
                        GridView1.DataBind();
                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "No record found!" + "');", true);
                    }
                }
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtSearchDate.Text = Calendar1.SelectedDate.ToString("d");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Calendar1.Visible = true;
        }
    }
}