using System.Collections.Generic;

namespace Clases
{
    public class Estudiante
    {
        public int Id;
        public string Nombre;
        public List<Curso> Cursos;

        public Estudiante()
        {
            Cursos = new List<Curso>();
        }
        public Estudiante(int id)
        {
            this.Id = id;
        }
        public Estudiante(int id, string nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
        }
        public int CantidadSeccionesVisualizadas(params int[] secciones)
        {
            int cantidadSecciones = secciones.Length;
            return cantidadSecciones;
        }
    }
}
