using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(this.Session["UserLoginInfo"] != null)
            {
                Response.Redirect("HomePage.aspx");
            }
            else 
            {
                this.plcLogin.Visible = true;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string db_account = "miko";
            string db_password = "12345";

            string inp_Account = this.txtAccount.Text;
            string inp_PWD = this.txtPWD.Text;

            if (string.IsNullOrWhiteSpace(inp_Account) || string.IsNullOrWhiteSpace(inp_PWD))
            {
                this.ltlMsg.Text = "帳號密碼錯誤";
                return;
            }

            if (string.Compare(db_account, inp_Account, true) == 0 && string.Compare(db_password, inp_PWD, false) == 0)
            {
                this.Session["UserLoginInfo"] = db_account;
                Response.Redirect("HomePage.aspx");
            }
            else
            {
                this.ltlMsg.Text = "登入失敗";
                return;
            }
        }      
    }
}