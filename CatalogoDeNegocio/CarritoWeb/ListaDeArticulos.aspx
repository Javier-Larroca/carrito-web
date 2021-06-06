<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaDeArticulos.aspx.cs" Inherits="CarritoWeb.ListaDeArticulos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Lista de articulos</h1>

    <asp:Label Text="Lista desplegable de articulos" runat="server" />
    <table>
        <tr>
            <td>Articulo</td>
            <td>Acción</td>  
        </tr>
        <asp:Repeater runat="server" ID="Lista">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("Nombre") %></td>
                    <td>
                        <asp:Button Text="agregar a carrito" ID="agregararticulo"  OnClick="AgregarArticulo_Click" CommandArgument='<%#Eval("Id") + "," + Eval("Nombre") + "," + Eval("Precio")%>' runat="server" />
                    </td>
                    <td>
                        <asp:Button Text="ver detalles" ID="detalles" OnClick="Detalles_Click" runat="server" />
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>

     <p>
         <%--<% if (Carrito.ListaArticulos.Count() == 0) 
                 %>
         <p>No hay articulos agregados<p>
         <% else Carrito.ListaArticulos.Count()      %>--%>
     </p>
</asp:Content>
