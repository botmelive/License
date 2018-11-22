<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="newlicense.aspx.cs" Inherits="Licence.newlicense" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create New License</title>
    <link rel="stylesheet" href="new_license_page.css" />
    <link href="https://fonts.googleapis.com/css?family=Bai+Jamjuree" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css?family=Abel|Amatic+SC|Raleway:100,200,300,400,500,600,700,800,900"
        rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
    <div class="formclass">
        <h2>
            Create License</h2>
        <asp:TextBox ID="namebox" CssClass="input" placeholder="Name" runat="server"></asp:TextBox>
        <asp:TextBox ID="dobbox" CssClass="input" placeholder="DOB" TextMode="Date" runat="server"></asp:TextBox>
        <asp:TextBox ID="phnumberbox" CssClass="input" placeholder="Phone Number" TextMode="Phone"
            runat="server"></asp:TextBox>
        <asp:TextBox ID="addressbox" CssClass="input" placeholder="Address" runat="server"></asp:TextBox>
        <asp:TextBox ID="passwdbox" CssClass="input" placeholder="Password" TextMode="Password"
            runat="server"></asp:TextBox>
        <div align="center">
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="input" DataSourceID="SqlDataSource2"
                DataTextField="Bname" DataValueField="Bname">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:LicenseConnectionString %>"
                SelectCommand="SELECT [Bname] FROM [Branch]"></asp:SqlDataSource>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" CssClass="validator"
                ErrorMessage="You Need A Name!" ControlToValidate="namebox"></asp:RequiredFieldValidator>
            <asp:Button class="btn" ID="Button1" runat="server" Text="SUBMIT" OnClick="Button1_Click" />
        </div>
    </div>
    </form>
</body>
</html>
