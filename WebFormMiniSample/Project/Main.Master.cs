using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                try
                {
                    if (Session["UserLoginInfo"] == null)
                    {
                        return;
                    }
                    btnLogout.Visible = true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["UserLoginInfo"] = null;
            btnLogout.Visible = false;
            Response.Redirect("/HomePage.aspx");
        }
    }
}