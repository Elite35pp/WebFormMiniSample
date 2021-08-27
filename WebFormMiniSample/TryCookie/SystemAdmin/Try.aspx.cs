using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TryCookie.SystemAdmin
{
    public partial class Try : System.Web.UI.Page
    {
        private string _LoginName = "LoginKey";
        protected void Page_Load(object sender, EventArgs e)
        {
            bool isAuth = HttpContext.Current.Request.IsAuthenticated;
            var user = HttpContext.Current.User;

            if(isAuth && user != null)
            {
                var identity = HttpContext.Current.User.Identity as FormsIdentity;

                if(identity == null)
                {
                    this.ltlMsg.Text = "未登入";
                    return;
                }

                var userdata = identity.Ticket;
                this.ltlMsg.Text = $"User: {user.Identity.Name}, ID: {identity.Ticket.UserData}";
            }
            else
            {
                this.ltlMsg.Text = "未登入";
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            var cookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            cookie.Expires = DateTime.Now.AddHours(-5);
            Response.Cookies.Add(cookie);

            Response.Redirect(Request.RawUrl);
        }
    }
}