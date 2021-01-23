using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  
 * Codifique un método denominado esPar que reciba como parámetro un valor numérico entero y retorne true en caso 
 * de que el numero sea par, caso contrario retorne false. Compruebe el funcionamiento del método solicitando al 
 * usuario del programa que ingrese números aleatorios.
 */

namespace Ejercicio3
{
    class Program
    {
        public static void Main(string[] args)
        {
            int numIngresado = -1;
            while (numIngresado != 0)
            {
                Console.WriteLine("Ingrese un número para comprobar si es par o impar, para finalizar ingrese 0.");
                numIngresado = Convert.ToInt32(Console.ReadLine());
                if (numIngresado == 0)
                {
                    break;
                }
                if (EsPar(numIngresado) == true)
                {
                    Console.WriteLine("El número ingresado es par.");
                }
                else
                {
                    Console.WriteLine("El número ingresado es impar.");
                }
            }
        }
        public static bool EsPar(int numero)
        {
            bool par = false;
            if (numero % 2 == 0)
            {
                par = true;
            }
            return par;
        }
    }
}
