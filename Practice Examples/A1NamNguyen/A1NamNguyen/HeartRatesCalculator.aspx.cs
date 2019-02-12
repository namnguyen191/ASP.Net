using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace A1NamNguyen
{
    public partial class HeartRatesCalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int year = 1950; year <= DateTime.Now.Year; year++ )
            {
                lstYoB.Items.Add(year.ToString());
            }
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            HeartRates hr = new HeartRates(txtFName.Text, txtLName.Text, Convert.ToInt16(lstYoB.SelectedValue));
            if (radFemale.Checked) hr.Gender = "Female";
            else hr.Gender = "Male";
            lblResult.Text =
                "Your Information <br>" + 
                "First Name: " + hr.Fname +
                "<br>Last Name: " + hr.Lname +
                "<br>Year Of Birth: " + hr.Yob +
                "<br>Age: " + hr.Age() +
                "<br>Maximum Heart Rates: " + hr.MaxHeartRate() +
                "<br>Target Heart Rates: Min = " + hr.TargetMin() + " and Max = " + hr.TargetMax();
            lblResult.Visible = true;
        }
    }
}