<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="profile_page.aspx.cs" Inherits="Licence.profile_page" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Profile Page</title>
    <link href="https://fonts.googleapis.com/css?family=Raleway:400, 600" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css?family=Abel|Amatic+SC|Raleway:100,200,300,400,500,600,700,800,900" rel="stylesheet">
    <link rel="stylesheet" href="profile_page.css" />

</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div class="header">
        <div class="container">
            <ul class="nav">
                <li>Profile Page</li>
                <li><asp:Label ID="Label1" runat="server" CssClass="txt" Text="Branch"></asp:Label></li>
            </ul>
        </div>
    </div>

    <div class="formclass">
        <h2>PROFILE</h2>
        <div class="content-holder" align="center">

        <p>Name:<asp:Label ID="NameLabel" runat="server" CssClass="txt" Text="Name"></asp:Label></p>
        <p>DOB:<asp:Label ID="DOBLabel" runat="server" CssClass="txt" Text="DOB"></asp:Label></p>
        <p>License Number:<asp:Label ID="LicenseLabel" runat="server" CssClass="txt" Text="H3E1DER"></asp:Label></p>
        <p>Phone Number:<asp:Label ID="PHLabel" runat="server" CssClass="txt" Text="12345"></asp:Label></p>
        <p>Address:<asp:Label ID="AddressLabel" runat="server" CssClass="txt" Text="location"></asp:Label></p>
        <p>Issue Date:<asp:Label ID="IssueDateLabel" runat="server" CssClass="txt" Text="dd/mm/yyyy"></asp:Label></p>
        <asp:Button class="btn" ID="Button2" runat="server" Text="Renew" 
                onclick="Button2_Click" />
        <asp:Button class="btn" ID="Button1" runat="server" Text="LOG OUT" onclick="Button1_Click" />
        
        </div>
       
    </div>
        
    </div>
    </form>
</body>
</html>
