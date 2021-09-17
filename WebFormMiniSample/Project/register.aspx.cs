using Project.DBSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Project
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void btnSign_Click(object sender, EventArgs e)
        {
            List<string> msgList = new List<string>();
            if (!this.CheckInput(out msgList))
            {
                this.ltlmsg.Text = string.Join("<br/>", msgList);
                return;
            }
;
            string Account = this.txtAccount.Text;
            string PWD = this.txtPWD.Text;

            var dr = UserInfoManager.GetUserInfoByAccount(Account);


            if (dr != null)
            {
                msgList.Add("此帳號已使用過");
            }
            else
            {
                UserInfoManager.CreateAccount(Account, PWD);
                Response.Redirect("Login.aspx");
            }

            UserInfoManager.CreateAccount(Account, PWD);

        }

        private bool CheckInput(out List<string> errorMsgList)
        {
            List<string> msgList = new List<string>();

            if(string.IsNullOrWhiteSpace(this.txtAccount.Text))
            {
                msgList.Add("請輸入帳號");
            }

            if (string.IsNullOrWhiteSpace(this.txtPWD.Text))
            {
                msgList.Add("請輸入密碼");
            }

            errorMsgList = msgList;

            if (msgList.Count == 0)
                return true;
            else 
                return false;
        }
    }
}