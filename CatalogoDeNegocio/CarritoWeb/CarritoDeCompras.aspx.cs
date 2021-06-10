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
    public partial class CarritoDeCompras : System.Web.UI.Page
    {
        public Carrito Carrito { get; set; }
        public String SubtituloSinItems { get; set; }
        public String SubtituloConItems { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            SubtituloSinItems = "No existen Items agregados";
            SubtituloConItems = "Items de carrito";
            try
            {
                Carrito = (Carrito)Session["CarritoDeCompras"];
                if (Carrito == null)
                {
                    Subtitulo.Text = SubtituloSinItems;
                }
                else
                {
                    Subtitulo.Text = SubtituloConItems;
                    if (!IsPostBack)
                    {
                        //Repetidor Lista
                        ItemsEnCarrito.DataSource = Carrito.ListaDeItems;
                        ItemsEnCarrito.DataBind();
                    }
                }
            }
            catch
            {
                Response.Redirect("Error.aspx");
            }
        }

        protected void Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                //Metodo explicado en ListaDeArticulos.aspx.cs linea 44 
                int idArticuloAEliminar = int.Parse(((Button)sender).CommandArgument);
                Carrito.eliminarItemDeLista(idArticuloAEliminar);
                Session.Add("CarritoDeCompras", Carrito);
                ItemsEnCarrito.DataSource = null;
                ItemsEnCarrito.DataSource = Carrito.ListaDeItems;
                ItemsEnCarrito.DataBind();
            }
            catch
            {
                Response.Redirect("Error.aspx");
            }
        }

        protected void EliminarItem_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                //Metodo explicado en ListaDeArticulos.aspx.cs linea 44 
                int idArticuloAEliminar = int.Parse(((ImageButton)sender).CommandArgument);
                Carrito.eliminarItemDeLista(idArticuloAEliminar);
                Session.Add("CarritoDeCompras", Carrito);
                ItemsEnCarrito.DataSource = null;
                ItemsEnCarrito.DataSource = Carrito.ListaDeItems;
                ItemsEnCarrito.DataBind();
            }
            catch
            {
                Response.Redirect("Error.aspx");
            }
        }

        protected void Restar_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                //Metodo explicado en ListaDeArticulos.aspx.cs linea 44 
                int idArticuloAEliminar = int.Parse(((ImageButton)sender).CommandArgument);
                Carrito.descontarCantidadDeItemsDeLista(idArticuloAEliminar);
                Session.Add("CarritoDeCompras", Carrito);
                ItemsEnCarrito.DataSource = null;
                ItemsEnCarrito.DataSource = Carrito.ListaDeItems;
                ItemsEnCarrito.DataBind();
            }
            catch
            {
                Response.Redirect("Error.aspx");
            }
        }

        protected void Sumar_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                //Metodo explicado en ListaDeArticulos.aspx.cs linea 44 
                int idArticuloAEliminar = int.Parse(((ImageButton)sender).CommandArgument);
                Carrito.aumentarCantidadDeItemsDeLista(idArticuloAEliminar);
                Session.Add("CarritoDeCompras", Carrito);
                ItemsEnCarrito.DataSource = null;
                ItemsEnCarrito.DataSource = Carrito.ListaDeItems;
                ItemsEnCarrito.DataBind();
            }
            catch
            {
                Response.Redirect("Error.aspx");
            }
        }

    }
}