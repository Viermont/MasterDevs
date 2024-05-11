using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int num;
            string input;

            Console.WriteLine("A continuación le solicitaré una secuencia de números,\ncuando escriba " +
                "\"salir\" le mostraré la suma de todos los números introducidos.\n");
            do
            {
                Console.Write("Ingrese un número: ");
                input = Console.ReadLine();
                if (input == "salir") break;
                try
                {
                    num = Convert.ToInt32(input);
                    suma += num;
                }
                catch(Exception)
                {
                    Console.WriteLine("Ingrese un valor numérico.");
                }
            } while (true);
            Console.WriteLine("La suma de todos sus números es {0}.", suma);
        }
    }
}
