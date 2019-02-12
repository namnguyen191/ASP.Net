using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if(FileUpload1.HasFile)
            {
                string path = "C:\\Users\\hoang\\Desktop\\Upload\\" + FileUpload1.FileName;
                FileUpload1.SaveAs(path);
                Label1.Text = "File uploaded to " + path + "\nFile Size is: " + FileUpload1.PostedFile.ContentLength;
            }
        }
    }
}