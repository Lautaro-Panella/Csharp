using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  
 * Muestra los números del 1 al 100 (ambos incluidos) divisibles entre 2 y 5. Utiliza las iteraciones for, while,
 * do/while para resolver el mismo problema.
 */

namespace Ejercicio1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("For. Los números divisibles por 2 y 5 entre 1 y 100 son:");
            for (int i = 1; i < 101; i++)
            {
                if (((i % 2) == 0) && ((i % 5) == 0))
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("While. Los números divisibles por 2 y 5 entre 1 y 100 son:");
            int contador = 1;
            while (contador < 101)
            {
                if (((contador % 2) == 0) && ((contador % 5) == 0))
                {
                    Console.WriteLine(contador);
                }
                contador++;
            }

            Console.WriteLine("Do - While. Los números divisibles por 2 y 5 entre 1 y 100 son:");
            contador = 1;
            do
            {
                if (((contador % 2) == 0) && ((contador % 5) == 0))
                {
                    Console.WriteLine(contador);
                }
                contador++;
            } while (contador < 101);
        }
    }
}
