using System;
using System.Collections.Generic;
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
    }
}
