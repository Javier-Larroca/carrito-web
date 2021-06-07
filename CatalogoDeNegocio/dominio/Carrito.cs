using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Carrito
    {
        public List <ItemCarrito> ListaDeItems{ get; set; }

        public Carrito()
        {
            ListaDeItems = new List<ItemCarrito>();
        }
        public void agregarItemDeLista(ItemCarrito item)
        {
            int pos = posicionDeItem(item.IdArticulo);
            if (pos == -1) 
                ListaDeItems.Add(item);
            else ListaDeItems[pos].sumarCantidad();
        }

        public void descontarCantidadDeItemsDeLista(int idArticuloADescontar)
        {
            ListaDeItems[posicionDeItem(idArticuloADescontar)].restarCantidad();
        }

        public bool eliminarItemDeLista(int idArticuloAEliminar)
        {
            if (ListaDeItems.Remove(ListaDeItems[posicionDeItem(idArticuloAEliminar)]))
                return true;
            else return false;
        }

        public int posicionDeItem(int idArticuloABuscar)
        {
            int posicion = ListaDeItems.FindIndex(x => x.IdArticulo == idArticuloABuscar);
            return posicion;
        }
    }
}
