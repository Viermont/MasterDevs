using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campos
{
    public class Estudiante
    {
        public int Id;
        public string Nombre;
        //public List<Curso> Cursos;
        public readonly List<Curso> Cursos = new List<Curso>();

        public Estudiante()
        {
            Cursos = new List<Curso>();
        }
        public void AddCursos()
        {
            //Cursos = new List<Curso>();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
