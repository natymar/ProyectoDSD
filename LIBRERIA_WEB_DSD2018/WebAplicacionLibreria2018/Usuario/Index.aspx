<%@ Page Title="" Language="C#" MasterPageFile="~/Web_Sis_Libreria.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebAplicacionLibreria2018.Index" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 52px;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        
    <form id="form1" runat="server">



      Registrar Usuario               
<div  id="CajaNota" style="width: 90%; margin-right: 5%; margin-left: 5%; text-align: center" runat="server">
                <table class="table table-bordered table-hover" border="1" id="unaTabla"">

	<tr>
		<td>
            Codigo de Cliente :
		</td>
        <td>
            <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>  
        </td>
	</tr>
	<tr>
		<td>Nombre :</td>
        <td>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox> 
        </td>
	</tr>

	<tr>
		<td>DNI :</td>
        <td>
            <asp:TextBox ID="txtDni" runat="server"></asp:TextBox> 
        </td>
	</tr>


     <tr>
		<td>Clave Usuario :</td>
        <td>
            <asp:TextBox ID="txtClave" runat="server" TextMode="Password"></asp:TextBox> 
        </td>
	</tr>

 <tr>
		<td>Perfil :</td>
        <td>  
           <asp:DropDownList ID="ddlNivel" runat="server">
            <asp:ListItem Text="Usuario" Value="0" />
            <asp:ListItem Text="Administrador" Value="1" />
        </asp:DropDownList>

        </td>
	</tr>

    <tr>
		<td class="auto-style1">
            <asp:Button ID="btnLimpiarUsuario" runat="server" Text="Limpiar" CssClass="btn btn-info" OnClick="btnLimpiarUsuario_Click" />
		</td>
        <td class="auto-style1">
            <asp:Button ID="btnRegistrarCliente" runat="server" Text="Registrar" CssClass="btn btn-info" OnClick="btnRegistrarUsuario_Click"/>
        </td>
	</tr>
</table>
</div>
</form>



</asp:Content>
    