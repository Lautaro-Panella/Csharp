using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/*
 * Codifique un programa que contenga un método llamado “ejecutarHiloCincoSeg()” que imprima por consola la leyenda 
 * “HILO EJECUTADO 5” y otro método llamado “ejecutarHiloDiezSeg()”que imprima por consola la leyenda “HILO EJECUTADO 10” 
 * implemente el código necesario para que por medio de la ejecución de Hilos el mensaje del método “ejecutarHiloCincoSeg()” 
 * se ejecute y muestre cada 5 segundos y el mensaje del método “ejecutarHiloDiezSeg()” se ejecute y muestre cada 10 
 * segundos.
 */

namespace EjercicioE1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(EjecutarHiloCincoSeg);
            Thread t2 = new Thread(EjecutarHiloDiezSeg);
            t1.Start();
            t2.Start();
        }
        static void EjecutarHiloCincoSeg()
        {
            while (true)
            {
                Thread.Sleep(TimeSpan.FromSeconds(5));
                Console.WriteLine("HILO EJECUTADO 5.");
            }
        }
        static void EjecutarHiloDiezSeg()
        {
            while (true)
            {
                Thread.Sleep(TimeSpan.FromSeconds(10));
                Console.WriteLine("HILO EJECUTADO 10.");
            }
        }
    }
}
