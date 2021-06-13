<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleArticulo.aspx.cs" Inherits="CarritoWeb.DetalleArticulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Detaller de articulo</h1>
    <asp:Label Text="lalala" ID="lblNombre" runat="server" />
    <asp:Label Text="lalala" ID="lblDescripcion" runat="server" />
    <asp:Label Text="lalala" ID="lblUrlImagen" runat="server" />
    <asp:Label Text="lalala" ID="lblPrecio" runat="server" />
    <asp:Label Text="lalala" ID="lblMarca" runat="server" />
    <div class="card mb-3" style="max-width: 540px;">
        <div class="row g-0">
            <div class="col-md-4">
                <img src="..." alt="...">
            </div>
            <div class="col-md-8">
                <div class="card-body">
                    <h5 class="card-title">Card title</h5>
                    <p class="card-text">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                    <p class="card-text"><small class="text-muted">Last updated 3 mins ago</small></p>
                </div>
            </div>
        </div>
    </div>
    <a href="ListaDeArticulos">
        <button type="button" class="btn btn-secondary">Volver</button>
    </a>

</asp:Content>
