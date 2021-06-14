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
        public Articulo Seleccionado { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            //ArticuloNegocio articuloN = new ArticuloNegocio();
            try
            {

                int Id = int.Parse(Request.QueryString["Id"]);
                List<Articulo> listado = (List<Articulo>)Session["ListadoDeArticulos"];
                Seleccionado = listado.Find(x => x.Id == Id);
                //lblNombre.Text=Seleccionado.Nombre;
                //lblDescripcion.Text = Seleccionado.Descripcion;
                ////lblMarca.Text = Seleccionado.Marca == null ? "Sin Marca asignada" : Seleccionado.Marca.Nombre; 
                //lblMarca.Text = Seleccionado.Marca.Nombre;
                //lblCategoria.Text = Seleccionado.Categoria.Nombre;
            }
            catch
            {
                Response.Redirect("Error.aspx");
            }

        }
    }
}