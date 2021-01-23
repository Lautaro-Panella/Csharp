using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Codifique el siguiente modelo de Clases.
 * Codifique en la clase Deposito del modelo anterior un método llamado artículosBajoStock() que retorne una lista de 
 * objetos Articulo cuyo stockTotal sea menor o igual al stockMinimo existente.
 */

namespace EjercicioD6
{
    public class Deposito
    {
        private string nombre;
        private string domicilio;
        private List<Articulo> articulos = new List<Articulo>();
        private List<Articulo> abs = new List<Articulo>();
        public Deposito()
        {
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Domicilio
        {
            get { return domicilio; }
            set { nombre = domicilio; }
        }
        public List<Articulo> getArticulos
        {
            get { return articulos; }
        }
        public void setArticulos(Articulo art)
        {
            articulos.Add(art);
        }
        public void ArticulosBajoStock() 
        {
            foreach (Articulo art in articulos)
            {
                if (art.StockTotal <= art.StockMinimo)
                {
                    abs.Add(art);
                }
            }
        }
        public void MostrarArticulosBajoStock() 
        {
            Console.WriteLine("Los articulos con bajo stock son:");
            foreach (Articulo art in abs)
            {
                Console.WriteLine(art.Codigo);
            }
        }
    }
    public class Articulo 
    {
        private string codigo;
        private double stockTotal;
        private double stockMinimo;

        public Articulo(string codigo, double stockTotal, double stockMinimo)
        {
            this.codigo = codigo;
            this.stockTotal = stockTotal;
            this.stockMinimo = stockMinimo;
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public double StockTotal
        {
            get { return stockTotal; }
            set { stockTotal = value; }
        }
        public double StockMinimo
        {
            get { return stockMinimo; }
            set { stockMinimo = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Deposito d1 = new Deposito();
            Articulo a1 = new Articulo("Harina", 2, 2);
            Articulo a2 = new Articulo("Papa", 1, 2);
            Articulo a3 = new Articulo("Gaseosa", 3, 2);
            d1.setArticulos(a1);
            d1.setArticulos(a2);
            d1.setArticulos(a3);
            d1.ArticulosBajoStock();
            d1.MostrarArticulosBajoStock();
        }
    }
}
