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
        Doctor doc;
        Patient pat;
        protected void Page_Load(object sender, EventArgs e)
        {
            doc = new Doctor();
            pat = new Patient();
        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            doc = doc.GetDoctor(Convert.ToInt32(txtId.Text));
            if(doc != null)
            {
                txtFName.Text = doc.FName;
                txtLName.Text = doc.LName;
                txtAddress.Text = doc.Address;
                txtPostal.Text = doc.Postal;
                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Text = "Data Load Successfull!";
            }
            else
            {
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
            pat = pat.GetPatient(Convert.ToInt32(txtIdPatient.Text));
            if (pat != null)
            {
                txtFNamePatient.Text = pat.FName;
                txtLNamePatient.Text = pat.LName;
                txtAddressPatient.Text = pat.Address;
                txtPostalPatient.Text = pat.Postal;
                txtAssignedDoctor.Text = pat.Doctor;
                lblMessagePatient.ForeColor = System.Drawing.Color.Green;
                lblMessagePatient.Text = "Data Load Successfull!";
            }
            else
            {
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
            lblMessage.Text = doc.AddDoctor(txtFName.Text, txtLName.Text, txtAddress.Text, txtPostal.Text);
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            lblMessage.Text = doc.UpdateDoctor(Convert.ToInt16(txtId.Text), txtFName.Text, txtLName.Text, txtAddress.Text, txtPostal.Text);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            lblMessage.Text = doc.DeleteDoctor(Convert.ToInt16(txtId.Text));
        }

        protected void btnInsertPatient_Click(object sender, EventArgs e)
        {
            lblMessagePatient.Text = pat.AddPatient(txtFNamePatient.Text, txtLNamePatient.Text, txtAddressPatient.Text, txtPostalPatient.Text,Convert.ToInt16(txtAssignedDoctor.Text));
        }

        protected void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            lblMessagePatient.Text = pat.UpdatePatient(Convert.ToInt16(txtIdPatient.Text), txtFNamePatient.Text, txtLNamePatient.Text, txtAddressPatient.Text, txtPostalPatient.Text, Convert.ToInt16(txtAssignedDoctor.Text));
        }

        protected void btnDeletePatient_Click(object sender, EventArgs e)
        {
            lblMessagePatient.Text = pat.DeletePatient(Convert.ToInt16(txtIdPatient.Text));
        }
    }
}