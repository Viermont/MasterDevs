using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number1to10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int num;

            do
            {
                Console.Write("Escriba un número entre 1 y 10: ");
                input = Console.ReadLine();
                try
                {
                    num = Convert.ToInt32(input);
                    if (num < 1 || num > 10) Console.WriteLine("El número no es correcto.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Ingrese un valor numérico");
                    num = 0;
                }
            } while (num < 1 || num > 10);
            Console.WriteLine("El número es correcto.");
        }
    }
}
