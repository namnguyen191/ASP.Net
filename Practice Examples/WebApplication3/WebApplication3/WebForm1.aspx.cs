using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            for(int i=0; i<100;i++)
            {
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Label1.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if(radOtherLan.Checked)
            {
                Panel1.Visible = true;
            }
            else
            {
                Panel1.Visible = false;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Webform2.aspx");
        }
    }
}