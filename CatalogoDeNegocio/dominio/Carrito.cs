using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Carrito
    {
        public List <ArticuloCarrito> ListaArticulos{ get; set; }
        
        public void agregarArticuloDeLista(ArticuloCarrito articulo)
        {
            int posicionDeArticulo = ListaArticulos.IndexOf(articulo);
            if (posicionDeArticulo == -1) ListaArticulos.Add(articulo);
            else ListaArticulos[posicionDeArticulo].sumarCantidad();

            //OTRA FORMA DE BUSCAR EL INDEX
            //ListaArticulos.FindIndex(item => item.Id == articulo.Id);
        }
        
        public void descontarCantidadDeArticulosDeLista(ArticuloCarrito articulo)
        {
            ListaArticulos[ListaArticulos.IndexOf(articulo)].restarCantidad();
        }

        public void eliminarArticuloDeLista(ArticuloCarrito articulo)
        {
            ListaArticulos.Remove(articulo);
        }
    }
}
