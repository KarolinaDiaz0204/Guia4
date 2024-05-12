using System;
using System.Collections.Generic;
using System.Numerics;

namespace Guia4
{

    public enum Carreras
    {
        Ingenieria_de_Sistemas,
        Ingenieria_en_Computación,
        Telecomunicaciones,
        Ingenieria_electronica,

    }

    //Definición de la clase Alumno
    public partial class Alumno
    {
        //Propiedades principales del alu no

        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Carné { get; set; }
        public Carreras Carrera { get; set; }
        public List<double> Calificaciones { get; set; }

        //Propiedades principales del alumno

        //Constructor para iniciliazar las propiedades del alumno

        public Alumno(string nombre, int edad, Carreras carrera, string carne)
        {

            this.Nombre = nombre;
            this.Edad = edad;
            this.Carrera = carrera;
            this.Carné = carne;
            Calificaciones = new List<double>();

        }


        //Método para calcular el promedio de calificaciones del alumno

        public double CalcularPromedioCalificaciones()
        {
            if (Calificaciones.Count == 0)
            {
                return 0;//Si no hay calificaciones, el promedio es 0
            }

            double sumaCalificaciones = 0;
            foreach (var calificacion in Calificaciones)
            {

                sumaCalificaciones += calificacion;
            }

            return sumaCalificaciones / Calificaciones.Count;

        }
        //Método para determinar si el aprobó (promedio >= 60) o reprobó (promedio < 60)

        public string EstadoAprobacion()
        {

            double promedio = CalcularPromedioCalificaciones();

            if (promedio >= 60)

            {
                return "Aprobado";

            }

            else
            {
                return "Reprobado";
            }


        }
    }
}
