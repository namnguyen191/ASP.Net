using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string text;
            text = ((TextBox)PreviousPage.FindControl("txtInfo")).Text;
            if (text == "")
                Label1.Text = "No Informantion From Previous Page";
            else
                Label1.Text = "The text from the previous page is: " + text;
        }
    }
}