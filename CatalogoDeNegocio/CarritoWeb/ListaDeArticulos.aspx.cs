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
                Session.Add("ListadoDeArticulos", listaDeArticulos);

                if (!IsPostBack)
                {
                    //Repetidor Lista
                    Lista.DataSource = ArticulosEnBase.Listar();
                    Lista.DataBind();

                }
                
            }
            catch
            {
                Response.Redirect("Error.aspx");
            }
        }

        protected void AgregarArticulo_Click(object sender, EventArgs e)
        {
            try
            {
                //Paso los valores de CommandArgument a un array de string, al ser varios valores primero los divido 
                // por un array de caracteres que solo tiene "," ya que asi estan en el CommandArgument del boton (Linea 34)
                //Aca declaro el array de string de 3 
                String[] valores = new String[3];
                //A este array, le asigno el CommandArgument dividido por ","
                valores = ((Button)sender).CommandArgument.Split(new char[] { ',' });
                //Creo un nuevo ItemCarrito pasandole como parametro los valores del array
                //[0] = Id, [1] = Nombre, [2] = Precio. 
                ItemCarrito nuevo = new ItemCarrito(int.Parse(valores[0]), valores[1], Convert.ToDecimal(valores[2]));
                Carrito = (Carrito)Session["CarritoDeCompras"];
                if (Carrito == null) 
                    Carrito = new Carrito();
                Carrito.agregarItemDeLista(nuevo);

                Session.Add("CarritoDeCompras", Carrito);
            }
            catch
            {
                Response.Redirect("Error.aspx");
            }


        }

        protected void Detalles_Click(object sender, EventArgs e)
        {

        }

    }
}