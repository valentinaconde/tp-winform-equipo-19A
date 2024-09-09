using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;

namespace TPWinForm_equipo_19A
{
    class Negocio
    {
        public List<Articulo> Listar()
        {
            List<Articulo> list = new List<Articulo>();
            SqlConnection con = new SqlConnection();
            SqlCommand sqlCommand = new SqlCommand();
            SqlDataReader reader;

            try
            {
                con.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true ";
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.CommandText = "SELECT Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio FROM ARTICULOS";
                sqlCommand.Connection = con;

                con.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)reader["Id"];
                    aux.Codigo = reader["Codigo"].ToString();
                    aux.Nombre = reader["Nombre"].ToString();
                    aux.Descripcion = reader["Descripcion"].ToString();
                    aux.IdMarca = (int)reader["IdMarca"];
                    aux.IdCategoria = (int)reader["IdCategoria"];
                    aux.Precio = (decimal)reader["Precio"];

                    list.Add(aux);
                }

                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                return list; // Return the list even if an exception occurs  
            }
            finally
            {
                con.Close();
            }
        }
    }
}
