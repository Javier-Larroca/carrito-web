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
                else Subtitulo.Text = SubtituloConItems;
            }
            catch
            {
                Response.Redirect("Error.aspx");
            }
        }
    }
}