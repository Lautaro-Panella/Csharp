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
    class LibroGestor : DataBase
    {
        public List<Libro> consultaLibros(int idEscritor)
        {
            List<Libro> libros = new List<Libro>();
            MySqlConnection conn = Conexion();
            MySqlDataReader reader = null;
            string consulta = "SELECT * FROM libro WHERE idEscritor = " + idEscritor;
            try
            {
                MySqlCommand comando = new MySqlCommand(consulta, conn);
                comando.Connection = conn;
                conn.Open();
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Libro libro = new Libro();
                    libro.nombre = reader.GetString(1);
                    libro.anioPublicacion = Convert.ToInt32(reader.GetString(2));
                    libro.editorial = reader.GetString(3);
                    libros.Add(libro);
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
            return libros;
        }
    }
}
