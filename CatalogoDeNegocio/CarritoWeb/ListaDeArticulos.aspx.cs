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
                String[] valores = new String[4];
                //A este array, le asigno el CommandArgument dividido por ","
                valores = ((Button)sender).CommandArgument.Split(new char[] { ',' });
                //Creo un nuevo ItemCarrito pasandole como parametro los valores del array
                //[0] = Id, [1] = Nombre, [2] = Precio. 
                ItemCarrito nuevo = new ItemCarrito(int.Parse(valores[0]), valores[1], Convert.ToDecimal(valores[2]), valores[4]);
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
            //Falta armar 
        }

        protected void Carrito_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                //Paso los valores de CommandArgument a un array de string, al ser varios valores primero los divido 
                // por un array de caracteres que solo tiene "," ya que asi estan en el CommandArgument del boton (Linea 34)
                //Aca declaro el array de string de 3 
                String[] valores = new String[4];
                //A este array, le asigno el CommandArgument dividido por ","
                valores = ((ImageButton)sender).CommandArgument.Split(new char[] { ',' });
                //Creo un nuevo ItemCarrito pasandole como parametro los valores del array
                //[0] = Id, [1] = Nombre, [2] = Precio. 
                ItemCarrito nuevo = new ItemCarrito(int.Parse(valores[0]), valores[1], Convert.ToDecimal(valores[2]), valores[3]);
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

        protected void Filtro_Click(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada = new List<Articulo>();
            try
            {
                //De entrada averiguamos si ingresaron un numero, asi despues evitamos errores de formato al filtrar buscando precio
                bool esNumero = FiltroIngresado.Text.All(char.IsDigit);

                if (FiltroIngresado.Text != "" && OpcionesFiltro.SelectedValue != " ")
                {
                    if(!esNumero && OpcionesFiltro.SelectedValue == "Precio")
                    {
                        Aclaraciones.Text = "Debe ingresar números sin decimales para realizar la busqueda por Precio";
                        listaFiltrada = listaDeArticulos;
                    }
                    else
                    {
                            listaFiltrada = listaDeArticulos.FindAll(Busqueda =>
                            Busqueda.Nombre.ToUpper().Contains(FiltroIngresado.Text.ToUpper()) && OpcionesFiltro.SelectedValue == "Nombre"
                         || Busqueda.Descripcion.ToUpper().Contains(FiltroIngresado.Text.ToUpper()) && OpcionesFiltro.SelectedValue == "Descripción"
                         || Busqueda.Marca.Nombre.ToUpper().Contains(FiltroIngresado.Text.ToUpper()) && OpcionesFiltro.SelectedValue == "Marca"
                         //Aca agarro y y hago un if de una linea para el texto, si tiene solo numeros entonces lo deja como esta y lo convierte a decimal.
                         //En caso de que tenga letras le asigna un 0 directamente
                         || Busqueda.Precio >= Convert.ToDecimal(!esNumero ? "0" : FiltroIngresado.Text) && OpcionesFiltro.SelectedValue == "Precio");
                    }

                    Session.Remove("ListadoDeArticulos");
                    Session.Add("ListadoDeArticulos", listaFiltrada);
                    //Repetidor Lista
                    Lista.DataSource = listaFiltrada;
                    Lista.DataBind();
                    

                }
                else
                {
                    Aclaraciones.Text = "Debe completar valor a buscar y seleccionar filtro";
                }
            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx");
            }

        }
    }
}