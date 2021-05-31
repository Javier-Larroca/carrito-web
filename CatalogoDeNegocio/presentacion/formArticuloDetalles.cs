using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;

namespace presentacion
{
    public partial class formArticuloDetalles : Form
    {
        private Articulo articuloAux;

        //Constructor para cargar Articulo
        public formArticuloDetalles(Articulo articuloAuxx)
        {
            InitializeComponent();
            articuloAux = articuloAuxx;
        }

        private void RecargarImg(string img)
        {
            try
            {
                pBArticulo.Load(img);
            }
            catch (Exception)
            {
                pBArticulo.Image = pBArticulo.ErrorImage;
            }
        }

        private void formArticuloDetalles_Load(object sender, EventArgs e)
        {
            try
            {
                    lCArticulo.Text = articuloAux.CodigoArticulo;
                    lNombre.Text = articuloAux.Nombre;
                    lDesc.Text = articuloAux.Descripcion;
                    lMarca.Text = articuloAux.Marca.Nombre;
                    lCategoria.Text = articuloAux.Categoria.Nombre;
                    lPrecio.Text ="$" + articuloAux.Precio.ToString();
                    RecargarImg(articuloAux.UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
