<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CarritoDeCompras.aspx.cs" Inherits="CarritoWeb.CarritoDeCompras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
<h1>Items en Carrito</h1>    
    <asp:Label ID="Subtitulo" runat="server"></asp:Label>
    <%if (Subtitulo.Text == SubtituloConItems)
        { %>

        <asp:Repeater runat="server" ID="ItemsEnCarrito">
            <ItemTemplate>

            <div class="card mb-3" style="max-width: 540px;">
              <div class="row g-0">
                <div class="col-md-4">
                  <img src="...>" alt="Imagen producto">
                </div>
                <div class="col-md-8">
                  <div class="card-body">
                    <h5 class="card-title"><%#Eval("NombreArticulo") %></h5>
                    <p class="card-text">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                    <p class="card-text"><small class="text-muted"><%#Eval("Cantidad") %></small></p>
                    
                      <asp:Button class="btn btn-dark" Text="Eliminar todo el item de Carrito" ID="Button1"  OnClick="Eliminar_Click" CommandArgument='<%#Eval("IdArticulo")%>' runat="server" />
                    
                      <asp:Button class="btn btn-dark" Text="-" ID="Button2" OnClick="EliminarCantidad_Click" CommandArgument='<%#Eval("IdArticulo") %>' runat="server" />
                  </div>
                </div>
              </div>
            </div>
            </ItemTemplate>
        </asp:Repeater>
    <%}%>
</asp:Content>
