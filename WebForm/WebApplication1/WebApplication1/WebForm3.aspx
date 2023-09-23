<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>File Uploading</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.4.1/dist/css/bootstrap.min.css"/>
</head>
<body>
    <form id="form1" runat="server">
         <div class="container">
            <div class="row">
            <div class="col-md-12 mt-5">
                 <h1 id="title" runat="server" >File Uploading Work</h1>
            </div>
                 <div class="col-md-12 mt-5">
                       <asp:FileUpload ID="file_upload" runat="server" CssClass="form-control" />  
                 </div>
                <div class="col-md-12 mt-3 d-grid">
                 <asp:Button runat="server" ID="btn_upload" OnClick="btn_upload_Click" Text="Upload" CssClass="btn btn-primary "  />
                </div>               
            </div>
             <div class="mt-4 p-5 bg-info text-white rounded">
                  <h5 id="msg" runat="server"></h5>    
             </div>
         </div>
    </form>
</body>
</html>
