using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

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

        protected void btnTest_Click(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection(cs))
            {
                string SelectQuery = "SELECT * FROM productinfo";
                SqlDataAdapter da = new SqlDataAdapter(SelectQuery, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "ProductInfoTestingTable");
                Cache["DataSet"] = ds;
                ViewState["SelectQuery"] = SelectQuery;
                DataTable tblProductsInfo = ds.Tables["ProductInfoTestingTable"];
                if(tblProductsInfo.Rows.Count == 1)
                {
                    DataRow dr = tblProductsInfo.Rows[0];
                    txtName.Text = dr["Name"].ToString();
                    lblMessage.Text = "Product loaded successfully!";
                }
                else
                {
                    lblMessage.Text = "Product not found";
                }
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
        }

        protected void btnClearCache_Click(object sender, EventArgs e)
        {
            if(Cache["DataSet"] != null)
            {
                Cache.Remove("DataSet");
                lblMessage.Text = "Cache cleared";
            }
            else
            {
                lblMessage.Text = "No change was made";
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
                DataSet ds = (DataSet)Cache["DataSet"];
                string selectQuery = ViewState["selectQuery"].ToString();
                string id = txtId.Text;
                using(SqlConnection conn = new SqlConnection(cs))
                {
                    SqlDataAdapter da = new SqlDataAdapter(selectQuery, conn);
                    da.SelectCommand.Parameters.AddWithValue("@id", id);
                    DataTable tblProduct = ds.Tables["product"];
                    if(tblProduct.Rows.Count == 1)
                    {
                        DataRow dr = tblProduct.Rows[0];
                        dr["name"] = txtName.Text;
                        dr["price"] = txtPrice.Text;
                        dr["quantity"] = txtQuantity.Text;
                        SqlCommandBuilder builder = new SqlCommandBuilder();
                        int rowsUpdated = da.Update(ds, "product");
                        if(rowsUpdated == 1)
                        {
                            lblMessage.Text = "Data updated successfully!";
                            lblMessage.ForeColor = System.Drawing.Color.Green;
                        }
                    }
                }
            }
        }
    }
}