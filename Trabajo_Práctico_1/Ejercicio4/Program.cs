using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  
 * Codifique 5 funciones C# que resuelvan las operaciones matemáticas:
 * Suma + Resta – Multiplicación * División / Modulo %
 * Aplicadas sobre 2 números decimales.
 * Posteriormente codifique un programa que solicite el ingreso por parte del usuario de 2 números decimales y una vez 
 * ingresados le pregunte qué operación quiere realizar:
 * a- Suma +
 * b- Resta –
 * c- Multiplicación *
 * d- División /
 * e- Modulo %
 * En caso de que no ingrese ninguna de las opciones permitidas emita el mensaje “La opción ingresada no es válida” y 
 * vuelva nuevamente a preguntarle qué operación matemática quiere ejecutar.
 * Si la opción es válida envié los números decimales ingresados por el usuario a la función que corresponda y retorne 
 * el resultado de la operación.
 * Finalmente muestre un mensaje indicando el resultado de la operación realizada.
 */

namespace Ejercicio4
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Ingrese dos números, pueden ser decimales, para finalizar 0 y 0.");
                double num1 = Convert.ToDouble(Console.ReadLine());
                double num2 = Convert.ToDouble(Console.ReadLine());
                if (num1 == 0 && num2 == 0)
                {
                    break;
                }
                string op;
                do
                {
                    Console.WriteLine("Ingrese la operación a realizar, (a)suma, (b)resta, (c)multiplicación, (d)división o (e)modulo:");
                    op = Console.ReadLine();
                    if (op != "a" && op != "b" && op != "c" && op != "d" && op != "e")
                    {
                        Console.WriteLine("La opción ingresada no es válida.");
                    }
                } while (op != "a" && op != "b" && op != "c" && op != "d" && op != "e");
                if (op == "a")
                {
                    double resultado = Sumar(num1, num2);
                    Console.WriteLine("El resultado de la suma es igual a " + resultado + ".");
                }
                if (op == "b")
                {
                    double resultado = Restar(num1, num2);
                    Console.WriteLine("El resultado de la resta es igual a " + resultado + ".");
                }
                if (op == "c")
                {
                    double resultado = Multiplicar(num1, num2);
                    Console.WriteLine("El resultado de la multiplicación es igual a " + resultado + ".");
                }
                if (op == "d")
                {
                    if (num1 != 0 && num2 == 0)
                    {
                        Console.WriteLine("No es posible dividir un número por 0.");
                    }
                    else
                    {
                        double resultado = Dividir(num1, num2);
                        Console.WriteLine("El resultado de la división es igual a " + resultado + ".");
                    }
                }
                if (op == "e")
                {
                    double resultado = Modulo(num1, num2);
                    Console.WriteLine("El resultado del módulo es igual a " + resultado + ".");
                }
            }
        }
        public static double Sumar(double numero1, double numero2)
        {
            double resultado = numero1 + numero2;
            return resultado;
        }
        public static double Restar(double numero1, double numero2)
        {
            double resultado = numero1 - numero2;
            return resultado;
        }
        public static double Multiplicar(double numero1, double numero2)
        {
            double resultado = numero1 * numero2;
            return resultado;
        }
        public static double Dividir(double numero1, double numero2)
        {
            double resultado = numero1 / numero2;
            return resultado;
        }
        public static double Modulo(double numero1, double numero2)
        {
            double resultado = numero1 % numero2;
            return resultado;
        }
    }
}
