﻿using homework.DBSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace homework.SystemAdmin
{
    public partial class AccountingDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //驗證登入
            if (this.Session["UserLoginInfo"] == null)
            {
                Response.Redirect("/Login.aspx");
                return;
            }

            string account = this.Session["UserLoginInfo"] as string;
            var drUserInfo = UserInfoManager.GetUserInfoByAccount(account);

            if (drUserInfo == null)
            {
                Response.Redirect("/Login.aspx");
                return;
            }

            if (!this.IsPostBack)
            {
                //檢查是新增模式或編輯模式
                if (this.Request.QueryString["ID"] == null)
                {
                    this.btnDelete.Visible = false;
                }
                else
                {
                    this.btnDelete.Visible = true;

                    string idText = this.Request.QueryString["ID"];
                    int id;
                    if (int.TryParse(idText, out id))
                    {
                        var drAccounting = AccountingManager.GetAccounting(id, drUserInfo["ID"].ToString());

                        if (drAccounting == null)
                        {
                            this.ltMsg.Text = "資料不存在";
                            this.btnSave.Visible = false;
                            this.btnDelete.Visible = false;
                        }
                        else
                        {
                            this.ddlActType.SelectedValue = drAccounting["ActType"].ToString();
                            this.txtAmount.Text = drAccounting["Amount"].ToString();
                            this.txtCaption.Text = drAccounting["Caption"].ToString();
                            this.txtDesc.Text = drAccounting["Body"].ToString();
                        }
                    }
                    else
                    {
                        this.ltMsg.Text = "ID錯誤";
                        this.btnSave.Visible = false;
                        this.btnDelete.Visible = false;
                    }
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            List<string> msgList = new List<string>();
            if (!this.CheckInput(out msgList))
            {
                this.ltMsg.Text = string.Join("<br/>", msgList);
                return;
            }



            string account = this.Session["UserLoginInfo"] as string;
            var dr = UserInfoManager.GetUserInfoByAccount(account);

            if (dr == null)
            {
                Response.Redirect("/Login.aspx");
                return;
            }

            string userID = dr["ID"].ToString();
            string actTypeText = this.ddlActType.SelectedValue;
            string amountText = this.txtAmount.Text;
            string caption = this.txtCaption.Text;
            string body = this.txtDesc.Text;

            int amount = Convert.ToInt32(amountText);
            int actType = Convert.ToInt32(actTypeText);


            string idText = this.Request.QueryString["ID"];
            if (string.IsNullOrWhiteSpace(idText))
            {
                //Execute 'Insert into db'
                AccountingManager.CreateAccounting(userID, caption, amount, actType, body);
            }
            else
            {
                int id;
                if (int.TryParse(idText, out id))
                {
                    //Execute 'update db'
                    AccountingManager.UpdateAccounting(id, userID, caption, amount, actType, body);
                }
            }

                Response.Redirect("/SystemAdmin/AccountingList.aspx");
        }

        private bool CheckInput(out List<string> errorMsgList)
        {
            List<string> msgList = new List<string>();

            //Type
            if (this.ddlActType.SelectedValue != "0" && this.ddlActType.SelectedValue != "1")
            {
                msgList.Add("類型必須是0或1");
            }

            //Amount
            if (string.IsNullOrWhiteSpace(this.txtAmount.Text))
            {
                msgList.Add("金額為必填");
            }
            else
            {
                int tempInt;
                if (!int.TryParse(this.txtAmount.Text, out tempInt))
                {
                    msgList.Add("金額必須是個整數");
                }

                if(tempInt < 0 || tempInt > 1000000)
                {
                    msgList.Add("金額不能小於零或大於百萬");
                }

            }

            errorMsgList = msgList;

            if (msgList.Count == 0)
                return true;
            else
                return false;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string idText = this.Request.QueryString["ID"];

            if (string.IsNullOrWhiteSpace(idText))
                return;


                int id;
                if (int.TryParse(idText, out id))
                {
                    //Execute 'delete db'
                    AccountingManager.DeleteAccounting(id);
                }
                Response.Redirect("/SystemAdmin/AccountingList.aspx");
            }
        }
    }