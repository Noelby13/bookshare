using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBookShare.dao
{
    internal class DEstudiante
    {
        private string connectionString;

        public DEstudiante()
        {
            connectionString = ConfigurationManager.ConnectionStrings["SistemaBookShare.Properties.Settings.BOOKSHAREConnectionString"].ConnectionString;

        }

        //listar estudiantes


        public DataSet ListarEstudiante()
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Tbl_Estudiante";
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
    }
}
