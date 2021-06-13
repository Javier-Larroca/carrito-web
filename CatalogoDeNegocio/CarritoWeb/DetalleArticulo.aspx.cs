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
            try
            {
                string Id = Request.QueryString["Id"];

                lblSeleccionado.Text=Id;
            }
            catch
            {
                Response.Redirect("Error.aspx");
            }

        }
    }
}