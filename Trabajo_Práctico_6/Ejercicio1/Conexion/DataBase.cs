using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Conexion
{
    class DataBase
    {
        public static MySqlConnection Conexion()
        {
            string cadenaConexion = "Database= escribir_json; Data Source= localhost; Port= 3306; User Id= root; Password= 1234";
            try
            {
                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
                return conexionBD;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
