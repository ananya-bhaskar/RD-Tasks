using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblUserMessage.Text = "";
            //Response.Write("Apps = " + Application["TotalApps"]+"<br/>");
            //Response.Write("Sessions = " + Application["TotalSessions"]);
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["RegisteredUsers"];
            if(cookie != null)
            {
                if(cookie["username"] == tbId.Text && cookie["password"] == tbPwd.Text)
                {
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    lblUserMessage.Text = "Invalid UserName/Password. Please check if registered.";
                }
            }
            else
            {
                lblUserMessage.Text = "Invalid UserName/Password. Please check if registered.";
            }
            
        }
    }
}