using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseFinal
{
    public class Model
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string compania { get; set; }
        public int anio_lanzamiento { get; set; }
        public int generacion { get; set; }

        private string connectionString = "Server=localhost;Database=db_consolas;Uid=root;Pwd=2003";

        public bool ProbarConexion()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public DataTable LeerTabla()
        {
            DataTable models = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM catalogo_consolas";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(models);
                    }
                }
            }

            

            return models;
        }

        public DataTable CargarRegistro(int id)
        {
            DataTable models = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "Select * from catalogo_consolas where id_consola = @id";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(models);
                    }
                }
            }
            return models;
        }
    }
}
