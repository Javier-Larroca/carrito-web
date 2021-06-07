<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CarritoDeCompras.aspx.cs" Inherits="CarritoWeb.CarritoDeCompras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
<h1>Items en Carrito</h1>    
    <asp:Label ID="Subtitulo" runat="server"></asp:Label>
    <%if (Subtitulo.Text == SubtituloConItems)
        { %>
    <table>
        <tr>
            <td>Articulo</td>
            <td>Acción</td>  
        </tr>
        <asp:Repeater runat="server" ID="ItemsEnCarrito">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("NombreArticulo") %></td>
                    <td>
                        <asp:Button Text="Eliminar todo el item de Carrito" ID="Eliminar"  OnClick="Eliminar_Click" CommandArgument='<%#Eval("IdArticulo")%>' runat="server" />
                    </td>
                    <td><%#Eval("Cantidad") %></td>
                    <td>
                        <asp:Button Text="Eliminar cantidad" ID="EliminarCantidad" OnClick="EliminarCantidad_Click" CommandArgument='<%#Eval("IdArticulo") %>' runat="server" />
                    </td>    
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <%}%>
</asp:Content>
