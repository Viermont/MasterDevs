using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberLister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "inicio";
            int counter = 0;
            List<int> numbers = new List<int>();

            Console.WriteLine("Introduzca los números a almacenar ó escriba \"salir\": ");
            while (input != "salir")
            {
                Console.Write("Número {0}: ", counter);
                input = Console.ReadLine();
                try
                {
                    if (numbers.IndexOf(Convert.ToInt32(input)) == -1 )
                        numbers.Add(Convert.ToInt32(input));
                    counter++;
                }
                catch(Exception)
                {
                    if (input == "salir") break;
                    Console.WriteLine("Introduzca un valor numérico.");
                }
            }
            Console.Write("Los números introducidos son: ");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
