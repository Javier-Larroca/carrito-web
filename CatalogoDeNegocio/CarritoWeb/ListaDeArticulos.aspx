<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaDeArticulos.aspx.cs" Inherits="CarritoWeb.ListaDeArticulos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Lista de articulos</h1>

    <asp:Label Text="Lista desplegable de articulos" runat="server" />
    <br />
    <div>
        <asp:TextBox ID="FiltroIngresado" runat="server"></asp:TextBox>
        <asp:DropDownList ID="OpcionesFiltro" runat="server">
            <asp:ListItem Selected="True" Value=" " runat="server"></asp:ListItem>
            <asp:ListItem Value="Nombre" runat="server"></asp:ListItem>
            <asp:ListItem Value="Descripción" runat="server"></asp:ListItem>
            <asp:ListItem Value="Marca" runat="server"></asp:ListItem>
            <asp:ListItem Value="Precio" runat="server"></asp:ListItem>
        </asp:DropDownList>
        <asp:Button Text="Buscar" ID="Filtro" OnClick="Filtro_Click" runat="server" />
        <asp:Label ID="Aclaraciones" runat="server"></asp:Label>
    </div>
    <br />  
    <div class="row row-cols-1 row-cols-md-3 g-4">
        <asp:Repeater runat="server" ID="Lista">
            <ItemTemplate>

                <div class="col">
                    <a class="linkCard" href="DetalleArticulo.aspx?id=<%#Eval("Id") %>">
                        <div class="card">
                            <img src="<%#Eval("UrlImagen") %>" class="card-img-top imgArticulo center" alt="Imagen Articulo">
                            <div class="card-body">
                                <h5 class="card-title"><%#Eval("Nombre") %></h5>
                                <p class="card-text"><%#Eval("Descripcion") %>.</p>
                                
                                <ul class="iconosCard">
                                    <li>
                                        <asp:ImageButton src="img/cart-plus-fill.svg" class="iconoCarrito" ID="Carrito" OnClick="Carrito_Click" CommandArgument='<%#Eval("Id") + "|" + Eval("Nombre") + "|" + Eval("Precio") + "|" + Eval("UrlImagen")%>' Style="width: 28px;" runat="server" />
                                    </li>
                                    <li>
                                        <h5>
                                            <%#Eval ("Precio") %>
                                        </h5>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </a>
                </div>

            </ItemTemplate>
        </asp:Repeater>
    </div>

     <p>
         <%--<% if (Carrito.ListaArticulos.Count() == 0) 
                 %>
         <p>No hay articulos agregados<p>
         <% else Carrito.ListaArticulos.Count()      %>--%>
     </p>
</asp:Content>
