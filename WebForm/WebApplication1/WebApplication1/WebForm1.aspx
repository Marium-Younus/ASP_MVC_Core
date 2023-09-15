<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My First Application</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.4.1/dist/css/bootstrap.min.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-12 mt-5">
                    <h1 id="title" runat="server" >Welcome To ASP.NET Web Form</h1>
                    <asp:Button runat="server" OnClick="Unnamed_Click" Text="Submit" CssClass="btn btn-primary d-grid" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
