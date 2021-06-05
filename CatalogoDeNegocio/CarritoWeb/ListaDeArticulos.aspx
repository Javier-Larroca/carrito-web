<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaDeArticulos.aspx.cs" Inherits="CarritoWeb.ListaDeArticulos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Lista de articuloos</h1>

    <asp:Label Text="Lista desplegable de articulos" runat="server" />
    
    <% foreach (dominio.Articulo articulo in listaDeArticulos)
       {%>
        <table>
            <tr>
                <td>
                    <% = articulo.Nombre %>
                </td>
                <td>
                    <asp:Button text="Agregar a carrito" ID="AgregarArticulo" OnClick="AgregarArticulo_Click" CommandArgument="<% articulo %>" runat="server"/>
                </td>
                <td>
                    <asp:Button Text="Ver detalles" ID="Detalles" OnClick="Detalles_Click" runat="server" />
                </td>
       </tr>
        </table> 

     <%} %>
     <p>
         <%--<% if (Carrito.ListaArticulos.Count() == 0) 
                 %>
         <p>No hay articulos agregados<p>
         <% else Carrito.ListaArticulos.Count()      %>--%>
     </p>
</asp:Content>
