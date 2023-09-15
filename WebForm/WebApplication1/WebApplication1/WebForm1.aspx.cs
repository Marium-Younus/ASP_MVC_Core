using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            title.InnerText = "Hello World";
            title.Style.Add("color", "purple");
            title.Style.Add("font-family", "comic sans ms");
           
        }
    }
}