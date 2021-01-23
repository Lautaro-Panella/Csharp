using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Diseña e implementa una clase Fracción que permita crear fracciones (atributos numerador y denominador tipo enteros), 
 * con métodos para sumar, restar, multiplicar y dividir las fracciones. Crea una clase tipo excepción FraccionException 
 * (declárala como una excepción explícita) que se lance siempre que el denominador o el numerador de la fracción sea cero. 
 * Hacer que las operaciones lancen (throw) esta excepción si se da el caso, con un mensaje indicativo del tipo de error 
 * (Ejemplo “El numerador no puede ser cero”). Construir un programa que pruebe el funcionamiento de la clase Fracción y 
 * sus operaciones.
 */

namespace EjercicioB_1
{
    class Fraccion
    {
        private int numerador;
        private int denominador; 
        public Fraccion()
        {
        }
        public int Numerador
        {
            get { return numerador; }
            set
            {
                numerador = value;
                if (numerador == 0)
                {
                    throw new Exception();
                }
            }
        }
        public int Denominador
        {
            get { return denominador; }
            set
            {
                denominador = value;
                if (denominador == 0)
                {
                    throw new Exception();
                }
            }
        }
        public Fraccion sumarFraccion(Fraccion f1, Fraccion f2)
        {
            int num1, num2, den1, den2;
            num1 = f1.Numerador;
            num2 = f2.Numerador;
            den1 = f1.Denominador;
            den2 = f2.Denominador;
            if (den1 == den2)
            {
                Numerador = num1 + num2;
                Denominador = den1;
                return this;
            }
            else
            {
                Denominador = mcm(den1, den2);
                Numerador = (num1 * den2) + (num2 * den1);
                return this;
            }
        }
        public Fraccion restarFraccion(Fraccion f1, Fraccion f2)
        {
            int num1, num2, den1, den2;
            num1 = f1.Numerador;
            num2 = f2.Numerador;
            den1 = f1.Denominador;
            den2 = f2.Denominador;
            if (den1 == den2)
            {
                Numerador = num1 - num2;
                Denominador = den1;
                return this;
            }
            else
            {
                Denominador = mcm(den1, den2);
                Numerador = (num1 * den2) - (num2 * den1);
                return this;
            }
        }
        public Fraccion multiplicarFraccion(Fraccion f1, Fraccion f2)
        {
            int num1, num2, den1, den2;
            num1 = f1.Numerador;
            num2 = f2.Numerador;
            den1 = f1.Denominador;
            den2 = f2.Denominador;
            Numerador = num1 * num2;
            Denominador = den1 * den2;
            return this;
        }
        public Fraccion dividirFraccion(Fraccion f1, Fraccion f2)
        {
            int num1, num2, den1, den2;
            num1 = f1.Numerador;
            num2 = f2.Numerador;
            den1 = f1.Denominador;
            den2 = f2.Denominador;
            Numerador = num1 * den2;
            Denominador = den1 * num2;
            return this;
        }
        public int mcd(int n1, int n2)
        {
            int m;
            while (n1 != n2)
            {
                if (n1 > n2)
                {
                    n1 -= n2;
                }
                else
                {
                    n2 -= n1;
                }
            }
            return m = n1;
        }
        public int mcm(int a, int b)
        {
            return a * b / mcd(a, b);
        }
        public string cadenaFraccion(Fraccion s)
        {
            string fraccion = s.Numerador + "/" + s.Denominador;

            return fraccion;
        }
    }
    class FraccionExcepcion : Exception
    {
        public int datoNumerador(Fraccion f)
        {
            do
            {
                try
                {
                    f.Numerador = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("El numerador no puede ser 0. " + e.Message);
                }
            } while (f.Numerador == 0);
            return f.Numerador;
        }
        public int datoDenominador(Fraccion f)
        {
            do
            {
                try
                {
                    f.Denominador = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("El denominador no puede ser 0. " + e.Message);
                }
            } while (f.Denominador == 0);
            return f.Denominador;
        }
    }
    class ejercicio1
    {
        static void Main(string[] args)
        {
            Fraccion f1 = new Fraccion();
            Fraccion f2 = new Fraccion();
            Fraccion f3 = new Fraccion();
            FraccionExcepcion fex = new FraccionExcepcion();
            Console.WriteLine("Ingrese el numerador de la primer fracción: ");
            fex.datoNumerador(f1);

            Console.WriteLine("Ingrese el denominador de la primer fracción: ");
            fex.datoDenominador(f1);

            Console.WriteLine("Ingrese el numerador de la segunda fracción: ");
            fex.datoNumerador(f2);

            Console.WriteLine("Ingrese el denominador de la segunda fracción: ");
            fex.datoDenominador(f2);

            f3.sumarFraccion(f1, f2);
            Console.WriteLine("La suma de fracciones es: " + f3.cadenaFraccion(f3));

            f3.restarFraccion(f1, f2);
            Console.WriteLine("La resta de fracciones es: " + f3.cadenaFraccion(f3));

            f3.multiplicarFraccion(f1, f2);
            Console.WriteLine("La multiplicación de fracciones es: " + f3.cadenaFraccion(f3));

            f3.dividirFraccion(f1, f2);
            Console.WriteLine("La división de fracciones es: " + f3.cadenaFraccion(f3));
        }
    }
}
