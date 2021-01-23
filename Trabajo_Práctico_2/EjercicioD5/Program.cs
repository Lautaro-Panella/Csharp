using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Codifique la siguiente clase cuyo alcance debe ser público:
 * Banco, Propietario: string.
 * Numero: int. 
 * Importe: decimal.
 * NroInterno: int.
 */

namespace EjercicioD5
{
    public class Cheque
    {
        private int nroInterno;
        private string banco;
        private double importe;
        private int numero;
        private string propietario;
        public int NroInterno
        {
            get { return nroInterno; }
            set { nroInterno = value; }
        }
        public string Banco
        {
            get { return banco; }
            set { banco = value; }
        }
        public double Importe
        {
            get { return importe; }
            set { importe = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Propietario
        {
            get { return propietario; }
            set { propietario = value; }
        }
        public void Guardar() { }
        public void Imprimir() { }
        protected void ValidarNroInterno() { }
    }
}
