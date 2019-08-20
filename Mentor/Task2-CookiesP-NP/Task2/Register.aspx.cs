using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task2
{
    public partial class Register : System.Web.UI.Page
    {        
        protected void Page_Load(object sender, EventArgs e)
        {
            lblRegister.Text = "Register here!!";            
            if(!IsPostBack)
            {
                tbName.Text = "";
                tbUserName.Text = "";
                tbPassword.Text = "";                
            }           
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {            
            HttpCookie cookie = Request.Cookies["RegisteredUsers"];
            if (cookie == null)
            {
                cookie = new HttpCookie("RegisteredUsers");
            }            
            cookie["name"] = tbName.Text;
            cookie["gender"] = RadioButtonList1.SelectedValue;
            cookie["location"] = DropDownList1.SelectedValue;
            cookie["username"] = tbUserName.Text;
            cookie["password"] = tbPassword.Text;
            //Uncoment the following line for making use of persistent cookies
            //cookie.Expires = DateTime.Now.AddDays(20);
            Response.Cookies.Add(cookie);
            Response.Redirect("Login.aspx");
        }                        
    }
}