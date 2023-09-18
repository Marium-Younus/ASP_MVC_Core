using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm4 : System.Web.UI.Page
    {

        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("<br/>" + "Init");
        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write("<br/>" + "InitComplete");
        }
        protected override void OnPreLoad(EventArgs e)
        {
            Response.Write("<br/>" + "PreLoad");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<br/>" + "Load");
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Response.Write("<br/>" + "LoadComplete");
        }
        protected override void OnPreRender(EventArgs e)
        {
            Response.Write("<br/>" + "PreRender");
        }
        protected override void OnSaveStateComplete(EventArgs e)
        {
            Response.Write("<br/>" + "SaveStateComplete");
        }
        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //Runtime Error : Response is not available in this context.  
            //Res
        }
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("<br/>" + "PreInit");
        }
    }
    }