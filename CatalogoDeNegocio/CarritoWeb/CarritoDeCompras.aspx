<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CarritoDeCompras.aspx.cs" Inherits="CarritoWeb.CarritoDeCompras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
<h1>Items en Carrito</h1>    
    <asp:Label ID="Subtitulo" runat="server"></asp:Label>
    <%if (Subtitulo.Text == SubtituloConItems)
        { %>
    <% foreach (dominio.ItemCarrito articulo in Carrito.ListaDeItems)
        {%>
    <table>
        <tr>
            <td>
                <% = articulo.NombreArticulo %>
            </td>
        </tr>
    </table>
    <%} %>
    <%}%>
</asp:Content>
