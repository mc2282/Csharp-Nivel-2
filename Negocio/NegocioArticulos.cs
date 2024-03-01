using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;

namespace Negocio
{
    public class NegocioArticulos
    {
        /** LISTAR ARTICULOS **/

        public List<Articulo> listarArticulos()
        {
            // se crea la lista de articulos para listar.
            List<Articulo> listaArticulos = new List<Articulo>();

            //se iniciliza la conexion.
            AccesoDatos datos = new AccesoDatos();

            //se guarda en una variable la consulta a la base de datos.
            string consulta = "SELECT a.Id as 'IdArticulo', a.Codigo, a.Nombre, a.Descripcion as 'Descripcion', c.Id as 'IdCategoria', c.Descripcion as 'Categoria', m.Id as 'IdMarca', m.Descripcion as 'Marca', a.ImagenUrl, a.Precio  FROM articulos a INNER JOIN Marcas m ON m.Id = a.IdMarca INNER JOIN Categorias c ON c.Id = a.IdCategoria";

            try
            {
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Id = datos.Lector.GetInt32(0);
                    articulo.Codigo = (string)datos.Lector["Codigo"];
                    articulo.Nombre = (string)datos.Lector["Nombre"];
                    articulo.Descripcion = (string)datos.Lector["Descripcion"];

                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    articulo.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    articulo.Marca = new Marca();
                    articulo.Marca.Id = (int)datos.Lector["IdMarca"];
                    articulo.Marca.Descripcion = (string)datos.Lector["Marca"];

                    articulo.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    articulo.Precio = datos.Lector.GetDecimal(9);

                    listaArticulos.Add(articulo);
                }
                return listaArticulos;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                datos.desconectar_DB();
            }
        }

        /** AGREGAR ARTICULO **/

        public void agregarArticulo(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, nombre, descripcion, ImagenUrl, Precio, IdCategoria, IdMarca) VALUES ('" + articulo.Codigo + "', '"  + articulo.Nombre +"', '"+ articulo.Descripcion + "', '" + articulo.ImagenUrl + "', " + articulo.Precio + ", @IdCategoria, @IdMarca)");
                datos.setearParametro("IdCategoria", articulo.Categoria.Id);
                datos.setearParametro("@IdMarca", articulo.Marca.Id);
                datos.ejecutarLectura();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.desconectar_DB();
            }
        }

        /** ELIMINAR ARTICULO **/

        public void eliminarArticulo(Articulo artSeleccionado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("DELETE FROM ARTICULOS WHERE Id = @Id");
                datos.setearParametro("Id", artSeleccionado.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.desconectar_DB();
            }
        }

        /** MODIFICAR ARTICULO **/

        public void modificarArticulo(Articulo artSeleccionado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE ARTICULOS SET Codigo = '" + artSeleccionado.Codigo + "', nombre= '" + artSeleccionado.Nombre + "', descripcion = '" + artSeleccionado.Descripcion + "', ImagenUrl = '" + artSeleccionado.ImagenUrl + "', Precio = '" + artSeleccionado.Precio + "', IdCategoria = @IdCategoria, IdMarca = @IdMarca WHERE id = "+artSeleccionado.Id+";");
                datos.setearParametro("IdCategoria", artSeleccionado.Categoria.Id);
                datos.setearParametro("@IdMarca", artSeleccionado.Marca.Id);
                datos.ejecutarLectura();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.desconectar_DB();
            }
        }

        /** FILTRAR ARTICULO **/

        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> listaArticulos = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "SELECT a.Id as 'IdArticulo', a.Codigo, a.Nombre, a.Descripcion as 'Descripcion', c.Id as 'IdCategoria', c.Descripcion as 'Categoria', m.Id as 'IdMarca', m.Descripcion as 'Marca', a.ImagenUrl, a.Precio FROM articulos a INNER JOIN Marcas m ON m.Id = a.IdMarca INNER JOIN Categorias c ON c.Id = a.IdCategoria And ";
                if (campo == "Precio")
                {
                    //Precio
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "a.precio > " + filtro + ";";
                            break;
                        case "Menor a":
                            consulta += "a.precio < " + filtro + ";";
                            break;
                        default:
                            consulta += "a.precio = " + filtro + ";";
                            break;
                    }
                }
                //Nombre
                else if (campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "a.Nombre like '" + filtro + "%';";
                            break;
                        case "Termina con":
                            consulta += "a.Nombre like '%" + filtro + "';";
                            break;
                        default:
                            consulta += "a.Nombre like '%" + filtro + "%';";
                            break;
                    }
                }
                //Codigo
                else if (campo == "Codigo")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "a.Codigo like '" + filtro + "%';";
                            break;
                        case "Termina con":
                            consulta += "a.Codigo like '%" + filtro + "';";
                            break;
                        default:
                            consulta += "a.Codigo like '%" + filtro + "%';";
                            break;
                    }
                }
                //Descripcion
                else if (campo == "Descripcion")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "a.Descripcion like '" + filtro + "%';";
                            break;
                        case "Termina con":
                            consulta += "a.Descripcion like '%" + filtro + "';";
                            break;
                        default:
                            consulta += "a.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }
                //Marca
                else if (campo == "Marca")
                {

                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "m.Descripcion like '" + filtro + "%';";
                            break;
                        case "Termina con":
                            consulta += "m.Descripcion like '%" + filtro + "';";
                            break;
                        default:
                            consulta += "m.Descripcion like '%" + filtro + "%';";
                            break;
                    }
                }
                //Categoria
                else 
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "c.Descripcion like '" + filtro + "%';";
                            break;
                        case "Termina con":
                            consulta += "c.Descripcion like '%" + filtro + "';";
                            break;
                        default:
                            consulta += "c.Descripcion like '%" + filtro + "%';";
                            break;
                    }
                }
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Id = datos.Lector.GetInt32(0);
                    articulo.Codigo = (string)datos.Lector["Codigo"];
                    articulo.Nombre = (string)datos.Lector["Nombre"];
                    articulo.Descripcion = (string)datos.Lector["Descripcion"];

                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    articulo.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    articulo.Marca = new Marca();
                    articulo.Marca.Id = (int)datos.Lector["IdMarca"];
                    articulo.Marca.Descripcion = (string)datos.Lector["Marca"];

                    articulo.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    articulo.Precio = datos.Lector.GetDecimal(9);

                    listaArticulos.Add(articulo);
                }
                return listaArticulos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

