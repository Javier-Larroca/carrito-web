using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public int Id{ get; set; }
        public String CodigoArticulo { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public decimal Precio { get; set; }
        public String UrlImagen { get; set; }

        //Recibo marca y categoria de combo box en Agregar Articulo
        public Articulo(String codigo, String nombre, String descripcion, Marca marcacb, Categoria cat, decimal precio, String imagen)
        {
            CodigoArticulo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            UrlImagen = imagen;
            Marca = new Marca(marcacb.CodigoMarca, marcacb.Nombre);
            Categoria = new Categoria(cat.CodigoCategoria, cat.Nombre);
        }
        public Articulo()
        {
            Id = 0;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
