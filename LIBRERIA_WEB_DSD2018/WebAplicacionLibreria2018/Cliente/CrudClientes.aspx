<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrudClientes.aspx.cs" Inherits="WebAplicacionLibreria2018.Cliente.CrudClientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mantenedor :: Clientes</title>
</head>
<body>
    
    <nav >

    </nav>
    <article>
       
    </article>
    
        <form id="form1" runat="server">
            <div id="ConsultaCliente">
               <span class="buscar">Filtar(por nombre) de Cliente</span>
                <table style="width:50%;">
                    <tr>
                        <td>
                            <asp:TextBox ID="txtFiltro" runat="server"></asp:TextBox></td>
                        <td>
                            <asp:Button ID="btnBuscar" runat="server" Text="Button" /></td>
                        
                    </tr>
                </table>
                
            </div>
            <span class="tituloGrid">Lista de Clientes</span>
            <div id="main">
                <asp:GridView ID="gridClientes" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <EditRowStyle BackColor="#999999" />
                    <EmptyDataTemplate>
                        <div class="linkCrearCliente">
                            <span class="texto">
                                El cliente, no Existe :::::
                            </span><br>
                            <asp:LinkButton ID="linkCrear" Text="Registrar Cliente" runat="server">LinkButton

                            </asp:LinkButton>
                        </div>
                    </EmptyDataTemplate>
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
                    
            </div>
        </form>
    <footer>
        <span class="pie">
            c@pyrigth 2018   Todos los derechos Reservados
        </span>
    </footer>
</body>
</html>
