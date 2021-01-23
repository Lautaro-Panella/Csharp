using Ejercicio1.Conexion;
using Ejercicio1.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Controlador
{
    class EscritorGestor : DataBase
    {
        public List<Escritor> consultaEscritores()
        {
            List<Escritor> escritores = new List<Escritor>();
            LibroGestor lb = new LibroGestor();
            MySqlConnection conn = Conexion();
            MySqlDataReader reader = null;
            string consulta = "SELECT * FROM escritor";
            try
            {
                MySqlCommand comando = new MySqlCommand(consulta, conn);
                comando.Connection = conn;
                conn.Open();
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Escritor escritor = new Escritor();
                    escritor.id = Convert.ToInt32(reader.GetString(0));
                    escritor.apellido = reader.GetString(1);
                    escritor.nombre = reader.GetString(2);
                    escritor.dni = Convert.ToInt64(reader.GetString(3));
                    escritor.libros = lb.consultaLibros(escritor.id);
                    escritores.Add(escritor);
                }     
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return escritores;
        }
    }
}
