using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class ArticuloCarrito:Articulo
    {
        public int Cantidad { get; set; }


        public ArticuloCarrito(int id, String codigo, String nombre, String descripcion, Marca marcacb, Categoria cat, decimal precio, String imagen)
        {
            Id = id;
            CodigoArticulo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            UrlImagen = imagen;
            Marca = new Marca(marcacb.CodigoMarca, marcacb.Nombre);
            Categoria = new Categoria(cat.CodigoCategoria, cat.Nombre);
            Cantidad = 1;
        }

        public ArticuloCarrito()
        {
            Cantidad = 1;
        }

        public void sumarCantidad()
        {
            Cantidad++;            
        }

        public void restarCantidad()
        {
            Cantidad--;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
