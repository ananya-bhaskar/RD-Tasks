using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task2
{
    public partial class RegSucc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["RegisteredUsers"];
            if (cookie != null)
            {
                lblName.Text = cookie["name"];
                lblGender.Text = cookie["gender"];
                lblLocation.Text = cookie["location"];
                lblUser.Text = cookie["username"];
            }            
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["RegisteredUsers"];
            if(cookie != null)
            {
                Response.Cookies["RegisteredUsers"].Expires = DateTime.Now.AddDays(-1);
            }
            Response.Redirect("Login.aspx");
        }
    }
}