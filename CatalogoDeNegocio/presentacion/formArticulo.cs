using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace presentacion
{
    public partial class formArticulo : Form
    {
        private MarcaNegocio marca = new MarcaNegocio();
        private CategoriaNegocio categoria = new CategoriaNegocio();
        //Declaro esta variable Articulo como atributo de la clase para el form_closing
        private Articulo articuloClase;
        private String tituloModificoArticulo = "Modificar Articulo";
        //Declaro y asigno valor a recargar imagen. Lo dejo en true para evitar confusiones en las funciones.
        private bool recargarImagen = true;
        public formArticulo()
        {
            InitializeComponent();
        }

        //Constructor para modificar Articulo
        public formArticulo(Articulo articuloAModificar)
        {
            InitializeComponent();
            Text = tituloModificoArticulo;
            articuloClase = articuloAModificar;
        }

        private void agregarArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                cBMarcas.DataSource = marca.listar();
                cBCategorias.DataSource = categoria.listar();
                Precio.Text = "0.00";

                if (articuloClase != null)
                {
                    codigoArt.Text = articuloClase.CodigoArticulo;
                    nombre.Text = articuloClase.Nombre;
                    descripcion.Text = articuloClase.Descripcion;
                    cBMarcas.Text = articuloClase.Marca.Nombre;
                    cBCategorias.Text = articuloClase.Categoria.Nombre;
                    Precio.Text = articuloClase.Precio.ToString();
                    tBUrlImage.Text = articuloClase.UrlImagen;
                    RecargarImg(tBUrlImage.Text, !recargarImagen);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Agrego el booleano para poder validar si recargo la imagen
        //Si al momento de cargar el formulario no tiene imagen asignada, recargo es false ya que no la modifico
        //Si la modifica en modificar_AceptarClick entonces recargo = true y valida si la imagen se puede usar o no.
        private void RecargarImg(string img, bool recargo)
        {
                try
                {
                    pBMarca.Load(img);
                }
                catch (Exception)
                {
                    pBMarca.Image = pBMarca.ErrorImage;
                    if (recargo == true)
                    MessageBox.Show("No se puede acceder a la imagen. Modifique URL o contactese con Soporte");
                    
                        //throw;
                }            
        }
    
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(articuloClase != null)
            {
                if (MessageBox.Show("Esta seguro cancelar la modificacion del articulo " + articuloClase.Nombre + "?", "Modificar Articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Close();
            }
            Close();
        }

        private void agregarArticulo_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Si articuloAgregado(Declarado como atributo de clase) es NULL, osea no se envio a BBDD, pregunta si esta seguro, caso contrario sale.
            if(articuloClase == null)
            {
                if ((MessageBox.Show("Si cancela el alta se perderán todos los datos", "Cancelar alta de articulo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)) == DialogResult.Cancel)
                    e.Cancel = true;
            }
            //Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            ArticuloNegocio accionArticulo = new ArticuloNegocio();
            if (articuloClase == null)
                articuloClase = new Articulo();

            if (Precio.Text == "")
                Precio.Text = "0.00";

            accionArticulo.modificarValoresArticulo(articuloClase, codigoArt.Text, nombre.Text, descripcion.Text, (Marca)cBMarcas.SelectedItem, (Categoria)cBCategorias.SelectedItem, Convert.ToDecimal(Precio.Text), tBUrlImage.Text);
           if (articuloClase.Id == 0) {
                try
                {
                    if (accionArticulo.agregar(articuloClase))
                    {
                        MessageBox.Show("Se añadió correctamente el articulo: " + articuloClase.Nombre, "ALTA DE ARTICULO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al intentar agregar el articulo en el sistema.");

                    }
                }
                catch (Exception)
                {


                    MessageBox.Show("ERROR AL ENVIAR ARTICULO A LA BASE DE DATOS. LLAME A SOPORTE");
                    throw;
                }
            }else
            {
                try
                {

                    if (accionArticulo.modificar(articuloClase))
                        MessageBox.Show("Se modifico correctamente el articulo");
                    Dispose();
                }
                catch (Exception)
                {
                    throw;
                }
            }

            
        }

        private void Precio_KeyPress(object sender, KeyPressEventArgs e)
        {  
                if (((e.KeyChar < 48 && e.KeyChar != 46)|| e.KeyChar > 57) && e.KeyChar != 8)
                    e.Handled = true;  
        }

        private void tBUrlImage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tBUrlImage.Text != "" && e.KeyChar == 13)
            {
                RecargarImg(tBUrlImage.Text, recargarImagen);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCategoria formCategoria = new FormCategoria();
            formCategoria.ShowDialog();

            cBCategorias.DataSource = categoria.listar();
        }

        private void btnMasMarca_Click(object sender, EventArgs e)
        {
            FormMarca formMarca = new FormMarca();
            formMarca.ShowDialog();

            cBMarcas.DataSource = marca.listar();
        }
    }
}
