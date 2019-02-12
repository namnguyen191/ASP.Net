using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookieCalculator
{
    public partial class CalculatorSettup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtCalculatorName.Text;
            int result = 0;
            int firstNum = Convert.ToInt16(txtFirstNumber.Text);
            int secNum = Convert.ToInt16(txtSecondNumber.Text);
            int choice = lstMathMethods.SelectedIndex;
            string method = lstMathMethods.SelectedItem.Text;
            /*HttpCookie cookie = new HttpCookie("Calculator");
            cookie.Values["name"] = name;
            cookie.Values["firstNum"] = firstNum.ToString();
            cookie.Values["secNum"] = secNum.ToString();
            cookie.Values["method"] = method;
            cookie.Values["result"] = result.ToString();
            Response.Cookies.Add(cookie);
            Response.Redirect("~/Result.aspx"); */
            Session["name"] = name;
            Session["firstNum"] = firstNum.ToString();
            Session["secNum"] = secNum.ToString();
            Session["method"] = method;
            if (choice == 0) result = firstNum + secNum;
            if (choice == 1) result = firstNum - secNum;
            if (choice == 2) result = firstNum * secNum;
            if (choice == 3) result = firstNum / secNum;
            Session["result"] = result.ToString();
            Response.Redirect("~/Result.aspx");
        }
    }
}