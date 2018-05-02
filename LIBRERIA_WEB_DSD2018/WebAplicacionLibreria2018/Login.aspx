<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebAplicacionLibreria2018.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<!DOCTYPE html><html >
  <head>
    <meta charset="UTF-8">
    <title>Login</title>    
        <link rel="stylesheet" href="style.css">    
  </head>

  <body background="fondo.jpg" style="background-repeat: no-repeat;">

    <div class="wrapper">
	<div class="container">
		<h1>Bienvenido</h1>
		
		<form id="Form1" class="form" runat="server">
			    




<div>

     <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
</div>

    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>





    <asp:Button ID="btnNuevo" runat="server" onclick="btnNuevo_Click" 
        Text="Entrar" />






		</form>
	</div>
	
	<ul class="bg-bubbles">
		<li></li>
		<li></li>
		<li></li>
		<li></li>
		<li></li>
		<li></li>
		<li></li>
		<li></li>
		<li></li>
		<li></li>
	    <li>
            
	</ul>
</div>
    <script src='js/jquery.min.js'></script>

        <script src="js/index.js"></script>

    
    
    
  </body>
</html>
