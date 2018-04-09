<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SolicitudCotizacion.aspx.cs" Inherits="WebAplicacionLibreria2018.Pedido.SolicitudCotizacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Solicitar Pedido</h2>
            <tr></tr>            
            <tr>
                <td>Nombre:</td>
                <td>
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                </td>             
            </tr>                        
            <tr>
                <td>Apellido:</td>
                <td>
                    <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                </td>             
            </tr>            
            <tr>
                <td>Correo:</td>
                <td>
                    <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
                </td>             
            </tr>
            <tr>
                <td>Adjuntar Lista:</td>
                <td>
                    <asp:TextBox ID="txtRutaArchivo" runat="server"></asp:TextBox>
                </td>             
            </tr>
        </div>
    </form>

</body>
</html>
