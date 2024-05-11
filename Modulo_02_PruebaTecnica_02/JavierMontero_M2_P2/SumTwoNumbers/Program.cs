using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int num1;
            int num2;

            do
            {
                Console.Write("Escriba los números que desee sumar.\nPrimer número: ");
                input = Console.ReadLine();
                try
                {
                    num1 = Convert.ToInt32(input);
                    do
                    {
                        Console.Write("Segundo número: ");
                        input = Console.ReadLine();
                        try
                        {
                            num2 = Convert.ToInt32(input);
                            break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Formato Incorrecto.");
                        }
                        
                    } while (true);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Formato Incorrecto.");
                }
            } while (true);
            Console.WriteLine("La suma de los números {0} y {1} es {2}.", num1, num2, num1 + num2);
        }
    }
}
