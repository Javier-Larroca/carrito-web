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
        public decimal importeTotal { get; set; }

        public int cantidadItems { get; set; }

        public Carrito()
        {
            ListaDeItems = new List<ItemCarrito>();
            importeTotal = 0;
            cantidadItems = 0;
        }

        public void calcularCantidadItems()
        {
            cantidadItems = 0;
            foreach (ItemCarrito item in ListaDeItems)
            {
                cantidadItems += item.Cantidad;
            }
        }

        public void sumarImporteTotal()
        {
            if (ListaDeItems.Any())
            {
                importeTotal = 0;
                foreach (ItemCarrito item in ListaDeItems)
                {
                    importeTotal += item.PrecioTotal;
                }
            }
            else
            {
                importeTotal = 0;
            }
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
            int pos = posicionDeItem(idArticuloADescontar);
            ListaDeItems[pos].restarCantidad();
            if (ListaDeItems[pos].Cantidad == 0) 
                eliminarItemDeLista(idArticuloADescontar);
        }

        public void aumentarCantidadDeItemsDeLista(int idArticuloAAumentar)
        {
            ListaDeItems[posicionDeItem(idArticuloAAumentar)].sumarCantidad();
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
