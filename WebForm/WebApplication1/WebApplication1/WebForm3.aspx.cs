using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // Response.Write("Web Application .net");
        }
        protected void btn_upload_Click(object sender, EventArgs e)
        {
            if((file_upload.PostedFile != null) && (file_upload.PostedFile.ContentLength > 0))
            {
                string fn = System.IO.Path.GetFileName(file_upload.PostedFile.FileName);
                string SaveLocation = Server.MapPath("upload") + "\\" + fn;
                try
                {
                    file_upload.PostedFile.SaveAs(SaveLocation);
                    msg.InnerHtml = "The file has been uploaded<br />yahooo";
                
                    
                }
                catch (Exception ex)
                {
                    msg.InnerText = "Error: " + ex.Message;
                }
            }
            else
            {
                msg.InnerText = "Please select a file to upload.";
            }
        }
    }
}