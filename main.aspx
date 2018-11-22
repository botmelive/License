<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="Licence.main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>License</title>
    <link rel="stylesheet" href="main_page.css" />
    <link href="https://fonts.googleapis.com/css?family=Abel|Amatic+SC|Raleway:100,200,300,400,500,600,700,800,900" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css?family=Bai+Jamjuree" rel="stylesheet">
</head>

<body>

  <div class="navigation">
    <ul>
      <li><a href="#">Home</a></li>
      <li><a href="newlicense.aspx">Make License</a></li>
      <li id="logo">LICENSE</li>
      <li><a href="sign_in_page.aspx">Renew License</a></li>
      <li><a href="sign_in_page.aspx">Sign In</a></li>
    </ul>
  </div>

  <div id="cover">
    <div class="cover-content">
      <h1>Register Your License Here</h1>
      <a href="newlicense.aspx" class="btn">Create License</a>
      <a href="sign_in_page.aspx" class="btn">Renew License</a>
      <a href="sign_in_page.aspx" class="btn">Sign In</a>
    </div>
  </div>

</body>
</html>
