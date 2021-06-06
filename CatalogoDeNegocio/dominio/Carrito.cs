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
            int posicionDeItem = ListaDeItems.FindIndex(x => x.IdArticulo == item.IdArticulo);
            if (posicionDeItem == -1) 
                ListaDeItems.Add(item);
            else ListaDeItems[posicionDeItem].sumarCantidad();

            //OTRA FORMA DE BUSCAR EL INDEX
            /*ListaDeItems.IndexOf(item);*/
        }

        public void descontarCantidadDeItemsDeLista(ItemCarrito item)
        {
            ListaDeItems[ListaDeItems.IndexOf(item)].restarCantidad();
        }

        public void eliminarItemDeLista(ItemCarrito item)
        {
            ListaDeItems.Remove(item);
        }
    }
}
