<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SolicitudCotizacion.aspx.cs" Inherits="WebAplicacionLibreria2018.Pedido.SolicitudCotizacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 393px; width: 606px;">
    <form id="form1" runat="server">  
        <br />
        <asp:Label ID="lbl_dni" runat="server" Text="DNI:"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txt_dni" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lbl_nomape" runat="server" Text="Nombres y Apellidos:"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txt_nomape" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lbl_correo" runat="server" Text="Correo:"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txt_correo" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lbl_archivo" runat="server" Text="Lista para cotizar:"></asp:Label>
        <br />
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <br />
        <br />
        <asp:Button ID="btn_enviar" runat="server" Text="ENVIAR" OnClick="btn_enviar_Click"/>
    </form>
</body>
</html>
