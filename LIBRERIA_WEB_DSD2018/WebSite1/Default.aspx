<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Bienvenido a la Tienda Online</h2>
    <h3 id="date"></h3>
    <script>
        document.getElementById("date").innerHTML = Date();
    </script>
    <br />
    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView_SelectedIndexChanged">
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Select" Text="Buy" />
        </Columns>
    </asp:GridView>
    <br />
    <p>selecciona los productos que desees comprar.</p>
    <p>
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Continuar" OnClick="Button1_Click" />
    </p>
</asp:Content>
