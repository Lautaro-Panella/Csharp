using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Práctico9_LINQ
{
    class Principal
    {
        static void Main(string[] args)
        {
            IList<Empleado> empleados = new List<Empleado>() { new Empleado() { Id = 1, Nombre = "Juan", Apellido = "Perez", Domicilio = "Salta 314", Localidad = "Ciudad", Salario = 30000, DiasInasistencia = 0 } , new Empleado() { Id = 2, Nombre = "Pedro", Apellido = "Hernandez", Domicilio = "San Martin 456", Localidad = "Ciudad", Salario = 36000, DiasInasistencia = 1 } , new Empleado() { Id = 3, Nombre = "Jose", Apellido = "Chatruc", Domicilio = "Lavalle 789", Localidad = "Lujan", Salario = 28000, DiasInasistencia = 12 } , new Empleado() { Id = 4, Nombre = "Carlos" , Apellido = "Alonso", Domicilio = "Rioja 14", Localidad = "Guaymallen", Salario = 45000, DiasInasistencia = 5 } , new Empleado() { Id = 5, Nombre = "Claudio" , Apellido = "Ahumada", Domicilio = "Lima 125", Localidad = "Tupungato", Salario = 38000, DiasInasistencia = 0 } , new Empleado() { Id = 5, Nombre = "Sebastian" , Apellido = "Tobar", Domicilio = "Rawson 123", Localidad = "Lujan", Salario = 42000, DiasInasistencia = 2 } , new Empleado() { Id = 5, Nombre = "Javier" , Apellido = "Puebla", Domicilio = "Italia 987", Localidad = "Ciudad", Salario = 33000, DiasInasistencia = 4 } ,  new Empleado() { Id = 5, Nombre = "Fabian" , Apellido = "Gilar", Domicilio = "Las Viñas 987", Localidad = "Guaymallen", Salario = 38000, DiasInasistencia = 0 } , new Empleado() { Id = 5, Nombre = "Victor" , Apellido = "Pereira", Domicilio = "25 de Mayo 654", Localidad = "Tupungato", Salario = 37000, DiasInasistencia = 8 } , new Empleado() { Id = 5, Nombre = "Nelson" , Apellido = "Piquet", Domicilio = "Peru 987", Localidad = "Ciudad", Salario = 36000, DiasInasistencia = 3 }};
            // Consultas LINQ
            var empleados1 = from Empleado in empleados where Empleado.Localidad.Equals("Ciudad") select Empleado;
            var empleados2 = from Empleado in empleados where Empleado.Apellido.StartsWith("A") select Empleado;
            var empleados3 = from Empleado in empleados where Empleado.DiasInasistencia == 0 select Empleado;
            var empleados4 = from Empleado in empleados where Empleado.Localidad.Equals("Ciudad") && Empleado.Salario > 35000 select Empleado;
            var empleados5 = from Empleado in empleados where Empleado.DiasInasistencia > 0 || Empleado.Salario <= 30000 select Empleado;
            var empleados6 = from Empleado in empleados where Empleado.Nombre.EndsWith("n") select Empleado;
            var empleados7 = from Empleado in empleados orderby Empleado.Salario ascending select Empleado;
            var empleados8 = from Empleado in empleados orderby Empleado.DiasInasistencia descending select Empleado;
            var empleados9 = from Empleado in empleados group Empleado by Empleado.Localidad;
            int cantidadSalarios = (from Empleado in empleados select Empleado.Salario).Count();
            int maximoSalario = (from Empleado in empleados select Empleado.Salario).Max();
            double promedioSalarios = (from Empleado in empleados select Empleado.Salario).Average();
            int primerElementoSalarios = (from Empleado in empleados select Empleado.Salario).First();

            Console.WriteLine("1. Seleccione todos los empleados que sean de ciudad.");
            foreach (Empleado emp in empleados1)
            {
                Console.WriteLine(emp.Apellido + " " + emp.Nombre + " Localidad: " + emp.Localidad);
            }
            Console.WriteLine("..................................................................................................................");

            Console.WriteLine("2. Seleccione todos los empleados cuyo apellido inicie con A.");
            foreach (Empleado emp in empleados2)
            {
                Console.WriteLine(emp.Apellido + " " + emp.Nombre);
            }
            Console.WriteLine("..................................................................................................................");

            Console.WriteLine("3. Seleccione todos los empleados que no tengan inasistencias laborales.");
            foreach (Empleado emp in empleados3)
            {
                Console.WriteLine(emp.Apellido + " " + emp.Nombre + " Numero de inasistencias: " + emp.DiasInasistencia);
            }
            Console.WriteLine("..................................................................................................................");

            Console.WriteLine("4. Seleccione todos los empleados que sean de ciudad y cuyo salario sea mayor a 35000.");
            foreach (Empleado emp in empleados4)
            {
                Console.WriteLine(emp.Apellido + " " + emp.Nombre + " Localidad: " + emp.Localidad + " Salario: " + emp.Salario);
            }
            Console.WriteLine("..................................................................................................................");

            Console.WriteLine("5. Seleccione todos los empleados que tengan inasistencias o que tengan un salario menor o igual a 30000.");
            foreach (Empleado emp in empleados5)
            {
                Console.WriteLine(emp.Apellido + " " + emp.Nombre + " Numero de inasistencias: " + emp.DiasInasistencia + " Salario: " + emp.Salario);
            }
            Console.WriteLine("..................................................................................................................");

            Console.WriteLine("6. Seleccione todos los empleados cuyo nombre termine con n.");
            foreach (Empleado emp in empleados6)
            {
                Console.WriteLine(emp.Apellido + " " + emp.Nombre);
            }
            Console.WriteLine("..................................................................................................................");

            Console.WriteLine("7. Seleccione todos los empleados ordenados por salario en forma ascendente.");
            foreach (Empleado emp in empleados7)
            {
                Console.WriteLine(emp.Apellido + " " + emp.Nombre + " Salario: " + emp.Salario);
            }
            Console.WriteLine("..................................................................................................................");

            Console.WriteLine("8. Seleccione todos los empleados ordenados por días de inasistencia en forma descendente.");
            foreach (Empleado emp in empleados8)
            {
                Console.WriteLine(emp.Apellido + " " + emp.Nombre + " Numero de inasistencias: " + emp.DiasInasistencia);
            }
            Console.WriteLine("..................................................................................................................");

            Console.WriteLine("9. Seleccione todos los empleados agrupados por Localidad.");
            foreach (var empGroup in empleados9)
            {
                Console.WriteLine(empGroup.Key);
                foreach (Empleado emp in empGroup)
                {
                    Console.WriteLine("     {0} {1}", emp.Apellido, emp.Nombre);
                }
            }
            Console.WriteLine("..................................................................................................................");

            Console.WriteLine("10. Seleccione el campo Salario y realice las siguientes tareas:");
            Console.WriteLine("Cuente la cantidad de salarios. (mediante clausula Count): " + cantidadSalarios);
            Console.WriteLine("Indique el máximo salario. (mediante clausula Max): " + maximoSalario);
            Console.WriteLine("Indique el promedio de los salarios. (mediante clausula Average): " + promedioSalarios);
            Console.WriteLine("Retorne el primer elemento de la lista. (mediante clausula First): " + primerElementoSalarios);
        }
    }
}
