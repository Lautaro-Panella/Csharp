using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  
 * Codifique un programa de consola en C# que permita realizar las siguientes acciones:
 * Generar un número aleatorio entre 0 y 100, para ello use la función random de C#. Una vez generado el número 
 * codifique la lógica necesaria para encontrar el número aleatorio ayudando al usuario informando al mismo si el 
 * número ingresado es mayor o menor al número aleatorio buscado. Una vez encontrado el número muestre la cantidad 
 * de intentos necesarios para lograrlo.
 */

namespace Ejercicio2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int numRandom = aleatorio.Next(0, 101);
            int numIngresado;
            int contador = 0;
            do
            {
                Console.WriteLine("Ingrese un número entre 0 y 100.");
                numIngresado = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Numero ingresado: " + numIngresado);
                if (numIngresado < numRandom)
                {
                    Console.WriteLine("Respuesta: Es muy bajo.");
                }
                if (numIngresado > numRandom)
                {
                    Console.WriteLine("Respuesta: Es muy alto.");
                }
                contador++;
            } while (numIngresado != numRandom);
            Console.WriteLine("Respuesta: Correcto, numero encontrado, cantidad de intentos " + contador + ".");
        }
    }
}
