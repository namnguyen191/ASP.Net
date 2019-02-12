using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab2
{
    public partial class Options : System.Web.UI.Page
    {
        String lang;
        protected void Page_Load(object sender, EventArgs e)
        {
            lang = "Visual Basic 2008";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("lang");
            cookie.Value = lang;
            Response.Cookies.Add(cookie);
            Response.Redirect("~/WebForm1.aspx");
        }

        protected void rad_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radlang = (RadioButton)sender;
            lang = radlang.Text;
        }
    }
}