using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace Assignment1
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        string cs, query;
        protected void Page_Load(object sender, EventArgs e)
        {
            cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM [Record]";
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = con;
                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
            }
            GridView1.Visible = true;
            GridView1.Enabled = true;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtDId.Text != null && txtDId.Text != "" &&
               txtPId.Text != null && txtPId.Text != "" &&
               txtHealth.Text != null && txtHealth.Text != "" &&
               txtStatus.Text != null && txtStatus.Text != "")
            {
                query = "INSERT INTO [Record] VALUES (@pid, @health, @did, @status)";
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand(query);
                    cmd.Connection = con;
                    con.Open();
                    cmd.Parameters.AddWithValue("@pid", txtPId.Text);
                    cmd.Parameters.AddWithValue("@health", txtHealth.Text);
                    cmd.Parameters.AddWithValue("@did", txtDId.Text);
                    cmd.Parameters.AddWithValue("@status", txtStatus.Text);
                    cmd.ExecuteNonQuery();
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                    lblMessage.Text = "New record added!";
                }
            }
            else
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Fail to add new record!";
            }
            
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtId.Text == null)
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Cannot perform an update without a Case ID! Please Provide 1.";
            }
            else
            {
                query = "UPDATE [Record] SET [Patient Id] = @pid, [Health Condition] = @health, [Assigned Doctor Id] = @did, [Status] = @status WHERE [Case Id] = @id";
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand(query);
                    cmd.Connection = con;
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", txtId.Text);
                    cmd.Parameters.AddWithValue("@pid", txtPId.Text);
                    cmd.Parameters.AddWithValue("@health", txtHealth.Text);
                    cmd.Parameters.AddWithValue("@did", txtDId.Text);
                    cmd.Parameters.AddWithValue("@status", txtStatus.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                        lblMessage.Text = "Update Successfully!";
                    }
                    else
                    {
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                        lblMessage.Text = "No change was made!";
                    }
                }
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtId.Text == null)
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Cannot perform a delete without a Case ID! Please Provide 1.";
            }
            else
            {
                query = "DELETE FROM [Record] WHERE [Case Id] = @id";
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand(query);
                    cmd.Connection = con;
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", txtId.Text);
                    int rowsAff = cmd.ExecuteNonQuery();
                    if (rowsAff > 0)
                    {
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                        lblMessage.Text = "Delete Successfully!";
                    }
                    else
                    {
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                        lblMessage.Text = "No change was made!";
                    }
                }
            }
        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM [Record] WHERE [Case Id] = @id";
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtPId.Text = reader[1].ToString();
                    txtHealth.Text = reader[2].ToString();
                    txtDId.Text = reader[3].ToString();
                    txtStatus.Text = reader[4].ToString();
                    lblMessage.Text = "";
                }
                else
                {
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    lblMessage.Text = "No data was found!";
                    txtPId.Text = "";
                    txtHealth.Text = "";
                    txtDId.Text = "";
                    txtStatus.Text = "";
                    txtId.Focus();
                    txtId.Attributes.Add("onfocus", "this.select();");
                }
            }
        }
    }
}