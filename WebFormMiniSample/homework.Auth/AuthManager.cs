using homework.DBSource;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace homework.Auth
{
    /// <summary> 負責處理登入的元件 </summary>
    public class AuthManager
    {
        /// <summary> 檢查是否有登入 </summary>
        /// <returns></returns>
        public static bool IsLogined()
        {           
            if (HttpContext.Current.Session["UserLoginInfo"] == null)
                return false;
            else           
                return true;           
        }

        /// <summary> 取得以登入的使用者資訊 (沒有登入就回傳 null) </summary>
        /// <returns></returns>
        public static UserInfoModel GetCurrentUser()
        {
            string account = HttpContext.Current.Session["UserLoginInfo"] as string;

            if (account == null)
                return null;

            DataRow dr = UserInfoManager.GetUserInfoByAccount(account);

            if (dr == null)
            {
                HttpContext.Current.Session["UserLoginInfo"] = null;
                return null;
            }


            UserInfoModel model = new UserInfoModel();
            model.ID = dr["ID"].ToString();
            model.Account = dr["Account"].ToString();
            model.Name = dr["Name"].ToString();
            model.Email = dr["Email"].ToString();

            return model;
        }


        /// <summary> 登出 </summary>
        public static void Logout()
        {
            HttpContext.Current.Session["UserLoginInfo"] = null; //清除登入資訊，導致登入頁
        }


        /// <summary> 嘗試登入 </summary>
        /// <param name="account"></param>
        /// <param name="pwd"></param>
        /// <param name="errorMsg"></param>
        public static bool TryLogin(string account, string pwd, out string errorMsg)
        {
            //確認是否是空的
            if (string.IsNullOrWhiteSpace(account) || string.IsNullOrWhiteSpace(pwd))
            {
                errorMsg = "帳號密碼為必填";
                return false;
            }


            //讀取db 並檢查
            var dr = UserInfoManager.GetUserInfoByAccount(account);

            //確認是是空的    
            if (dr == null)
            {
                errorMsg = $"帳號: {account}不存在";
                return false;
            }

            //確認帳號密碼
            if (string.Compare(dr["Account"].ToString(), account, true) == 0 && string.Compare(dr["PWD"].ToString(), pwd, false) == 0)
            {
                HttpContext.Current.Session["UserLoginInfo"] = dr["Account"].ToString();
                errorMsg = string.Empty;
                return true;
            }
            else
            {
                errorMsg = "登入失敗請檢察帳號密碼";
                return false;
            }
        }
    }
}
