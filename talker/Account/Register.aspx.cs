using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using talker.Models;

namespace talker.Account
{
    public partial class Register : Page
    {
        protected void CreateUser_Click(object sender, EventArgs e)
        {
            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var signInManager = Context.GetOwinContext().Get<ApplicationSignInManager>();
            var user = new ApplicationUser() { UserName = Email.Text, Email = Email.Text };
            IdentityResult result = manager.Create(user, Password.Text);
            if (result.Succeeded)
            {
                // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771
                //string code = manager.GenerateEmailConfirmationToken(user.Id);
                //string callbackUrl = IdentityHelper.GetUserConfirmationRedirectUrl(code, user.Id, Request);
                //manager.SendEmail(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>.");
                AddToUser(Email.Text);
                signInManager.SignIn( user, isPersistent: false, rememberBrowser: false);
                IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
            }
            else 
            {
                ErrorMessage.Text = result.Errors.FirstOrDefault();
            }
        }
        //R-code 
        public void AddToUser(string id)
        {   // Retrieve the product from the database.
            DataContext _db = new DataContext();
            
            var user = _db.Users.SingleOrDefault(c => c.Id == id);
            if (user == null)
            { // Create a new user if no user exists.
                user = new User {
                    Id = id,
                    FName = Name.Text,
                    LName = "null",
                    DateCreated = DateTime.Now 
                };

                _db.Users.Add(user);
            }
            else
            { // If the item does exist in the cart, // then add one to the quantity.
                //user.Quantity++;
            } _db.SaveChanges();
        }
    }
}