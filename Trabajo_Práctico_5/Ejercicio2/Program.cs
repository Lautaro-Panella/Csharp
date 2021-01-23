using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory();
            path = path.Replace("bin\\Debug", "");
            CrearDocumentoXML(path);
        }
        public static void CrearDocumentoXML(string ruta)
        {
            try 
            {         
                XmlTextWriter wr = new XmlTextWriter(ruta + "XML_Empleados.xml", null);
                wr.Formatting = Formatting.Indented;
                wr.WriteStartDocument(false);
                wr.WriteComment("XML Empleados");

                wr.WriteStartElement("Empleados");

                wr.WriteStartElement("Listado", null);

                wr.WriteStartElement("Empleado", null);
                wr.WriteElementString("Id", "4884");
                wr.WriteElementString("NombreCompleto", "Rodriguez, Victor");
                wr.WriteElementString("Cuil", "20103180326");
                wr.WriteStartElement("Sector", null);
                wr.WriteAttributeString("Denominacion", "Gerencia Recursos Humanos");
                wr.WriteAttributeString("Id", "137");
                wr.WriteAttributeString("ValorSemaforo", "130.13");
                wr.WriteAttributeString("ColorSemaforo", "VERDE");
                wr.WriteEndElement();
                wr.WriteElementString("CupoAsignado", "1837.15");
                wr.WriteElementString("CupoConsumido", "658.02");
                wr.WriteEndElement();

                wr.Flush();
                wr.WriteStartElement("Empleado", null);
                wr.WriteElementString("Id", "1225");
                wr.WriteElementString("NombreCompleto", "Sanchez, Juan Ignacio");  
                wr.WriteElementString("Cuil", "20271265817");
                wr.WriteStartElement("Sector", null);
                wr.WriteAttributeString("Denominacion", "Gerencia Operativa");
                wr.WriteAttributeString("Id", "44");
                wr.WriteAttributeString("ValorSemaforo", "130.13");
                wr.WriteAttributeString("ColorSemaforo", "ROJO");
                wr.WriteEndElement();
                wr.WriteElementString("CupoAsignado", "750.87");
                wr.WriteElementString("CupoConsumido", "625.46");
                wr.WriteEndElement();
                wr.WriteEndElement();

                wr.WriteElementString("SubSectores", null, "5");
                wr.WriteElementString("TotalCupoAsignadoSector", null, "4217.21");
                wr.WriteElementString("TotalCupoConsumidoSector", null, "1405.88");
                wr.WriteElementString("ValorDial", null, "33.34");
                wr.WriteEndElement();

                wr.Flush();
                wr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
