//Realizar la implementación en el programa principal según la lógica brindada , deberán subir un repositorio con lo indicado a mas tardar el dia domingo a media noche.

using System;
using System.Collections.Generic;

namespace Guia4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear instancia de la universidad
            Universidad universidad = new Universidad();

            // Agregar algunos alumnos a la universidad
            Alumno alumno1 = new Alumno("Karolina Díaz", 19, Carreras.Ingenieria_de_Sistemas, "2022-0804U");
            alumno1.Calificaciones.AddRange(new double[] { 80, 75, 85 });
            universidad.AgregarAlmuno(alumno1);

            Alumno alumno2 = new Alumno("Jafet Aguilar", 20, Carreras.Ingenieria_en_Computación, "2022-0848U");
            alumno2.Calificaciones.AddRange(new double[] { 70, 65, 75 });
            universidad.AgregarAlmuno(alumno2);

            // Obtener la lista de alumnos
            List<Alumno> listaAlumnos = universidad.ObtenerListaAlumnos();

            // Mostrar la lista de alumnos con detalles
            Console.WriteLine("Lista de Alumnos:");
            foreach (var alumno in listaAlumnos)
            {
                Console.WriteLine($"Nombre: {alumno.Nombre}");
                Console.WriteLine($"Edad: {alumno.Edad}");
                Console.WriteLine($"Carrera: {alumno.Carrera}");
                Console.WriteLine($"Promedio de Calificaciones: {alumno.CalcularPromedioCalificaciones()}");
                Console.WriteLine($"Estado de Aprobación: {alumno.EstadoAprobacion()}");
                Console.WriteLine($"Número de Carné: {alumno.Carné}");
                Console.WriteLine();
            }
        }
    }
}