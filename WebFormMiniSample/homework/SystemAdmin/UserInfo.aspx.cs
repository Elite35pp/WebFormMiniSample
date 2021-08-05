using homework.DBSource;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace homework.SystemAdmin
{
    public partial class UserInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack) // 可能是按鈕跳回本頁，所以要判斷postback
            {
                if(this.Session["UserLoginInfo"] == null) //如果尚未登入，導致登入業
                {
                    Response.Redirect("/Login.aspx");
                    return;
                }

            string account = this.Session["UserLoginInfo"] as string;
            DataRow dr = UserInfoManager.GetUserInfoByAccount(account);

            if (dr == null) //如果帳號不存在，導致登入頁
            {
                this.Session["UserLoginInfo"] = null;
                Response.Redirect("/Login.aspx");
                return;
            }

            this.ltAccount.Text = dr["Account"].ToString();
            this.ltName.Text = dr["Name"].ToString();
            this.ltEmail.Text = dr["Email"].ToString();
            }
        }

        protected void btLogout_Click(object sender, EventArgs e)
        {
            this.Session["UserLoginInfo"] = null; //清除登入資訊，導致登入頁
            Response.Redirect("/Login.aspx");
        }
    }
}