using Project.DBSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.SystemAdmin
{
    public partial class ProductDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["UserLoginInfo"] == null)
            {
                Response.Redirect("/Login.aspx");
                return;
            }

            string account = this.Session["UserLoginInfo"] as string;
            var dr = UserInfoManager.GetUserInfoByAccount(account);

            if (dr == null)
            {
                Response.Redirect("/Login.aspx");
                return;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            List<string> msgList = new List<string>();
            if(!this.CheckInput(out msgList))
            {
                this.ltlMsg.Text = string.Join("<br/>", msgList);
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
            string Name = this.txtName.Text;
            string Description = this.txtDescription.Text;
            string CategoryID = this.txtCategoryID.Text;
            string PriceText = this.txtPrice.Text;
            string Status = this.cblStatus.Text;
            string ImageID = this.txtImageID.Text;
            string Quantity = this.txtQuantity.Text;

            int Price = Convert.ToInt32(PriceText);

            AccountingManager.CreatProduct(userID, Name, Description, CategoryID, Price, Status, ImageID, Quantity);
        }

        private bool CheckInput(out List<string> errorMsgList)
        {
            List<string> msgList = new List<string>();

            if (string.IsNullOrWhiteSpace(this.txtName.Text))
            {
                msgList.Add("請輸入商品名");
            }

            if (string.IsNullOrWhiteSpace(this.txtCategoryID.Text))
            {
                msgList.Add("請輸入商品分類編號");
            }

            if (string.IsNullOrWhiteSpace(this.txtPrice.Text))
            {
                msgList.Add("請輸入商品價格");
            }

            if (string.IsNullOrWhiteSpace(this.txtImageID.Text))
            {
                msgList.Add("請輸入圖片編號");
            }

            if (string.IsNullOrWhiteSpace(this.txtQuantity.Text))
            {
                msgList.Add("請輸入商品庫存");
            }

            errorMsgList = msgList;

            if (msgList.Count == 0)
                return true;
            else
                return false;
        }
    }
}