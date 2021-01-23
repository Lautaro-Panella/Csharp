using Newtonsoft.Json;
using Ejercicio1.Controlador;
using Ejercicio1.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Principal
    {
        static void Main(string[] args)
        {
            EscritorGestor eg = new EscritorGestor();
            List<Escritor> datos = eg.consultaEscritores();
            string path = @"C:\Users\hp\source\repos\Trabajo_Práctico_6\bookstore.json";
            EscribirJson(datos, path);
            Console.WriteLine("Carga exitosa!");
        }
        public static void EscribirJson(List<Escritor> escritores, string path)
        {
            string archivoJson = JsonConvert.SerializeObject(escritores.ToArray(), Formatting.Indented);
            File.WriteAllText(path, archivoJson);
        }
    }
}
