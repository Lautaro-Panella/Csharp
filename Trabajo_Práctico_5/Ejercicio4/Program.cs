using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ejercicio4
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

            using (XmlReader reader = XmlReader.Create(path + "XML_Empleados.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name)
                        {
                            case "Empleados":
                                resultado += "Iniciando elemento <Empleados>" + "\n";
                                break;
                            case "Listado":
                                resultado += "Iniciando elemento <Listado>" + "\n";
                                break;
                            case "Empleado":
                                resultado += "Iniciando elemento <Empleado>" + "\n";
                                break;
                            case "Id":
                                resultado += "Iniciando elemento <Id>" + "\n";
                                if (reader.Read())
                                {
                                    resultado += " Texto del nodo: " + reader.Value.Trim() + "\n";
                                }
                                break;
                            case "NombreCompleto":
                                resultado += "Iniciando elemento <Nombre Completo>" + "\n";
                                if (reader.Read())
                                {
                                    resultado += " Texto del nodo: " + reader.Value.Trim() + "\n";
                                }
                                break;
                            case "Cuil":
                                resultado += "Iniciando elemento <Cuil>" + "\n";
                                if (reader.Read())
                                {
                                    resultado += " Texto del nodo: " + reader.Value.Trim() + "\n";
                                }
                                break;
                            case "Sector":
                                resultado += "Iniciando elemento <Sector>" + "\n";
                                string denominacion = reader["Denominacion"];
                                string id = reader["Id"];
                                string valorSemaforo = reader["ValorSemaforo"];
                                string colorSemaforo = reader["ColorSemaforo"];
                                resultado += "Atributos del nodo <Sector> Denominación: " + denominacion + " ; Id: " + id + " ; Valor Semáforo: " + valorSemaforo + " ; Color Semáforo: " + colorSemaforo + "\n";
                                break;
                            case "CupoAsignado":
                                resultado += "Iniciando elemento <CupoAsignado>" + "\n";
                                if (reader.Read())
                                {
                                    resultado += " Texto del nodo: " + reader.Value.Trim() + "\n";
                                }
                                break;
                            case "CupoConsumido":
                                resultado += "Iniciando elemento <CupoConsumido>" + "\n";
                                if (reader.Read())
                                {
                                    resultado += " Texto del nodo: " + reader.Value.Trim() + "\n";
                                }
                                break;
                            case "SubSectores":
                                resultado += "Iniciando elemento <SubSectores>" + "\n";
                                if (reader.Read())
                                {
                                    resultado += " Texto del nodo: " + reader.Value.Trim() + "\n";
                                }
                                break;
                            case "TotalCupoAsignadoSector":
                                resultado += "Iniciando elemento <TotalCupoAsignadoSector>" + "\n";
                                if (reader.Read())
                                {
                                    resultado += " Texto del nodo: " + reader.Value.Trim() + "\n";
                                }
                                break;
                            case "TotalCupoConsumidoSector":
                                resultado += "Iniciando elemento <TotalCupoConsumidoSector>" + "\n";
                                if (reader.Read())
                                {
                                    resultado += " Texto del nodo: " + reader.Value.Trim() + "\n";
                                }
                                break;
                            case "ValorDial":
                                resultado += "Iniciando elemento <ValorDial>" + "\n";
                                if (reader.Read())
                                {
                                    resultado += " Texto del nodo: " + reader.Value.Trim() + "\n";
                                }
                                break;
                        }
                    }
                }
            }
            return resultado;
        }
    }
}
