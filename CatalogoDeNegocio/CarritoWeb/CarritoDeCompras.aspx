<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CarritoDeCompras.aspx.cs" Inherits="CarritoWeb.CarritoDeCompras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
<h1>Items en Carrito</h1>    
    <asp:Label ID="Subtitulo" runat="server"></asp:Label>
    <%if (Subtitulo.Text == SubtituloConItems)
        {
            %>

        <asp:Repeater runat="server" ID="ItemsEnCarrito">
            <ItemTemplate>

            <div class="card mb-3" style="max-width: 540px;">
              <div class="row g-0">
                <div class="col-md-4">
                  <img src="<%#Eval("UrlImagenArticulo") %>" alt="Imagen producto">
                </div>
                <div class="col-md-8">
                  <div class="card-body">
                    <h5 class="card-title"><%#Eval("NombreArticulo") %></h5>
                    <p class="card-text">Precio Unitario: $<%#Eval("Precio")%></p>
                    <p class="card-text">Precio Total: $<%#Eval("PrecioTotal")%></p>
                      <ul class="iconosCardCarrito">
                          <li>
                              <asp:ImageButton src="img/minus-solid.svg" class="iconoCarrito" ID="Restar" OnClick="Restar_Click" CommandArgument='<%#Eval("IdArticulo")%>' runat="server" />
                          </li>
                          <li>
                              <%--<p class="card-text"><small class="text-muted"><%#Eval("Cantidad") %></small></p>--%>
                              <p class="cantidadItems"><%#Eval("Cantidad") %></p>
                          </li>
                          <li>
                              <asp:ImageButton src="img/plus-solid.svg" class="iconoCarrito" ID="Sumar" OnClick="Sumar_Click" CommandArgument='<%#Eval("IdArticulo")%>' runat="server" />
                          </li>
                          <li>
                              <asp:ImageButton src="img/trash-alt-solid.svg" class="iconoCarrito" ID="EliminarItem" OnClick="EliminarItem_Click" CommandArgument='<%#Eval("IdArticulo")%>' runat="server" />
                          </li>
                      </ul>
                      <%--<asp:Button class="btn btn-dark" Text="Eliminar todo el item de Carrito" ID="Button1"  OnClick="Eliminar_Click" CommandArgument='<%#Eval("IdArticulo")%>' runat="server" />--%>
                  </div>

                </div>
              </div>
            </div>
            </ItemTemplate>
            
        </asp:Repeater>
        <h5>Importe Total: $<%= Carrito.importeTotal %></h5>
    <%}%>
</asp:Content>
