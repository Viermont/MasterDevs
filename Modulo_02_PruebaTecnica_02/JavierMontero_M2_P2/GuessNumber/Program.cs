using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int secretNum;
            int num;
            bool reset = true;

            while (reset)
            {
                Console.Clear();
                Random rand = new Random();
                secretNum = rand.Next(1, 11);
                Console.WriteLine("Número Secreto: " + secretNum);

                for (int i = 4; i >= 0; i--)
                {
                    Console.Write("Adivina un número entre 1 y 10: ");
                    input = Console.ReadLine();

                    try
                    {
                        num = Convert.ToInt32(input);
                        if (num == secretNum)
                        {
                            Console.Write("Has ganado. ¿Quieres jugar otra vez? Escribe 1 (Si) ó 2 (No): ");
                            input = Console.ReadLine();
                            num = Convert.ToInt32(input);
                            if (num == 2) reset = false;
                            break;
                        }
                        else
                        {
                            if (i > 0) Console.WriteLine("Has fallado. Te quedan " + i + " intentos.");
                            else
                            {
                                Console.WriteLine("Has Perdido.");
                                reset = false;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Ingrese un valor numérico.");
                        i++;
                    }
                }
            }
        }
    }
}
