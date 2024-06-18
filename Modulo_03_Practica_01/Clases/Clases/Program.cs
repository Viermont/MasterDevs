using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona = Persona.Iniciar("Mariano");
            persona.Presentarse("Pedro");

            var estudiante1 = new Estudiante();
            estudiante1.Id = 1;
            var estudiante2 = new Estudiante();
            var estudiante3 = new Estudiante(1);
            var estudiante4 = new Estudiante(5, "Mariano");
            var estudiante5 = new Estudiante
            {
                Id = 1,
                Cursos = new List<Curso>(),
                Nombre = "Mariano"
            };

            var curso = new Curso();
            estudiante1.Cursos.Add(curso);

            int resultadoSecciones = estudiante1.CantidadSeccionesVisualizadas(2, 3, 4, 5, 6, 90);

            Console.WriteLine(estudiante1.Id);
            Console.WriteLine(estudiante4.Nombre);
            Console.WriteLine(resultadoSecciones);
        }
    }
}
