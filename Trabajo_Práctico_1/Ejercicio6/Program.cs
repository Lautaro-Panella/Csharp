using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  
 * Programar un algoritmo recursivo que en cada recursión multiplique a si mismo un número ingresado por el usuario 
 * hasta que el valor resultante sea mayor 100.000.000. Valide que el número ingresado por el usuario sea mayor a 1.
 */

namespace Ejercicio6
{
    class Program
    {
        public static void Main(string[] args)
        {
            long numero;
            do
            {
                Console.WriteLine("Ingrese un número mayor a 1.");
                numero = Convert.ToInt64(Console.ReadLine());
            } while (numero <= 1);
            int contador = 0;
            Aumentar(numero, contador);
        }
        public static long Aumentar(long numero, int contador)
        {
            long resultado;
            if (numero > 100000000)
            {
                return numero;
            }
            else
            {
                resultado = numero * numero;
                contador++;
                Console.WriteLine(contador + " iteración => " + numero + " * " + numero + " = " + resultado);
                return Aumentar(resultado, contador);
            }
        }
    }
}
