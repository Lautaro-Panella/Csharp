using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  
 * Explique y ejemplifique los métodos para el manejo de cadenas en C#, Lenght, Contains, IndexOf, Remove, Replace, 
 * Substring, Append, ToUpper, ToLower.
 */

namespace Ejercicio7
{
    class Program
    {
        public static void Main(string[] args)
        {
            string cadena = "Cadena de ejemplo.";
            string numero = "1234";
            Console.WriteLine("Para los ejemplos usamos: Cadena de ejemplo. y 1234");
            // Método Lenght: Devuelve el largo de la cadena como un numero entero.
            Console.WriteLine("El número " + numero + " tiene " + numero.Length + " cifras.");

            // Método Contains: Analiza si una cadena está contenida en otra, devolviendo true o false.
            Console.WriteLine("Ingrese la cadena a verificar:");
            string ingreso = Console.ReadLine();
            if (cadena.Contains(ingreso))
            {
                Console.WriteLine("Se encontró coincidencia en Cadena de ejemplo.");
            }
            else
            {
                Console.WriteLine("No se encontró coincidencia.");
            }

            // Método IndexOf: Devuelve el índice del caracter buscado, si no existe devuelve -1.
            Console.WriteLine("Ingrese el caracter a buscar.");
            ingreso = Console.ReadLine();
            if (cadena.IndexOf(ingreso) > -1)
            {
                Console.WriteLine("Se encontró el caracter en la posición " + (cadena.IndexOf(ingreso) + 1) + " en: Cadena de ejemplo.");
            }
            else
            {
                Console.WriteLine("No se encontró coincidencia.");
            }

            // Método Remove: Elimina parte de la cadena recibiendo los indices de principio y fin del sector a borrar.
            string cadena1 = cadena.Remove(4, 6);
            Console.WriteLine("Se eliminó parte de la cadena, indices del 4 al 6: " + cadena1);

            // Método Replace: Reemplaza un caracter determinado en todas sus posiciones por el nuevo que se indique.
            string cadena2 = cadena.Replace('a', 'e');
            Console.WriteLine("Se cambiaron las letras a por e en la cadena: " + cadena2);

            // Método Substring: Trocea una cadena desde un indice determinado hasta el final de la misma o hasta un segundo índice.
            string cadena3 = cadena.Substring(8);
            Console.WriteLine("Se trozó la cadena desde la posición 8 en adelante: " + cadena3);

            // Método Append: Une cadenas, las concatena.
            StringBuilder cadena4 = new StringBuilder();
            cadena4.Append(cadena);
            cadena4.Append(numero);
            Console.WriteLine("La unión de cadenas es: " + cadena4);

            // Método ToUpper: Convierte toda la cadena a mayúsculas.
            Console.WriteLine("La cadena en mayúsculas: " + cadena.ToUpper());

            // Método ToLower: Convierte toda la cadena a minúsculas.
            Console.WriteLine("La cadena en minúsculas: " + cadena.ToLower());
        }
    }
}
