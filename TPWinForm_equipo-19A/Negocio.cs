using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;
using Dominio;

namespace TPWinForm_equipo_19A
{
    public class Negocio
    {
        public List<Articulo> Listar()
        {
            List<Articulo> list = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT A.Id, Codigo, Nombre, A.Descripcion, Precio, C.Descripcion Categoria, M.Descripcion Marca, I.ImagenUrl urlImagen FROM ARTICULOS A, CATEGORIAS C, MARCAS M, IMAGENES I WHERE A.IdMarca = M.Id  AND A.IdCategoria = C.Id AND A.Id = I.IdArticulo");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = datos.Lector["Codigo"].ToString();
                    aux.Nombre = datos.Lector["Nombre"].ToString();
                    aux.Descripcion = datos.Lector["Descripcion"].ToString();
                    aux.marca = new Marca();
                    aux.marca.Nombre = datos.Lector["Marca"].ToString();
                    aux.categoria = new Categoria();
                    aux.categoria.Descripcion = datos.Lector["Categoria"].ToString();
                    //aux.IdCategoria = (int)datos.Lector["IdCategoria"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.UrlImagen = datos.Lector["urlImagen"].ToString();

                    list.Add(aux);
                }

                return list;
            }
            catch (Exception ex)
            {
                throw ex;
             
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void agregar(Articulo nuevo)
        {
            try
            {
         

                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio); SELECT SCOPE_IDENTITY();");
                datos.setearParametro("@Codigo", nuevo.Codigo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@IdMarca", nuevo.marca.Id);
                datos.setearParametro("@IdCategoria", nuevo.categoria.Id);
                datos.setearParametro("@Precio", nuevo.Precio);

           
                datos.ejecutarAccion();

                datos.abrirConexion();
                int idArticulo = Convert.ToInt32(datos.Comando.ExecuteScalar());
                datos.cerrarConexion();

                datos.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl)");
                datos.setearParametro("@IdArticulo", idArticulo);
                datos.setearParametro("@ImagenUrl", nuevo.UrlImagen);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void modificar(Articulo modificar)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            }
        }

        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from ARTICULOS where id = @id");
                datos.setearParametro("@id",id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            }

        }
    }



}
