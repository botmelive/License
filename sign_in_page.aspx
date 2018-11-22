<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sign_in_page.aspx.cs" Inherits="Licence.sign_in_page" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign In</title>
    <link rel="stylesheet" href="sign_in.css" />
    <link href="https://fonts.googleapis.com/css?family=Bai+Jamjuree" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css?family=Abel|Amatic+SC|Raleway:100,200,300,400,500,600,700,800,900" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">

      <div class="navigation">
        <ul>
            <li><a href="#">Home</a></li>
            <li><a href="newlicense.aspx">Make License</a></li>
            <li id="logo">SIGN IN</li>
            <li><a href="sign_in_page.aspx">Renew License</a></li>
            <li><a href="sign_in_page.aspx">Sign In</a></li>
        </ul>
     </div>

    <div class="formclass">
        <h2>SIGN IN</h2>

            <asp:TextBox ID="namebox" CssClass="input" placeholder="Name" runat="server" ></asp:TextBox><asp:RequiredFieldValidator
            ID="RequiredFieldValidator1" runat="server"
            CssClass="validator" ShowMessageBox="true"
            ErrorMessage="You Need A Name!" ControlToValidate="namebox"></asp:RequiredFieldValidator>

        <asp:TextBox ID="passwdbox" CssClass="input" placeholder="Password" TextMode="Password" runat="server"></asp:TextBox>
        <div align=center>
        <asp:Button class="btn" ID="Button1" runat="server" Text="LOG IN" onclick="Button1_Click" />
        </div>
        
    </div>
    </form>
</body>
</html>
