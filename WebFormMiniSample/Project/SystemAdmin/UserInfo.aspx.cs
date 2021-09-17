using Project.DBSource;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.SystemAdmin
{
    public partial class UserInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                if (this.Session["UserLoginInfo"] == null)
                {
                    Response.Redirect("/ManagerLogin.aspx");
                    return;
                }
            }

            if (this.Session["UserLoginInfo"] == null)
            {
                Response.Redirect("/ManagerLogin.aspx");
                return;
            }

            string account = this.Session["UserLoginInfo"] as string;

            DataRow dr = UserInfoManager.GetUserInfoByAccount(account);

            if (dr == null)
            {
                this.Session["UserLoginInfo"] = null;
                Response.Redirect("/ManagerLogin.aspx");
                return;
            }

            this.ltlAccount.Text = dr["Account"].ToString();



        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            this.Session["UserLoginInfo"] = null;
            Response.Redirect("/ManagerLogin.aspx");
        }
    }
}