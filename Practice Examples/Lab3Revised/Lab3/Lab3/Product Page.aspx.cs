using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Lab3
{
    public partial class Product_Page : System.Web.UI.Page
    {
        string cs, id, name;
        double price;
        int quan;
        protected void Page_Load(object sender, EventArgs e)
        {
            cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        }

        private void retrievedInfo()
        {
            id = txtId.Text;
            name = txtName.Text;
            if(txtPrice.Text.Trim() != null && txtPrice.Text.Trim() != "")
            price = Convert.ToDouble(txtPrice.Text);
            if(txtQuantity.Text.Trim() != null && txtQuantity.Text.Trim() != "")
            quan = Convert.ToInt16(txtQuantity.Text);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection(cs))
            {
                retrievedInfo();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "DELETE FROM productinfo WHERE id=@id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Connection = con;
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected != 0)
                {
                    lblMessage.ForeColor = System.Drawing.Color.Black;
                    lblMessage.Text = "Status: The Product has been deleted successfully";
                }                   
                else
                {
                    lblMessage.Text = "Status: There is no product with that Id. No change was made.";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }                   
            }
        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                retrievedInfo();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT name, price, quantity FROM ProductInfo WHERE id=@id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    txtName.Text = rdr["name"].ToString();
                    txtPrice.Text = rdr["price"].ToString();
                    txtQuantity.Text = rdr["quantity"].ToString();
                    lblMessage.ForeColor = System.Drawing.Color.Black;
                    lblMessage.Text = "Status: Product retrieved successfully";
                }
                else
                {
                    lblMessage.Text = "Status: Failed to load the product with the given Id. Id may not exist";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    txtName.Text = "";
                    txtPrice.Text = "";
                    txtQuantity.Text = "";
                    txtId.Focus();
                    txtId.Attributes.Add("onfocus", "this.select();");
                }
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection(cs))
            {
                retrievedInfo();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO productinfo(name, price, quantity) VALUES (@name, @price, @quantity)";
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@quantity", quan);
                cmd.Connection = con;
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected != 0)
                {
                    lblMessage.ForeColor = System.Drawing.Color.Black;
                    lblMessage.Text = "Status: New product inserted successfully!";
                }                   
                else
                {
                    lblMessage.Text = "Status: There is no product with that Id. No change was made.";
                    lblMessage.ForeColor = System.Drawing.Color.Black;
                }

            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection(cs))
            {
                retrievedInfo();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "UPDATE productinfo SET name=@name, price=@price, quantity=@quantity WHERE id=@id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@quantity", quan);
                cmd.Connection = con;
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if(rowsAffected != 0)
                {
                    lblMessage.ForeColor = System.Drawing.Color.Black;
                    lblMessage.Text = "Status: Product updated successfully";
                }
                else
                {
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    lblMessage.Text = "Status: Update Fail!";
                }
            }
        }
    }
}