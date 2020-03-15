using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{
    public partial class homeOutput : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Title = "TEST";
            Response.Write("<script language='javascript'>alert('欢迎使用三角形面积求解工具')</script>");
        }
    }
}