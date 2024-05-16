using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace NumberSorter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            string input;

            Console.WriteLine("A continuación le solicitaré 10 números de 0 a 9:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Introduzca el número " + (i + 1) + ": ");
                input = Console.ReadLine();
                try
                {
                    if (Convert.ToInt32(input) >= 0 && Convert.ToInt32(input) < 10)
                        numbers[i] = Convert.ToInt32(input);
                    else
                    {
                        Console.WriteLine("El número debe estar entre 0 y 9.");
                        i--;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Debe introducir un valor numérico entre 0 y 9.");
                    i--;
                } 
            }
            Array.Sort(numbers);
            Console.Write("Los números introducidos en orden son: ");
            foreach (var item in numbers)
                Console.Write(numbers[item] + " ");
        }
    }
}
