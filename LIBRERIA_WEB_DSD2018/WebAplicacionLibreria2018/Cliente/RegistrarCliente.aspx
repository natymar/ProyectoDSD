<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarCliente.aspx.cs" Inherits="WebAplicacionLibreria2018.Cliente.RegistrarCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 80px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: auto;">
            <tr>
                <td>
                    <asp:LinkButton ID="lnkAtras" runat="server" PostBackUrl="~/Cliente/CrudClientes.aspx">Atras ::: </asp:LinkButton>
                </td>
                <td>&nbsp;</td>
               
            </tr>
            <tr>
                <td>codigo</td>
                <td>
                    <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
                </td>
             
            </tr>
                        <tr>
                <td>Nombre</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                            </td>
             
            </tr>
                        <tr>
                <td>
                    Apellido Paterno :</td>
                <td>
                    <asp:TextBox ID="txtPaterno" runat="server"></asp:TextBox>
                            </td>
             
            </tr>
        
                        <tr>
                <td>
                    Apellido Materno:</td>
                <td>
                    <asp:TextBox ID="txtMaterno" runat="server"></asp:TextBox>
                            </td>
             
            </tr>
        
                        <tr>
                <td>
                    Nro DNI :</td>
                <td>
                    <asp:TextBox ID="txtDni" runat="server"></asp:TextBox>
                            </td>
             
            </tr>
        
                        <tr>
                <td>
                    Correo :</td>
                <td>
                    <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
                            </td>
             
            </tr>
        
                        <tr>
                <td>
                    <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" />
                            </td>
                <td>&nbsp;</td>
             
            </tr>
        
        </table>
    </div>
    </form>
</body>
</html>
