using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace Assignment1_Updated_
{
    //Represent a patient object as well as too peform all SQL statement on the Patient Database
    public class Patient
    {
        private static string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        //Set the patient attribute base on the Patient database
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public string Postal { get; set; }
        public int Doctor { get; set; }
        public string Status { get; set; }
        //Constructor
        public Patient()
        {

        }

        public Patient(int id, string fname, string lname, string address, string postal, int doctor, string status)
        {
            this.Id = id;
            this.FName = fname;
            this.LName = lname;
            this.Address = address;
            this.Postal = postal;
            this.Doctor = doctor;
            this.Status = status;
        }
        //Retrieve a patient from the database base on the id, return a status string whether the SQL statement is successfull or not
        public Patient GetPatient(int id)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                Patient pat;
                SqlCommand cmd = new SqlCommand("SELECT * FROM [Patient] WHERE [Id] = @id");
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
                    pat = new Patient(patId, patFName, patLName, patAddress, patPostal, Convert.ToInt16(patDoctor), patStatus);
                }
                else
                {
                    pat = null;
                }
                return pat;
            }
        }
        //Add a new patient to the database, return a status string whether the SQL statement is successfull or not
        public string AddPatient(string fname, string lname, string address, string postal, int doctor)
        {
            string status = "In Treatment";
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [Patient] ([First Name], [Last Name], [Address], [Postal Code], [Assigned Doctor's Id], [Status] ) VALUES (@fname, @lname, @address, @postal, @doctor, @status)");
                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@lname", lname);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@postal", postal);
                cmd.Parameters.AddWithValue("@doctor", doctor);
                cmd.Parameters.AddWithValue("@status", status);
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
        //Update a patient in the database, return a status string whether the SQL statement is successfull or not
        public string UpdatePatient(int id, string fname, string lname, string address, string postal, int doctor)
        {
            string status;
            using (SqlConnection con = new SqlConnection(CS))
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
        //Delete a patient from the database, return a status string whether the SQL statement is successfull or not
        public string DeletePatient(int id)
        {
            string status;
            using (SqlConnection con = new SqlConnection(CS))
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

        //Discharge a patient, changing the [Status] from patient dabase to "Discharged", return a status string to indicate whether the UPDATE is successful or not
        public string DischargePatient(int pId)
        { 
            string status;
            using(SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("UPDATE [Patient] SET [Status] = 'Discharged' WHERE [Id] = @id");
                cmd.Parameters.AddWithValue("@id", pId);
                cmd.Connection = con;
                con.Open();
                int rowsUp = cmd.ExecuteNonQuery();
                if(rowsUp > 0)
                {
                    status = "Patient Discharged Successfully";
                } else
                {
                    status = "Fail to discharge patient";
                }
            }
            return status;
        }

    }
}