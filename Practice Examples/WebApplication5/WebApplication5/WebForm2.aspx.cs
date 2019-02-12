using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            if (Request.Cookies["name"].Value != "")
                Label1.Text = "Hello " + Request.Cookies["name"].Value;
            else
                Label1.Text = "No name was entered"; */
            HttpCookie cookie = Request.Cookies["name"];
            if(cookie is null)
            {
                Label1.Text = "No name was entered!"; 
            }
            else
            {
                Label1.Text = "Hello " + cookie.Value;
            }
        }
    }
}