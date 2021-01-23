using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * En primer lugar, cree una clase base llamada Figura y luego cree clases derivadas como Rectángulo, Circulo y Triangulo. 
 * Incluya en la clase Figura un método virtual llamado Dibujar() que imprima por consola el mensaje “Dibuja Figura” y 
 * sobrescriba el método (override) en cada clase derivada para dibujar la forma determinada que representa la clase, es 
 * decir que para Rectángulo el método debe imprimir por consola “Dibuja Rectángulo”, para Circulo “Dibuja Circulo” y para 
 * Triangulo “Dibuja Triangulo”. 
 * Finalmente en el método static void Main() cree un objeto List<Figura> y agregue al mismo instancias de Circulo, 
 * Triangulo y Rectángulo. Utilice un bucle foreach para recorrer en iteración la lista y llamar al método Dibujar () en 
 * cada objeto Figura de la lista. Aunque cada objeto de la lista tiene un tipo declarado de Figura, es el tipo en tiempo 
 * de ejecución el que se invocará.
 */

namespace EjercicioD7
{
    class Figura
    {
        public virtual void Dibujar() 
        {
            Console.WriteLine("Dibuja Figura.");
        }
    }
    class Rectangulo : Figura
    {
        public override void Dibujar()
        {
            Console.WriteLine("Dibuja Rectángulo.");
            base.Dibujar();
        }
    }
    class Circulo : Figura
    {
        public override void Dibujar()
        {
            Console.WriteLine("Dibuja Círculo.");
            base.Dibujar();
        }
    }
    class Triangulo : Figura
    {
        public override void Dibujar()
        {
            Console.WriteLine("Dibuja Triángulo.");
            base.Dibujar();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo r1 = new Rectangulo();
            Circulo c1 = new Circulo();
            Triangulo t1 = new Triangulo();
            List<Figura> figuras = new List<Figura>();
            figuras.Add(r1);
            figuras.Add(c1);
            figuras.Add(t1);
            foreach (Figura fig in figuras)
            {
                fig.Dibujar();
            }
        }
    }
}
