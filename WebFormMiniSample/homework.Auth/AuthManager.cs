﻿using homework.DBSource;
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


        /// <summary> 清除登入 </summary>
        public static void Logout()
        {
            HttpContext.Current.Session["UserLoginInfo"] = null; //清除登入資訊，導致登入頁
        }

    }
}
