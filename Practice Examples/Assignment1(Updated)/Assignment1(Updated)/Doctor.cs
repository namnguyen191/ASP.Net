using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace Assignment1_Updated_
{

    //To represent the doctor as well as too perform all SQL statement on Doctor Database
    public class Doctor
    {
        private string cs, query;
        //Set the attributes for the doctor according to the database
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public string Postal { get; set; }
        public Doctor()
        {

        }
        //Constructor
        public Doctor(int id, string fname, string lname, string address, string postal)
        {
            this.Id = id;
            this.FName = fname;
            this.LName = lname;
            this.Address = address;
            this.Postal = postal;
        }
        //Retrieve a doctor information base on the Id
        public Doctor GetDoctor(int id)
        {
            cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            query = "SELECT * FROM [Doctor] WHERE [Id] = @id";
            using (SqlConnection con = new SqlConnection(cs))
            {
                Doctor doc;
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    int docId = Convert.ToInt32(rdr[0].ToString());
                    string docFName = rdr[1].ToString();
                    string docLName = rdr[2].ToString();
                    string docAddress = rdr[3].ToString();
                    string docPostal = rdr[4].ToString();
                    doc = new Doctor(docId, docFName, docLName, docAddress, docPostal);
                }
                else
                {
                    doc = null;
                }
                return doc;
            }
        }
        //Add a doctor to the database, return a status string to indicate whether the INSERT statement is successful or not
        public string AddDoctor(string fname, string lname, string address, string postal)
        {
            string status="";
            cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [Doctor] ([First Name], [Last Name], [Address], [Postal Code]) VALUES (@fname, @lname, @address, @postal)");
                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@lname", lname);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@postal", postal);
                cmd.Connection = con;
                con.Open();
                int rowInst = cmd.ExecuteNonQuery();
                if(rowInst > 0)
                {
                    status = "New Doctor Added!";
                }
                else
                {
                    status = "Insert Failed!";
                }
            }
            return status;
        }
        //Update a doctor in the database, return a status string to indicate whether the UPDATE statement is successful or not
        public string UpdateDoctor(int id, string fname, string lname, string address, string postal)
        {
            string status = "";
            cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using(SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("UPDATE [Doctor] SET [First Name] = @fname, [Last Name] = @lname, [Address] = @address, [Postal Code] = @postal WHERE [Id] = @id");
                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@lname", lname);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@postal", postal);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Connection = con;
                con.Open();
                int rowsUp = cmd.ExecuteNonQuery();
                if(rowsUp > 0)
                {
                    status = "Update Successfully!";
                }
                else
                {
                    status = "Update Failed!";
                }
            }
            return status;
        }
        //Delete a doctor from the database base on the doctor Id, return a status string to indicate whether the DELETE statement is successful or not
        public string DeleteDoctor(int id)
        {
            string status = "";
            cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using(SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM [Doctor] WHERE [Id] = @id");
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Connection = con;
                con.Open();
                int rowsDel = cmd.ExecuteNonQuery();
                if(rowsDel > 0)
                {
                    status = "Delete Successfully!";
                }
                else
                {
                    status = "Delete Failed!";
                }
            }
            return status;
        }
    }
}