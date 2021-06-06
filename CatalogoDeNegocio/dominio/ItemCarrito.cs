﻿using System;
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
        public decimal Precio { get; set; }

        public ItemCarrito(int idArticulo, String nombre, decimal precio)
        {
            IdArticulo = idArticulo;
            Cantidad = 1;
            NombreArticulo = nombre;
            Precio = (Cantidad *precio);
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
        }

        public override string ToString()
        {
            return NombreArticulo;
        }
    }
}