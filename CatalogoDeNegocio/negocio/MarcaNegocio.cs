using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            ConexionDatos nuevaConexion = new ConexionDatos();
                try
                {
                    nuevaConexion.setearConsulta("SELECT  Id, Descripcion FROM MARCAS");
                    nuevaConexion.ejecutarLectura();

                    while (nuevaConexion.Lector.Read())
                    {
                        //Creacion de lista, cargando los objetos de la misma directamente con el constructor de la clase.
                        lista.Add(new Marca((int)nuevaConexion.Lector["Id"], (String)nuevaConexion.Lector["Descripcion"]));
                    } 
                    return lista;
                 }
                 catch (Exception ex)
                 {
                        throw ex;
                 }
                 finally
                 {
                        nuevaConexion.cerrarConexion();
                }
        }


        public void agregar(Marca nMarca)
        {
            ConexionDatos conexion = new ConexionDatos();
            try
            {
                string valor = "VALUES (@Nombre)";
                conexion.setearConsulta("INSERT INTO MARCAS (Descripcion) " + valor);
                conexion.agregarParametro("@Nombre", nMarca.Nombre);
                conexion.ejectutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                conexion.cerrarConexion();
            }
        }

        public void eliminar(Marca mEliminar)
        {
            ConexionDatos conexion = new ConexionDatos();
            try
            {
                conexion.setearConsulta("Delete from MARCAS where Id= @Id");
                conexion.agregarParametro("@Id", mEliminar.CodigoMarca);
                conexion.ejectutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }

        public void modificar(Marca mModificar)
        {
            ConexionDatos conexion = new ConexionDatos();
            try
            {
                conexion.setearConsulta("UPDATE Marcas SET Descripcion = @mNombre where Id= @Id");
                conexion.agregarParametro("@Id", mModificar.CodigoMarca);
                conexion.agregarParametro("@mNombre", mModificar.Nombre);
                conexion.ejectutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }

    }
}
