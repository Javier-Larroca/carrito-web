using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    class Carrito
    {
        public List <ArticuloCarrito> ListaArticulos{ get; set; }
        
        public void agregarArticuloDeLista(ArticuloCarrito articulo)
        {
            if (!existeArticuloEnLista(articulo.Id))
            {
                ListaArticulos.Add(articulo);
            }
            else
            {
                //Retornar posición del articulo duplicado y sumar.
            }
        }

        public bool existeArticuloEnLista(int id)
        {
            foreach (ArticuloCarrito item in ListaArticulos)
            {
                if (item.Id == id)
                {
                    //Si encuentra el articulo, sumamos la cantidad -> Esto va arriba
                    item.sumar();
                    return true;
                }
            }
            return false;
        }

        public void eliminarArticuloDeLista(ArticuloCarrito articulo)
        {
            //Buscar el indice del articulo a eliminar y lo eliminamos
            ListaArticulos.Remove(articulo);
        }
    }
}
