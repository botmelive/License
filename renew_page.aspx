<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="renew_page.aspx.cs" Inherits="Licence.renew_page" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Renew License</title>
    <link href="https://fonts.googleapis.com/css?family=Raleway:400, 600" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css?family=Abel|Amatic+SC|Raleway:100,200,300,400,500,600,700,800,900"
        rel="stylesheet">
    <link rel="stylesheet" href="renew_style.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="header">
            <div class="container">
                <ul class="nav">
                    <li>Renew Page</li>
                </ul>
            </div>
        </div>
        <div class="formclass">
            <h2>
                PROFILE</h2>
            <div class="content-holder" align="center">
                <p>
                    Name:<asp:Label ID="NameLabel" runat="server" CssClass="txt" Text="Name"></asp:Label></p>
                <p>
                    DOB:<asp:Label ID="DOBLabel" runat="server" CssClass="txt" Text="DOB"></asp:Label></p>
                <p>
                    New License:<asp:Label ID="LicenseLabel" runat="server" CssClass="txt" Text="H3E1DER"></asp:Label></p>
                <asp:TextBox ID="phbox" CssClass="input" placeholder="Phone Number" runat="server"></asp:TextBox>
                <asp:TextBox ID="addbox" CssClass="input" placeholder="Address" runat="server"></asp:TextBox>

                <p>
                    Issue Date:<asp:Label ID="IssueDateLabel" runat="server" CssClass="txt" Text="dd/mm/yyyy"></asp:Label></p>
                <asp:Button class="btn" ID="Button1" runat="server" Text="SAVE" OnClick="Button1_Click" />
            </div>
        </div>
    </div>
    </form>
</body>
</html>
