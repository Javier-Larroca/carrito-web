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
    public partial class SiteMaster : MasterPage
    {
        public  Carrito carritoGlobal { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        public void actualizarCarrito()
        {
            if (Session["CarritoDeCompras"] == null)
            {
                carritoGlobal = new Carrito();
                carritoGlobal.calcularCantidadItems();
            }
            else
            {

                carritoGlobal = (Carrito)Session["CarritoDeCompras"];
                carritoGlobal.calcularCantidadItems();
            }
        }
    }
}