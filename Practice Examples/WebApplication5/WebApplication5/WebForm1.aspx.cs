using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            /*if(name != "")
            {
                Response.Cookies["name"].Value = name;
                Response.Cookies["name"].Expires = DateTime.Now.AddDays(1);
            }
            else
            {
                Response.Cookies["name"].Value = null;
            } */
            HttpCookie cookie;
            if(name != "")
            {
                cookie = new HttpCookie("name");
                cookie.Value = name;
                cookie.Expires = DateTime.Now.AddDays(1);
            } 
            Response.Cookies.Add(cookie);
            Response.Redirect("~/WebForm2.aspx");
        }
    }
}