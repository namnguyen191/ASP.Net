using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab2
{
    public partial class Recommendations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["lang"];
            if (cookie.Value == "Visual Basic 2008")
                ListBox1.Items[0].Enabled = true;
            else if (cookie.Value == "Visual C# 2008")
                ListBox1.Items[1].Enabled = true;
            else if (cookie.Value == "C")
                ListBox1.Items[2].Enabled = true;
            else if (cookie.Value == "C++")
                ListBox1.Items[3].Enabled = true;
            else ListBox1.Items[4].Enabled = true;
        }
    }
}