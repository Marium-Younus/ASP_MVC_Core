<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Form Element</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.4.1/dist/css/bootstrap.min.css"/>
</head>
<body>
    <form id="form1" runat="server">
         <div class="container">
            <div class="row">
             <div class="col-md-12 mt-5">
                <h1 id="title" runat="server" >Form Element</h1>
             </div>
             <div class="col-md-12 mt-5">
                <asp:TextBox  runat="server" ID="user" placeholder="Username" CssClass="form-control"></asp:TextBox>
             </div>
            <div class="col-md-12 mt-3">
               <asp:TextBox TextMode="Email" runat="server" ID="email" placeholder="Email" CssClass="form-control"></asp:TextBox>
            </div>
             <div class="col-md-12 mt-3">
                <asp:TextBox TextMode="Password" runat="server" ID="pwd" placeholder="Password" CssClass="form-control"></asp:TextBox>
             </div>
                 <div class="col-md-12 mt-3">
                    <asp:RadioButton ID="RadioButton1" runat="server"  Text="Male" GroupName="gender"/> 
                       <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" GroupName="gender"/>
                 </div>
              <div class="col-md-12 mt-3">
               <asp:TextBox TextMode="Date" runat="server" ID="date"  CssClass="form-control"></asp:TextBox>
              </div>
               <div class="col-md-12 mt-3">
                   <asp:CheckBox ID="CheckBox1" runat="server" Text="Football" />  
                    <asp:CheckBox ID="CheckBox2" runat="server" Text="Cricket" />  
                    <asp:CheckBox ID="CheckBox3" runat="server" Text="Hockey" />  
               </div>
                
              <div class="col-md-12 mt-3 d-grid">
                <asp:Button runat="server" ID="btn" OnClick="btn_Click" Text="Submit" CssClass="btn btn-primary "  />
              </div>


            </div>
             <div class="mt-4 p-5 bg-primary text-white rounded">
              <h1>Result</h1>
              <p id="result" runat="server">Lorem ipsum...</p>
            </div>
         </div>




    </form>


</body>
</html>
