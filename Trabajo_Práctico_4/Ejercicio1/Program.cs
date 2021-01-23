using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = 0;
            string data = null;
            int nroRegistros = DameNroRegistros();
            Console.WriteLine("Número de registros a escribir: " + nroRegistros);
            MySqlConnection conn = Conexion();
            MySqlDataReader reader = null;
            StreamWriter sw = new StreamWriter(@"C:\articulos.txt");
            Console.Write("Cargando datos al archivo.txt");
            
            do
            {
                try
                {
                    string consulta = "SELECT * FROM articulo LIMIT " + limit + " , " + 50;
                    MySqlCommand comando = new MySqlCommand(consulta);
                    comando.Connection = conn;
                    conn.Open();
                    reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        data += reader.GetString(0) + "\t";
                        data += reader.GetString(1) + "\t";
                        data += reader.GetString(2) + "\t";
                        data += reader.GetString(3) + "\t";
                        data += reader.GetString(4) + "\t";
                        data += reader.GetString(5);
                        sw.Write(data);
                        sw.Write("\n");
                        data = "";
                    }
                    // sw.WriteLine("----------------------------------------------------------------------------------------------------------");
                    limit += 50;
                    Console.Write(" . ");
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally 
                {
                    conn.Close();
                }
            } while (limit <= nroRegistros);
            sw.Close();
        } 

        public static MySqlConnection Conexion() 
        {
            string cadenaConexion = "Database= utn; Data Source= localhost; Port= 3306; User Id= root; Password= 1234";
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
        public static int DameNroRegistros()
        {
            string consulta = "SELECT COUNT(*) FROM articulo";
            int registros = 0;
            try
            {
                MySqlConnection conn = Conexion();
                MySqlCommand comando = new MySqlCommand(consulta);
                comando.Connection = conn;
                conn.Open();
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    registros = Convert.ToInt32(reader.GetString(0));
                }
                return registros;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return 0;
            }    
        }
    }   
}