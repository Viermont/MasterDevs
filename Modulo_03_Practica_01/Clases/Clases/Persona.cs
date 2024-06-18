using System;

namespace Clases
{
    public class Persona
    {
        public string Nombre;
        public void Presentarse(string a)
        {
            Console.WriteLine("Hola {0}, mi nombre es {1}", a, Nombre);
        }
        public static Persona Iniciar(string str)
        {
            var persona = new Persona();
            persona.Nombre = str;
            return persona;
        }
    }
}
