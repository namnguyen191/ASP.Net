using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment1_Updated_
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        Doctor doc; //Create a doctor object
        Patient pat; //Create a patient object
        protected void Page_Load(object sender, EventArgs e)
        {
            //Initialize the 2 objects
            doc = new Doctor();
            pat = new Patient();
        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            //Perform the GetDoctor method from the doctor class to retrieve all information of the doctor and display them
            doc = doc.GetDoctor(Convert.ToInt32(txtId.Text));
            //If statement to check if a doctor record is successfully retrieve
            if(doc != null)
            {
                txtFName.Text = doc.FName;
                txtLName.Text = doc.LName;
                txtAddress.Text = doc.Address;
                txtPostal.Text = doc.Postal;
                //Success message
                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Text = "Data Load Successfull!";
            }
            else
            {
                //Error message
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Id not found!";
                txtFName.Text = "";
                txtLName.Text = "";
                txtAddress.Text = "";
                txtPostal.Text = "";
                txtId.Focus();
                txtId.Attributes.Add("onfocus", "this.select();");
            }           
        }

        protected void btnLoadPatient_Click(object sender, EventArgs e)
        {
            //Perform GetPatient method from the patient class to retrieve all information of the patient and display them
            pat = pat.GetPatient(Convert.ToInt32(txtIdPatient.Text));
            if (pat != null)
            {
                txtFNamePatient.Text = pat.FName;
                txtLNamePatient.Text = pat.LName;
                txtAddressPatient.Text = pat.Address;
                txtPostalPatient.Text = pat.Postal;
                txtAssignedDoctor.Text = pat.Doctor.ToString();
                //Success message
                lblMessagePatient.ForeColor = System.Drawing.Color.Green;
                lblMessagePatient.Text = "Data Load Successfull!";
            }
            else
            {
                //Error message
                lblMessagePatient.ForeColor = System.Drawing.Color.Red;
                lblMessagePatient.Text = "Id not found!";
                txtFNamePatient.Text = "";
                txtLNamePatient.Text = "";
                txtAddressPatient.Text = "";
                txtPostalPatient.Text = "";
                txtAssignedDoctor.Text = "";
                txtIdPatient.Focus();
                txtIdPatient.Attributes.Add("onfocus", "this.select();");
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            //Call the AddDoctor method from Doctor class to perform insert a new doctor to the database
            lblMessage.Text = doc.AddDoctor(txtFName.Text, txtLName.Text, txtAddress.Text, txtPostal.Text);
        }
            //Call the UpdateDoctor method from Doctor class to perform update a doctor record in the database
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            lblMessage.Text = doc.UpdateDoctor(Convert.ToInt16(txtId.Text), txtFName.Text, txtLName.Text, txtAddress.Text, txtPostal.Text);
        }
            //Call the DeleteDoctor method from Doctor class to perform delete a doctor in the database
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            lblMessage.Text = doc.DeleteDoctor(Convert.ToInt16(txtId.Text));
        }
        //Call the AddPatient method from patient class to perfrom insert a patient to the database
        protected void btnInsertPatient_Click(object sender, EventArgs e)
        {
            lblMessagePatient.Text = pat.AddPatient(txtFNamePatient.Text, txtLNamePatient.Text, txtAddressPatient.Text, txtPostalPatient.Text,Convert.ToInt16(txtAssignedDoctor.Text));
        }
        //Call the UpdatePatient method from patient class to perfrom update a patient record the database
        protected void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            lblMessagePatient.Text = pat.UpdatePatient(Convert.ToInt16(txtIdPatient.Text), txtFNamePatient.Text, txtLNamePatient.Text, txtAddressPatient.Text, txtPostalPatient.Text, Convert.ToInt16(txtAssignedDoctor.Text));
        }
        //Call the DeletePatient method from patient class to perfrom delete a patient from the database
        protected void btnDeletePatient_Click(object sender, EventArgs e)
        {
            lblMessagePatient.Text = pat.DeletePatient(Convert.ToInt16(txtIdPatient.Text));
        }
    }
}