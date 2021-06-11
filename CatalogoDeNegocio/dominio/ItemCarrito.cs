using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class ItemCarrito
    {
        public int Cantidad { get; set; }
        public int IdArticulo { get; set; }
        public String NombreArticulo { get; set; }
        public String UrlImagenArticulo { get; set; }
        public decimal Precio { get; set; }

        public ItemCarrito(int idArticulo, String nombre, decimal precio, String UrlImagen)
        {
            IdArticulo = idArticulo;
            Cantidad = 1;
            NombreArticulo = nombre;
            Precio = (Cantidad *precio);
            UrlImagenArticulo = UrlImagen;
        }

        public ItemCarrito()
        {
            Cantidad = 1;
        }

        public void sumarCantidad()
        {
            Cantidad++;
            Precio = (Cantidad * Precio);
        }

        public void restarCantidad()
        {
            if (Cantidad != 0) Cantidad--;
            Precio = (Cantidad * Precio);
        }

        public override string ToString()
        {
            return NombreArticulo;
        }
    }
}
