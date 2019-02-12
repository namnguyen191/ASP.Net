using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace Assignment1_Updated_
{
    public class Patient
    {
        private string cs, query;
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public string Postal { get; set; }
        public string Doctor { get; set; }
        public string Status { get; set; }
        public Patient()
        {

        }

        public Patient(int id, string fname, string lname, string address, string postal, string doctor, string status)
        {
            this.Id = id;
            this.FName = fname;
            this.LName = lname;
            this.Address = address;
            this.Postal = postal;
            this.Doctor = doctor;
            this.Status = status;
        }
        public Patient GetPatient(int id)
        {
            cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            query = "SELECT * FROM [Patient] WHERE [Id] = @id";
            using (SqlConnection con = new SqlConnection(cs))
            {
                Patient pat;
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    int patId = Convert.ToInt32(rdr[0].ToString());
                    string patFName = rdr[1].ToString();
                    string patLName = rdr[2].ToString();
                    string patAddress = rdr[3].ToString();
                    string patPostal = rdr[4].ToString();
                    string patDoctor = rdr[5].ToString();
                    string patStatus = rdr[6].ToString();                    
                    pat = new Patient(patId, patFName, patLName, patAddress, patPostal, patDoctor, patStatus);
                }
                else
                {
                    pat = null;
                }
                return pat;
            }
        }

        public string AddPatient(string fname, string lname, string address, string postal, int doctor)
        {
            string status = "";
            cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [Patient] ([First Name], [Last Name], [Address], [Postal Code], [Assigned Doctor's Id]) VALUES (@fname, @lname, @address, @postal, @doctor)");
                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@lname", lname);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@postal", postal);
                cmd.Parameters.AddWithValue("@doctor", doctor);
                cmd.Connection = con;
                con.Open();
                int rowInst = cmd.ExecuteNonQuery();
                if (rowInst > 0)
                {
                    status = "New Patient Added!";
                }
                else
                {
                    status = "Insert Failed!";
                }
            }
            return status;
        }

        public string UpdatePatient(int id, string fname, string lname, string address, string postal, int doctor)
        {
            string status = "";
            cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("UPDATE [Patient] SET [First Name] = @fname, [Last Name] = @lname, [Address] = @address, [Postal Code] = @postal, [Assigned Doctor's Id] = @doctor WHERE [Id] = @id");
                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@lname", lname);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@postal", postal);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@doctor", doctor);
                cmd.Connection = con;
                con.Open();
                int rowsUp = cmd.ExecuteNonQuery();
                if (rowsUp > 0)
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
        public string UpdatePatient(int id, string fname, string lname, string address, string postal)
        {
            string status = "";
            cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("UPDATE [Patient] SET [First Name] = @fname, [Last Name] = @lname, [Address] = @address, [Postal Code] = @postal, [Assigned Doctor's Id] = @doctor WHERE [Id] = @id");
                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@lname", lname);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@postal", postal);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Connection = con;
                con.Open();
                int rowsUp = cmd.ExecuteNonQuery();
                if (rowsUp > 0)
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

        public string DeletePatient(int id)
        {
            string status = "";
            cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM [Patient] WHERE [Id] = @id");
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Connection = con;
                con.Open();
                int rowsDel = cmd.ExecuteNonQuery();
                if (rowsDel > 0)
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