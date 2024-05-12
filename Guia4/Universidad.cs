using System;
using System.Collections.Generic;
using System.Numerics;

namespace Guia4
{
    public partial class Universidad
    {
        //  Lista de alumnos
        private List<Alumno> listaAlumnos;

        //Constructor para inicializar la lista de alumnos
        public Universidad()
        {
            listaAlumnos = new List<Alumno>();
        }

        //Método estático para agregar un nuevo alumno a la lista

        public void AgregarAlmuno(Alumno alumno)
        { 
            listaAlumnos.Add(alumno);
    
        }

        //Método estático para mostrar la lista de alumnos con detalles

        public List<Alumno> ObtenerListaAlumnos()
        {
            return listaAlumnos;


        }

    }
}
