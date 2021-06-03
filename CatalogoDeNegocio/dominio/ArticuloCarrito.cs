using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    class ArticuloCarrito:Articulo
    {
        public int Cantidad { get; set; }


        public ArticuloCarrito(String codigo, String nombre, String descripcion, Marca marcacb, Categoria cat, decimal precio, String imagen)
        {
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

        public void sumar()
        {
            Cantidad++;            
        }

        public void restar()
        {
            Cantidad--;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
