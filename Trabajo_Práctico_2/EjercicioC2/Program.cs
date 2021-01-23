using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Codifique un programa que permita la carga de una cadena de números separados por coma. Al finalizar la carga ejecute 
 * la función Split de C# para separar la cadena y formar un arreglo de elementos. Recorra el arreglo de valores numéricos
 * y obtenga la suma total de los valores. Muestre el resultado por consola o pantalla.
 */

namespace EjercicioC2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese números separados por una coma, luego serán sumados:");
            string cadena = Console.ReadLine();
            string[] arreglo = cadena.Split(',');
            int resultado = 0;
            for (int i = 0; i < arreglo.Length; i++)
            {
                resultado += Convert.ToInt32(arreglo[i]);
            }
            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}
