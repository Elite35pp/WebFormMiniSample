using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TryCookie
{
    public partial class BESTTeplate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(this.IsPostBack)
            {
                string val1 = Request.Form["txtemail"];
                string val2 = Request.Form["txtdesc"];
                this.ltmsg.Text =
                    $@"Email: {val1} <br/>
                    Content: {val2}";

            }
        }

        protected void btn1_Click(object sender, EventArgs e)
        {

        }

        protected void btn2_Click(object sender, EventArgs e)
        {

        }

        protected void btn3_Click(object sender, EventArgs e)
        {

        }
    }
}