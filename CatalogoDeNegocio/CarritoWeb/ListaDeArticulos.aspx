<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaDeArticulos.aspx.cs" Inherits="CarritoWeb.ListaDeArticulos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Lista de articulos</h1>

    <asp:Label Text="Lista desplegable de articulos" runat="server" />

    <div class="row row-cols-1 row-cols-md-3 g-4">
        <asp:Repeater runat="server" ID="Lista">
            <ItemTemplate>

                  <div class="col">
                    <div class="card">
                      <img src="<%#Eval("UrlImagen") %>" class="card-img-top" alt="...">
                      <div class="card-body">
                        <h5 class="card-title"><%#Eval("Nombre") %></h5>
                        <p class="card-text"><%#Eval("Descripcion") %>.</p>
                          <p>
                             <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-cart" viewBox="0 0 16 16">
                                <path d="M0 1.5A.5.5 0 0 1 .5 1H2a.5.5 0 0 1 .485.379L2.89 3H14.5a.5.5 0 0 1 .491.592l-1.5 8A.5.5 0 0 1 13 12H4a.5.5 0 0 1-.491-.408L2.01 3.607 1.61 2H.5a.5.5 0 0 1-.5-.5zM3.102 4l1.313 7h8.17l1.313-7H3.102zM5 12a2 2 0 1 0 0 4 2 2 0 0 0 0-4zm7 0a2 2 0 1 0 0 4 2 2 0 0 0 0-4zm-7 1a1 1 0 1 1 0 2 1 1 0 0 1 0-2zm7 0a1 1 0 1 1 0 2 1 1 0 0 1 0-2z"/>
                            </svg>
                          </p>
                            
                          <!-- Falta agregar icono, se hace desde el css -->
                            <asp:Button Text="Carrito" class="btn btn-dark" ID="agregararticulo" OnClick="AgregarArticulo_Click" CommandArgument='<%#Eval("Id") + "," + Eval("Nombre") + "," + Eval("Precio")%>' runat="server"/> 
                            
                     </div>
                   </div>
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
