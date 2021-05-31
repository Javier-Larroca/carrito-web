using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            ConexionDatos nuevaConexion = new ConexionDatos();
            try
            {
                nuevaConexion.setearConsulta("SELECT  Id, Descripcion FROM CATEGORIAS");
                nuevaConexion.ejecutarLectura();

                while (nuevaConexion.Lector.Read())
                {
                    //Creacion de lista, cargando los objetos de la misma directamente con el constructor de la clase.
                    lista.Add(new Categoria((int)nuevaConexion.Lector["Id"], (String)nuevaConexion.Lector["Descripcion"]));
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

        public void agregar(Categoria nCategoria)
        {
            ConexionDatos conexion = new ConexionDatos();
            try
            {
                string valor = "VALUES (@Nombre)";
                conexion.setearConsulta("INSERT INTO CATEGORIAS (Descripcion) " + valor);
                conexion.agregarParametro("@Nombre", nCategoria.Nombre);
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

        public void eliminar(Categoria cEliminar)
        {
            ConexionDatos conexion = new ConexionDatos();
            try
            {
                conexion.setearConsulta("Delete from CATEGORIAS where Id= @Id");
                conexion.agregarParametro("@Id", cEliminar.CodigoCategoria);
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

        public void modificar(Categoria cModificar)
        {
            ConexionDatos conexion = new ConexionDatos();
            try
            {
                conexion.setearConsulta("UPDATE CATEGORIAS SET Descripcion = @mNombre where Id= @Id");
                conexion.agregarParametro("@Id", cModificar.CodigoCategoria);
                conexion.agregarParametro("@mNombre", cModificar.Nombre);
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
