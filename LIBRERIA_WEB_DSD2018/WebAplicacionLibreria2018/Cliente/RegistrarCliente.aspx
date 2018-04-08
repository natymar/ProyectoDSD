<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarCliente.aspx.cs" Inherits="WebAplicacionLibreria2018.Cliente.RegistrarCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: auto;">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
               
            </tr>
            <tr>
                <td>Nombre :</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
             
            </tr>
                        <tr>
                <td>Apellido :</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                            </td>
             
            </tr>
                        <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Registrar" />
                            </td>
                <td>&nbsp;</td>
             
            </tr>
        
        </table>
    </div>
    </form>
</body>
</html>
