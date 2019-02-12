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
    public partial class WebForm4 : System.Web.UI.Page
    {
        string cs, query;
        protected void Page_Load(object sender, EventArgs e)
        {
            cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            query = "INSERT INTO [Doctor] VALUES (@name, @address, @specialization)";
            if(txtName.Text != null && txtName.Text != "" && txtAddress.Text != null && txtAddress.Text != "" && txtSpecial.Text != null && txtSpecial.Text != "")
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand(query);
                    cmd.Connection = con;
                    con.Open();
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@specialization", txtSpecial.Text);
                    cmd.ExecuteNonQuery();
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                    lblMessage.Text = "New doctor profile added!";
                }
            } 
            else
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Fail to add new doctor!";
            }            
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtId.Text == null)
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Cannot perform an update without an ID! Please Provide 1.";
            }
            else
            {
                query = "UPDATE [Doctor] SET Name = @name, Address = @address, Specialization = @specialization WHERE Id = @id";
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand(query);
                    cmd.Connection = con;
                    con.Open();
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@specialization", txtSpecial.Text);
                    cmd.Parameters.AddWithValue("@id", txtId.Text);
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

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM [Doctor] WHERE Id = @id";
            using(SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtName.Text = reader[1].ToString();
                    txtAddress.Text = reader[2].ToString();
                    txtSpecial.Text = reader[3].ToString();
                    lblMessage.Text = "";
                }
                else
                {
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    lblMessage.Text = "No data was found!";
                    txtName.Text = "";
                    txtAddress.Text = "";
                    txtSpecial.Text = "";
                    txtId.Focus();
                    txtId.Attributes.Add("onfocus", "this.select();");
                }
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtId.Text == "" || txtId.Text == null)
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Cannot perform a delete without an ID! Please Provide 1.";
            }
            else
            {
                query = "DELETE FROM [Doctor] WHERE Id = @id";
                using(SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand(query);
                    cmd.Connection = con;
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", txtId.Text);
                    int rowsAff = cmd.ExecuteNonQuery();
                    if(rowsAff > 0)
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

        protected void btnView_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM [Doctor]";
            using(SqlConnection con = new SqlConnection(cs))
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
    }
}