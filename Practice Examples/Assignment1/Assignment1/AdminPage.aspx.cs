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
    public partial class WebForm2 : System.Web.UI.Page
    {
        string cs, query;
        protected void Page_Load(object sender, EventArgs e)
        {
            cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection(cs))
            {
                query = "SELECT * FROM [Admin]";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dba = new DataTable();
                dba.Load(rdr);
                for(int i = 0; i<dba.Rows.Count; i++)
                {
                    if(dba.Rows[i][1].ToString() == txtUser.Text && dba.Rows[i][2].ToString() == txtPassword.Text)
                    {
                        lblError.Visible = false;
                        lblMessage.Visible = true;
                        btnDoctor.Enabled = true;
                        btnPatient.Enabled = true;
                        btnRecord.Enabled = true;
                        btnDoctor.Visible = true;
                        btnRecord.Visible = true;
                        btnPatient.Visible = true;
                        break;
                    }
                    else
                    {
                        lblError.Visible = true;
                    }
                }
            }
        }
    }
}