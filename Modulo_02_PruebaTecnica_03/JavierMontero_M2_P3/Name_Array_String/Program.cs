using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_Array_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] input;
            string reverseName;

            Console.WriteLine("Escriba su nombre: ");
            input = Console.ReadLine().ToCharArray();
            Array.Reverse(input);
            reverseName = new string(input);
            Console.WriteLine("Su nombre invertido es " + reverseName);
        }
    }
}