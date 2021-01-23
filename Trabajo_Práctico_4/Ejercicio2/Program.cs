using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables:
            string linea;
            int contador = 1;
            List<String> lista = new List<string>();

            StreamReader sr = new StreamReader(@"C:\articulos.txt");
            MySqlConnection conn = Conexion();

            Console.Write("Insertando datos en articulo_copy  .  .  . ");

            while ((linea = sr.ReadLine()) != null)
            {
                lista.Add(linea);
                contador++;
                if (contador == 50)
                {
                    Console.Write(" . ");
                    InsertaOActualizaLineas(lista, conn);
                    lista.Clear();
                    contador = 0;
                }
            }    
            InsertaOActualizaLineas(lista, conn);
            sr.Close();
        }

        public static void InsertaOActualizaLineas(List<string> lista, MySqlConnection conn) 
        {
            foreach (string s in lista)
            {
                string[] arreglo = s.Split('\t');
                int id = Convert.ToInt32(arreglo[0]);
                string consulta;
                conn.Open();
                MySqlCommand comando = conn.CreateCommand();
                MySqlTransaction transaccion = conn.BeginTransaction();
                comando.Connection = conn;
                comando.Transaction = transaccion;
                if (IdRepetido(id, conn))
                {
                    consulta = "UPDATE articulo_copy SET fechaAlta= @fechaAlta, codigo= @codigo, denominacion= @denominacion, precio= @precio, publicado= @publicado WHERE id= @id";
                }
                else
                {
                    consulta = "INSERT INTO articulo_copy VALUES (@id, @fechaAlta, @codigo, @denominacion, @precio, @publicado)";
                }
                try
                {
                    comando.Parameters.AddWithValue("@id", Convert.ToInt32(arreglo[0]));
                    comando.Parameters.AddWithValue("@fechaAlta", Convert.ToDateTime(arreglo[1]));
                    comando.Parameters.AddWithValue("@codigo", arreglo[2]);
                    comando.Parameters.AddWithValue("@denominacion", arreglo[3]);
                    comando.Parameters.AddWithValue("@precio", Convert.ToDouble(arreglo[4]));
                    comando.Parameters.AddWithValue("@publicado", arreglo[5]);
                    comando.CommandText = consulta;
                    comando.ExecuteNonQuery();
                    transaccion.Commit();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    try
                    {
                        transaccion.Rollback();
                    }
                    catch (MySqlException e)
                    {
                        if (transaccion.Connection != null)
                        {
                            Console.WriteLine("Exception de tipo " + e.GetType() +
                            " al ejecutar el roll back de la transaction.");
                        }
                    }
                    Console.WriteLine("Exception de tipo " + ex.GetType() +
                    " mientras se insertaban los datos.");  
                }
                finally
                {
                    conn.Close();
                }
            }    
        }

        public static bool IdRepetido(int id, MySqlConnection conn)
        {
            string consulta = "SELECT id FROM articulo_copy WHERE id = '" + id + "'";
            MySqlCommand comando = new MySqlCommand(consulta, conn);
            int num = Convert.ToInt32(comando.ExecuteScalar());           
            if (num > 0)
            {
                return true;
            }
            else 
            {
                return false;
            }               
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
    }
}

