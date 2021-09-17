using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Cart : System.Web.UI.Page
    {
        public string name = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["UserLoginInfo"] == null)
                {
                    return;
                }
                name = Session["UserLoginInfo"].ToString();
               
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}