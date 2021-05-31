using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Marca
    {
        public String Nombre { get; set; }
        public int CodigoMarca { get; set; }

        public Marca(String nombre)
        {
            Nombre = nombre;
        }
        public Marca()
        {

        }

        public Marca(int codigo, String nombre)
        {
            Nombre = nombre;
            CodigoMarca = codigo;
        }

        public override string ToString()
        {
            return Nombre;
        }

        //Funciones
    }
}
