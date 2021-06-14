<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleArticulo.aspx.cs" Inherits="CarritoWeb.DetalleArticulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Detalle de articulo</h1>
    <div class="card mb-3" style="max-width: 540px;">
        <div class="row g-0">
            <div class="col-md-4">
                <img class="imgCarrito" alt="Imagen Articulo" src="<%= Seleccionado.UrlImagen %>" >
            </div>
            <div class="col-md-8">
                <div class="card-body">
                    <h5 class="card-title"><%= Seleccionado.Nombre %></h5>
                    <p class="card-text"><%= Seleccionado.Categoria.Nombre %></p>
                    <p class="card-text"><%= Seleccionado.Marca.Nombre %> </p>
                    <p class="card-text">$ <%= Seleccionado.Precio %></p>
                    <p class="card-text"><small class="text-muted"><%= Seleccionado.Descripcion %></small></p>
                </div>
            </div>
        </div>
    </div>
    <a href="ListaDeArticulos">
        <button type="button"class="btn btn-secondary">
            Volver
        </button>
    </a>

</asp:Content>
