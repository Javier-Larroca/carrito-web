using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace CarritoWeb
{
    public partial class ListaDeArticulos : System.Web.UI.Page
    {
        public Carrito Carrito { get; set; }
        public List<Articulo> listaDeArticulos;
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio ArticulosEnBase = new ArticuloNegocio();
            try
            {
                listaDeArticulos = ArticulosEnBase.Listar();
            }
            catch
            {
                Response.Redirect("Error.aspx");
            }
        }

        protected void AgregarArticulo_Click(object sender, EventArgs e)
        {
            if (Carrito == null) Carrito = new Carrito();
            
            //Reveer codigo y forma de pasar el objeto articulo al agregar articulo
            //Button clickeado = (Button)sender;
            //ArticuloCarrito nuevo = new ArticuloCarrito(seleccionado.CommandArgument.Id, seleccionado.CodigoArticulo, seleccionado.Nombre, seleccionado.Descripcion, seleccionado.Marca, seleccionado.Categoria, seleccionado.Precio, seleccionado.UrlImagen);
            //Carrito.agregarArticuloDeLista(nuevo);
        }

        protected void Detalles_Click(object sender, EventArgs e)
        {

        }
    }
}