using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LeerDocumentoXML());
        }
        public static string LeerDocumentoXML() 
        {
            string resultado = "";
            string path = Directory.GetCurrentDirectory();
            path = path.Replace("bin\\Debug", "");

            try
            {
                XmlDocument documento = new XmlDocument();
                documento.Load(path + "XML_Empleados.xml");

                XmlNodeList empleados = documento.GetElementsByTagName("Empleados");
                XmlNodeList listado = ((XmlElement)empleados[0]).GetElementsByTagName("Listado");
                XmlNodeList subSectores = ((XmlElement)empleados[0]).GetElementsByTagName("SubSectores");
                XmlNodeList totalCupoAsignadoSector = ((XmlElement)empleados[0]).GetElementsByTagName("TotalCupoAsignadoSector");
                XmlNodeList totalCupoConsumidoSector = ((XmlElement)empleados[0]).GetElementsByTagName("TotalCupoConsumidoSector");
                XmlNodeList valorDial = ((XmlElement)empleados[0]).GetElementsByTagName("ValorDial");
                XmlNodeList empleado = ((XmlElement)listado[0]).GetElementsByTagName("Empleado");

                foreach (XmlElement nodo in empleado)
                {
                    int i = 0;

                    XmlNodeList id = nodo.GetElementsByTagName("Id");
                    XmlNodeList nombreCompleto = nodo.GetElementsByTagName("NombreCompleto");
                    XmlNodeList cuil = nodo.GetElementsByTagName("Cuil");
                    XmlNodeList sector = nodo.GetElementsByTagName("Sector");
                    resultado += "Empleado Id: " + id[i].InnerText + "\n" + "Nombre Completo: " + nombreCompleto[i].InnerText + "\n" + "Cuil: " + cuil[i].InnerText + "\n";
                    
                    String denominacion = ((XmlElement)sector[0]).GetAttribute("Denominacion");
                    String idS = ((XmlElement)sector[0]).GetAttribute("Id");
                    String valorSemaforo = ((XmlElement)sector[0]).GetAttribute("ValorSemaforo");
                    String colorSemaforo = ((XmlElement)sector[0]).GetAttribute("ColorSemaforo");
                    resultado += "Sector >> Denominación: " + denominacion + " ; Id: " + idS + " ; Valor Semáforo: " + valorSemaforo + " ; Color Semáforo: " + colorSemaforo + "\n";
                    
                    XmlNodeList cupoAsignado = nodo.GetElementsByTagName("CupoAsignado");
                    XmlNodeList cupoConsumido = nodo.GetElementsByTagName("CupoConsumido");
                    resultado += "Cupo asigado: " + cupoAsignado[i].InnerText + " ; Cupo consumido: " + cupoConsumido[i].InnerText + "\n";
                    i++;
                }
                resultado += "\n" + "SubSectores: " + subSectores[0].InnerText + "\n" + "Total cupo asignado sector: " + totalCupoAsignadoSector[0].InnerText + "\n" + "Total cupo consumido sector: " + totalCupoConsumidoSector[0].InnerText + "\n" + "Valor dial: " + valorDial[0].InnerText;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return resultado;
        }
    }
}
