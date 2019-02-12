using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookieCalculator
{
    public partial class Result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*HttpCookie cookie = Request.Cookies["calculator"];
            Label1.Text = "Hello, your calculator name is " + cookie.Values["name"] + ". And the result of of your calculation is: " + cookie.Values["firstNum"] + " " + cookie.Values["method"] + " " + cookie.Values["secNum"] + " = " + cookie.Values["result"];*/
            Label1.Text = "Hello, your calculator name is " + Session["name"].ToString() + ". And the result of of your calculation is: " + Session["firstNum"] + " " + Session["method"] + " " + Session["secNum"] + " = " + Session["result"];

        }
    }
}