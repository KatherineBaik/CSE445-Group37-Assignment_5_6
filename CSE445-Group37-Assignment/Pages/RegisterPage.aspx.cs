using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CSE445_KBUtilities;

namespace CSE445_Group37_Assignment.Pages
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        private const string secretKey = "YAHAHA";
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        // Work by: Josh Azura

        // This runs when register button is clicked
        protected void ButtonUserRegister_Click(object sender, EventArgs e)
        {
            // This stops if any kind of validator failed.
            if (!Page.IsValid)
            {
                return;
            }

            // This reads that the users type on the field.
            string username = TextBoxUsername.Text.Trim();
            string password = TextBoxPassword.Text;
            
            // This encrypts locally with the DLL
            string encrypted = KBUtilities.EncryptString(password, secretKey);

            // This asks the JASerivce to create the account and returns a yes or no.
            JAServiceReference.JAServiceClient proxy = new JAServiceReference.JAServiceClient();
            bool registered = proxy.RegisterUser(username, encrypted);


            // This shows the warning message and terminates if any username is taken to keep users' username unique.
            if (!registered)
            {
                LabelUserExists.Visible = true;
                return;
            }

            // This saves the username in a cookie for 7 days
            HttpCookie cookie = new HttpCookie("RecipeBoxUser");
            cookie["Username"] = username;
            cookie.Expires = DateTime.Now.AddDays(7);
            Response.Cookies.Add(cookie);
            // This redirects to the login page.
            Response.Redirect("LoginPage.aspx");
        }
    }
}