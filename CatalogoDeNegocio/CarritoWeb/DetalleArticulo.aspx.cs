using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
using dominio;

namespace CarritoWeb
{
    public partial class DetalleArticulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ArticuloNegocio articuloN = new ArticuloNegocio();
            try
            {

                int Id = int.Parse(Request.QueryString["Id"]);
                List<Articulo> listado = (List<Articulo>)Session["ListadoDeArticulos"];
                Articulo seleccionado = listado.Find(x => x.Id == Id);
                lblNombre.Text=seleccionado.Nombre;
                lblDescripcion.Text = seleccionado.Descripcion;
                lblUrlImagen.Text = seleccionado.UrlImagen;
            }
            catch
            {
                Response.Redirect("Error.aspx");
            }

        }
    }
}