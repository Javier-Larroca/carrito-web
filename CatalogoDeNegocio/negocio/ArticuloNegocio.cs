using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        private ConexionDatos conexion = new ConexionDatos();
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            ConexionDatos conexion = new ConexionDatos();
            try
            {
                conexion.setearConsulta("Select Ar.Id, Ar.Codigo, Ar.Nombre, Ar.Descripcion, Mar.Descripcion as Marca,  Cat.Descripcion as Categoria, Ar.ImagenUrl, Ar.Precio " +
                    "From ARTICULOS as Ar " +
                    "LEFT Join MARCAS as Mar on Ar.IdMarca=Mar.Id " +
                    "LEFT Join CATEGORIAS as Cat on Ar.IdCategoria=Cat.Id");
                conexion.ejecutarLectura();

                while (conexion.Lector.Read())
                {
                    Articulo backup = new Articulo();

                    //Carga de objeto utilizando un objeto auxiliar/backup
                    backup.Id = (int)conexion.Lector["Id"];
                    backup.CodigoArticulo = (String)conexion.Lector["Codigo"];
                    backup.Nombre = (String)conexion.Lector["Nombre"];
                    backup.Descripcion = (String)conexion.Lector["Descripcion"];
                    //Agrego IF para validar en caso de que no tenga marca, le asignamos "Sin marca asociada"
                    if (conexion.Lector["Marca"] == DBNull.Value)
                    {
                        backup.Marca = new Marca("Sin marca");
                    }
                    else
                    {
                        backup.Marca = new Marca((String)conexion.Lector["Marca"]);
                    }
                    if (conexion.Lector["Categoria"] == DBNull.Value)
                    {
                        backup.Categoria = new Categoria("Sin categoria");
                    } else
                    {
                        backup.Categoria = new Categoria((String)conexion.Lector["Categoria"]);
                    }
                    backup.Precio = (decimal)conexion.Lector["Precio"];
                    backup.UrlImagen=(String)conexion.Lector["ImagenUrl"];

                    lista.Add(backup);
                }
                return lista;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }

        public bool agregar(Articulo nuevo)
        {
            bool agrego;
            try {
                string valores = "VALUES (@codigoArticulo, @nombre, @descripcion, @marca, @idcategoria, @urlImagen, @precio)";
                conexion.setearConsulta("INSERT INTO Articulos (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) " + valores);
                conexion.agregarParametro("@codigoArticulo", nuevo.CodigoArticulo);
                conexion.agregarParametro("@nombre", nuevo.Nombre);
                conexion.agregarParametro("@descripcion", nuevo.Descripcion);
                conexion.agregarParametro("@marca", nuevo.Marca.CodigoMarca);
                conexion.agregarParametro("@idcategoria", nuevo.Categoria.CodigoCategoria);
                conexion.agregarParametro("@urlImagen", nuevo.UrlImagen);
                conexion.agregarParametro("@precio", nuevo.Precio);
                conexion.ejectutarAccion();
                agrego = true;

            }
            catch(Exception ex)
            {
                agrego = false;
                throw ex;
            }
            finally
            {

                conexion.cerrarConexion();
                
            }
            return agrego;
        } 

        public bool modificar(Articulo modificador)
        {
            bool modifico;
            try
            {
                conexion.setearConsulta("UPDATE Articulos " +
                    "SET Codigo = @codigoArticulo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @marca, IdCategoria = @idcategoria, ImagenUrl = @urlImagen, Precio = @precio " +
                    "WHERE Id = @id");
                conexion.agregarParametro("@id", modificador.Id);
                conexion.agregarParametro("@codigoArticulo", modificador.CodigoArticulo);
                conexion.agregarParametro("@nombre", modificador.Nombre);
                conexion.agregarParametro("@descripcion", modificador.Descripcion);
                conexion.agregarParametro("@marca", modificador.Marca.CodigoMarca);
                conexion.agregarParametro("@idcategoria", modificador.Categoria.CodigoCategoria);
                conexion.agregarParametro("@urlImagen", modificador.UrlImagen);
                conexion.agregarParametro("@precio", modificador.Precio);
                conexion.ejectutarAccion();
                modifico = true;

            }
            catch (Exception ex)
            {
                modifico = false;
                throw ex;
            }
            finally
            {

                conexion.cerrarConexion();

            }
            return modifico;

        }

        public bool eliminarArticulo(Articulo eliminador)
        {
            bool elimino;
            try
            {
                conexion.setearConsulta("DELETE FROM ARTICULOS WHERE Id = @id");
                conexion.agregarParametro("@id", eliminador.Id);
                conexion.ejectutarAccion();
                elimino = true;

            }
            catch (Exception ex)
            {
                elimino = false;
                throw ex;
            }
            finally
            {

                conexion.cerrarConexion();

            }
            return elimino;

        }

        public void modificarValoresArticulo(Articulo articuloOriginal, String codigo, String nombre, String descripcion, Marca marcacb, Categoria cat, decimal precio, String imagen)
        {
           articuloOriginal.CodigoArticulo = codigo;
           articuloOriginal.Nombre = nombre;
           articuloOriginal.Descripcion = descripcion;
           articuloOriginal.Precio = precio;
           articuloOriginal.UrlImagen = imagen;
           articuloOriginal.Marca = new Marca(marcacb.CodigoMarca, marcacb.Nombre);
           articuloOriginal.Categoria = new Categoria(cat.CodigoCategoria, cat.Nombre);

        }
    }

}
