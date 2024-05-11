using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeTemperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int temp;

            do
            {
                Console.WriteLine("¿A que temperatura está el café?");
                input = Console.ReadLine();
                try
                {
                    temp = Convert.ToInt32(input);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Ingrese un valor numérico.");
                }
            } while (true);

            if (temp < 20) Console.WriteLine("El café está frío.");
            else if (temp >= 20 && temp <= 60) Console.WriteLine("El café está caliente.");
            else Console.WriteLine("Te quemarás con este café, debes esperar 10 minutos para beberlo.");
        }
    }
}
