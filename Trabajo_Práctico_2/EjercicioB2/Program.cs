using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Cree una aplicación de Consola que permita por parte del usuario el ingreso por teclado de una cadena de texto, 
 * posteriormente el sistema deberá permitir el ingreso de una segunda cadena de texto. Finalmente el sistema deberá 
 * emitir el mensaje “ENCONTRADO” o “NO ENCONTRADO” según sean el caso de que la segunda cadena existe o no existe en 
 * la primera cadena. Valide que la cantidad de caracteres de la segunda cadena sea menor o igual a la cantidad de 
 * caracteres de la primera cadena.
 */

namespace EjercicioB2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una cadena:");
            string cadena1 = Console.ReadLine();
            string cadena2 = "";
            Console.WriteLine("Entrada Cadena 1: " + cadena1);
            do
            {
                Console.WriteLine("Ingrese otra cadena:");
                cadena2 = Console.ReadLine();
                Console.WriteLine("Entrada Cadena 2: " + cadena2);
                if (cadena1.Length == cadena2.Length || cadena1.Length < cadena2.Length)
                {
                    Console.WriteLine("Cadena 2 no puede ser mayor o igual a Cadena 1, ingrese nuevamente:");
                }
            } while (cadena1.Length == cadena2.Length || cadena1.Length < cadena2.Length);
            if (cadena1.Contains(cadena2))
            {
                Console.WriteLine("Resultado: ENCONTRADO.");
            }
            else
            {
                Console.WriteLine("Resultado: NO ENCONTRADO.");
            }
        }
    }
}
