using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            CrearDocumentoXML();
        }
        public static void CrearDocumentoXML() {
            try 
            { 
                XElement empleados = new XElement("Empleados");

                XElement listado = new XElement("Listado");

                XElement empleado = new XElement("Empleado");
                XElement id = new XElement("Id", "4884");
                empleado.Add(id);
                XElement nombreCompleto = new XElement("NombreCompleto", "Rodriguez, Victor");
                empleado.Add(nombreCompleto);
                XElement cuil = new XElement("Cuil", "20103180326");
                empleado.Add(cuil);
                XElement sector = new XElement("Sector");
                XAttribute denominacion = new XAttribute("Denominacion", "Gerencia Recursos Humanos");
                sector.Add(denominacion);
                XAttribute idSector = new XAttribute("Id", "137");
                sector.Add(idSector);
                XAttribute valorSemaforo = new XAttribute("ValorSemaforo", "130.13");
                sector.Add(valorSemaforo);
                XAttribute colorSemaforo = new XAttribute("ColorSemaforo", "VERDE");
                sector.Add(colorSemaforo);
                empleado.Add(sector);
                XElement cupoAsignado = new XElement("CupoAsignado", "1837.15");
                empleado.Add(cupoAsignado);
                XElement cupoConsumido = new XElement("CupoConsumido", "658.02");
                empleado.Add(cupoConsumido);
                listado.Add(empleado);

                empleado = new XElement("Empleado");
                id = new XElement("Id", "1225");
                empleado.Add(id);
                nombreCompleto = new XElement("NombreCompleto", "Sanchez, Juan Ignacio");
                empleado.Add(nombreCompleto);
                cuil = new XElement("Cuil", "20271265817");
                empleado.Add(cuil);
                sector = new XElement("Sector");
                denominacion = new XAttribute("Denominacion", "Gerencia Operativa");
                sector.Add(denominacion);
                idSector = new XAttribute("Id", "44");
                sector.Add(idSector);
                valorSemaforo = new XAttribute("ValorSemaforo", "130.13");
                sector.Add(valorSemaforo);
                colorSemaforo = new XAttribute("ColorSemaforo", "ROJO");
                sector.Add(colorSemaforo);
                empleado.Add(sector);
                cupoAsignado = new XElement("CupoAsignado", "750.87");
                empleado.Add(cupoAsignado);
                cupoConsumido = new XElement("CupoConsumido", "625.46");
                empleado.Add(cupoConsumido);
                listado.Add(empleado);
                empleados.Add(listado);

                XElement subSectores = new XElement("SubSectores", "5");
                empleados.Add(subSectores);
                XElement totalCupoAsignadoSector = new XElement("TotalCupoAsignadoSector", "4217.21");
                empleados.Add(totalCupoAsignadoSector);
                XElement totalCupoConsumidoSector = new XElement("TotalCupoConsumidoSector", "1405.88");
                empleados.Add(totalCupoConsumidoSector);
                XElement valorDial = new XElement("ValorDial", "33.34");
                empleados.Add(valorDial);

                XDeclaration declaration = new XDeclaration("1.0", "utf-8", "yes");
                XComment comentario = new XComment("XML Empleados");
                XDocument miXML = new XDocument(declaration, comentario, empleados);

                string path = Directory.GetCurrentDirectory();
                path = path.Replace("bin\\Debug", "");
                string archivoXML = path + "XML_Empleados.xml";
                miXML.Save(@archivoXML);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
