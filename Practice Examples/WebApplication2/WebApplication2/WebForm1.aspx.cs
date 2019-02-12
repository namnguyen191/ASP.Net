using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            double price = Convert.ToDouble(txtPrice.Text);
            double discoutPercen = Convert.ToDouble(txtDisPerc.Text);
            double discountAmount = (discoutPercen / 100) * price;
            double newPrice = price - discountAmount;
            lblDisAmo.Text = discountAmount.ToString();
            lblTotalPrice.Text = newPrice.ToString();

        }
    }
}