using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Cree un programa que permita ingresar por teclado dos valores enteros el primero para indicar el número de filas y 
 * el segundo para el número de columnas. Mediante los 2 valores cree una matriz de 2 dimensiones de orden filas X 
 * columnas. Asigne a cada elemento de la matriz el valor X si la suma de los valores enteros ingresados es igual a la 
 * suma de la fila y columna de la celda caso contrario asigne una 0. (Se considera el valor de la posición y no del 
 * índice de la tabla para el cálculo, es decir la primer posición es 1 no 0).
 */

namespace EjercicioC1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un valor entero para las filas:");
            int filas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un valor entero para las columnas:");
            int columnas = Convert.ToInt32(Console.ReadLine());
            string [,] matriz = new string [filas, columnas];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (i+j+2 == filas+columnas)
                    {
                        matriz[i, j] = "X";
                    }
                    else
                    {
                        matriz[i, j] = "0";
                    }
                }
            }
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
