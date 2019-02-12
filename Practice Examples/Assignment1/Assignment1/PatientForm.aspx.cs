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
    public partial class WebForm5 : System.Web.UI.Page
    {
        string cs, query;

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM [Patient] WHERE Id = @id";
            using (SqlConnection con = new SqlConnection(cs))
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
                    txtPostalCode.Text = reader[3].ToString();
                    txtAge.Text = reader[4].ToString();
                    txtGender.Text = reader[5].ToString();
                    lblMessage.Text = "";
                }
                else
                {
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    lblMessage.Text = "No data was found!";
                    txtName.Text = "";
                    txtAddress.Text = "";
                    txtPostalCode.Text = "";
                    txtAge.Text = "";
                    txtGender.Text = "";
                    txtId.Focus();
                    txtId.Attributes.Add("onfocus", "this.select();");
                }
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            query = "INSERT INTO [Patient] VALUES (@name, @address, @postal, @age, @gender)";
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@postal", txtPostalCode.Text);
                cmd.Parameters.AddWithValue("@age", txtAge.Text);
                cmd.Parameters.AddWithValue("@gender", txtGender.Text);
                cmd.ExecuteNonQuery();
            }
        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM [Patient]";
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = con;
                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
            }

            GridView1.Visible = true;
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
                query = "UPDATE [Patient] SET Name = @name, Address = @address, [Postal Code] = @postal, Age  = @age, Gender = @gender WHERE Id = @id";
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand(query);
                    cmd.Connection = con;
                    con.Open();
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@postal", txtPostalCode.Text);
                    cmd.Parameters.AddWithValue("@age", txtAge.Text);
                    cmd.Parameters.AddWithValue("@gender", txtGender.Text);
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

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtId.Text == null)
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Cannot perform a delete without an ID! Please Provide 1.";
            }
            else
            {
                query = "DELETE FROM [Patient] WHERE Id = @id";
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

        protected void Page_Load(object sender, EventArgs e)
        {
            cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        }
    }
}