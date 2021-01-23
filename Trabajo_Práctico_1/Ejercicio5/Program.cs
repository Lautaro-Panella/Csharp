using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  
 * Cree las funciones necesarias para Calcular el sueldo de los trabajadores dependiendo las horas trabajadas. 
 * El valor de la hora en horario diurnos (8:00 a 20:00) es de $10/hora, si el horario es nocturno (20:00 a 8:00) 
 * se incrementa en un 50%. El programa debe pedir al usuario en que horario trabajo el empleado (hora ingreso, minuto 
 * ingreso, hora salida, minuto salida), validar que la hora/minuto de ingreso no sea mayor a la hora/minuto de salida, 
 * validar que la cantidad de horas trabajadas no supere las 8 horas, calcular cuantas horas trabajo en total y cuanto 
 * corresponde pagarle. Nota: Se recomienda calcular el tiempo laboral en minutos.
 */

namespace Ejercicio5
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Variables.
            int hora_ingreso, hora_salida, minuto_ingreso, minuto_salida, ingresoMinutos, salidaMinutos;
            double minutosTotales, totales_diurnos, totales_nocturnos, minutos_noche, sueldo = 0;

            // Datos de horario de ingreso y salida.
            Console.WriteLine("Ingrese la hora de ingreso: ");
            hora_ingreso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese los minutos de ingreso: ");
            minuto_ingreso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la hora de salida: ");
            hora_salida = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese los minutos de salida: ");
            minuto_salida = Convert.ToInt32(Console.ReadLine());

            // Paso las horas de ingreso y de salida a minutos.
            ingresoMinutos = (hora_ingreso * 60) + minuto_ingreso;
            salidaMinutos = (hora_salida * 60) + minuto_salida;

            // Valido que los datos ingresados no superen las 8hs de trabajo.
            while ((salidaMinutos - ingresoMinutos) > 480 && ((salidaMinutos + 1440) - ingresoMinutos) > 480)
            {
                Console.WriteLine("El empleado no puede trabajar más de 8 horas.\n");
                Console.WriteLine("Ingrese la hora de ingreso: ");
                hora_ingreso = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese los minutos de ingreso: ");
                minuto_ingreso = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese la hora de salida: ");
                hora_salida = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese los minutos de salida: ");
                minuto_salida = Convert.ToInt32(Console.ReadLine());
                ingresoMinutos = (hora_ingreso * 60) + minuto_ingreso;
                salidaMinutos = (hora_salida * 60) + minuto_salida;
            }

            // Caso 1: Ingreso mayor o igual que 8 AM Y salida menor a las 20 PM Y el ingreso no debe superar a la salida.
            if ((ingresoMinutos >= 480) && (salidaMinutos < 1200) && (ingresoMinutos < salidaMinutos))
            {
                minutosTotales = salidaMinutos - ingresoMinutos;
                sueldo = ((minutosTotales * 10)) / 60;
            }

            // Caso 2: Ingreso mayor que 8 AM Y menor que 20 PM Y salida mayor que 20 PM y menor que 24.
            if ((ingresoMinutos > 480) && (ingresoMinutos < 1200) && (salidaMinutos > 1200) && (salidaMinutos < 1440))
            {
                totales_diurnos = 1200 - ingresoMinutos;
                totales_nocturnos = salidaMinutos - 1200;
                sueldo = ((totales_diurnos * 10) + (totales_nocturnos * 15)) / 60;
            }

            // Caso 3: Ingreso mayor que 8 AM Y menor que 20 PM Y salida mayor a 0 AM Y menor a 8 AM.
            if ((ingresoMinutos > 480) && (ingresoMinutos < 1200) && (salidaMinutos > 0) && (salidaMinutos < 480))
            {
                totales_diurnos = ingresoMinutos - 480;
                totales_nocturnos = 480 - salidaMinutos;
                sueldo = ((totales_diurnos * 10) + (totales_diurnos * 15)) / 60;
            }

            // Caso 4: Ingreso mayor a 20 PM Y menor que 24 PM Y  salida mayor que 20 PM y menor que 24 PM pero el ingreso debe ser menor a la salida.
            if ((ingresoMinutos > 1200) && (ingresoMinutos < 1440) && (salidaMinutos > 1200) && (salidaMinutos < 1440) && (ingresoMinutos < salidaMinutos))
            {
                totales_nocturnos = salidaMinutos - ingresoMinutos;
                sueldo = (totales_nocturnos * 15) / 60;
            }

            // Caso 5: Ingreso mayor que 20 PM Y menor que 24 PM Y salida mayor que 0 AM y menor que 8 AM.
            if ((ingresoMinutos > 1200) && (ingresoMinutos < 1440) && (salidaMinutos > 0) && (salidaMinutos < 480))
            {
                totales_nocturnos = 1440 - ingresoMinutos;
                minutos_noche = salidaMinutos;
                minutosTotales = totales_nocturnos + minutos_noche;
                sueldo = (minutosTotales * 15) / 60;
            }

            // Caso 6: Ingreso mayor que 0 AM y menor que 8 AM Y salida menor que 8 AM y que el ingreso sea menor a la salida.
            if ((ingresoMinutos > 0) && (ingresoMinutos < 480) && (salidaMinutos < 480) && (ingresoMinutos < salidaMinutos))
            {
                totales_nocturnos = salidaMinutos - ingresoMinutos;
                minutosTotales = totales_nocturnos;
                sueldo = (minutosTotales * 15) / 60;
            }

            // Caso 7: Ingreso mayor que 0 AM Y menor a 8 AM y salida mayor a 8 AM y menor que 20 PM.
            if ((ingresoMinutos > 0) && (ingresoMinutos < 480) && (salidaMinutos > 480) && (salidaMinutos < 1200))
            {
                totales_nocturnos = 480 - ingresoMinutos;
                totales_diurnos = salidaMinutos - 480;
                sueldo = (totales_nocturnos * 15 + totales_diurnos * 10) / 60;
            }

            Console.WriteLine("El sueldo correspondiente es: $" + sueldo);
        }
    }
}
