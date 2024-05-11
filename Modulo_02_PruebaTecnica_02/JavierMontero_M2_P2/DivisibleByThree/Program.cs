using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleByThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            for (int i = 1; i <= 150; i++)
            {
                if (i % 3 == 0) counter++;
            }
            Console.WriteLine("Entre 1 y 150 hay {0} números divisibles entre 3 y con resto 0.", counter);
        }
    }
}
