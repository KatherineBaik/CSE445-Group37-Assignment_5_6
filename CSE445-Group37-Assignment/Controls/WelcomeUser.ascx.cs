using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSE445_Group37_Assignment.Controls
{
    public partial class WelcomeUser : System.Web.UI.UserControl
    {
        // Work by: Josh Azura
        // This control greets the user using the RecipeBoxUser cookie.

        protected void Page_Load(object sender, EventArgs e)
        {
            // This looks for the cookie the register page has saved
            HttpCookie cookie = Request.Cookies["RecipeBoxUser"];

            if (cookie != null && !string.IsNullOrEmpty(cookie["Username"]))
            {
                // This greets the user by name when cookie is found
                string name = cookie["Username"];
                LabelWelcome.Text = "Welcome back, " + Server.HtmlEncode(name) + "!";
            }
            else
            {
                // This does the generic greeting when no cookie is found
                LabelWelcome.Text = "Welcome stranger!";
            }
        }
    }
}