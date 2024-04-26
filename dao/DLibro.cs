using SistemaBookShare.entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBookShare.dao
{
    internal class DLibro
    {
        private string connectionString;
        public DLibro()
        {
            connectionString = ConfigurationManager.ConnectionStrings["SistemaBookShare.Properties.Settings.BOOKSHAREConnectionString"].ConnectionString;
        }

        public bool guardarLibro(entidades.Libro libro)
        {
            bool resultado = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    //Se abre la conexion
                    connection.Open();
                    //Se crea el comando
                    string query = "INSERT INTO Tbl_Libro (titulo, autor, stock, stockMinimo, isbn, anioPublicacion, editorial, genero, estado) VALUES (@titulo, @autor, @stock, @stockMinimo, @isbn, @anioPublicacion, @editorial, @genero, @estado)";
                    using (SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@titulo", libro.titulo);
                        command.Parameters.AddWithValue("@autor", libro.autor);
                        command.Parameters.AddWithValue("@stock", libro.Stock);
                        command.Parameters.AddWithValue("@stockMinimo", libro.StockMinimo);
                        command.Parameters.AddWithValue("@isbn", libro.Isbn);
                        command.Parameters.AddWithValue("@anioPublicacion", libro.anioPublicacion);
                        command.Parameters.AddWithValue("@editorial", libro.editorial);
                        command.Parameters.AddWithValue("@genero", libro.genero);
                        command.Parameters.AddWithValue("@estado", libro.estado);


                        //Se ejecuta el comando
                        if (command.ExecuteNonQuery() > 0)
                        {
                            resultado = true;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al guardar el libro: " + ex.Message);
            
            }

            return resultado;
        } 
        
        //listar libros
        public DataSet listarLibros()
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Tbl_Libro where estado = 1";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(ds);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar los libros: " + ex.Message);
            }
            return ds;
        }

        //eliminar logicamente el libro
        public bool eliminarLibro(int id)
        {
            bool resultado = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Tbl_Libro SET estado = 0 WHERE idLibro = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        if (command.ExecuteNonQuery() > 0)
                        {
                            resultado = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el libro: " + ex.Message);
            }
            return resultado;
        }

        public bool actualizarLibro(Libro libro)
        {
            bool resultado = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Tbl_Libro SET titulo = @titulo, autor = @autor, stock = @stock, stockMinimo = @stockMinimo, isbn = @isbn, anioPublicacion = @anioPublicacion, editorial = @editorial, genero = @genero WHERE idLibro = @idLibro";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@titulo", libro.titulo);
                        command.Parameters.AddWithValue("@autor", libro.autor);
                        command.Parameters.AddWithValue("@stock", libro.Stock);
                        command.Parameters.AddWithValue("@stockMinimo", libro.StockMinimo);
                        command.Parameters.AddWithValue("@isbn", libro.Isbn);
                        command.Parameters.AddWithValue("@anioPublicacion", libro.anioPublicacion);
                        command.Parameters.AddWithValue("@editorial", libro.editorial);
                        command.Parameters.AddWithValue("@genero", libro.genero);
                        command.Parameters.AddWithValue("@idLibro", libro.idLibro);
                        if (command.ExecuteNonQuery() > 0)
                        {
                            resultado = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el libro: " + ex.Message);
            }
            return resultado;
        }

     
    }

}
