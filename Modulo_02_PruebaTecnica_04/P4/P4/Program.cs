using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>();

            numList = StoreNumber(numList);
            ShowList(numList);
        }
        public static List<int> StoreNumber(List<int> numList)
        {
            
            string input;
            int num;

            while (numList.Count < 10)
            {
                PrintMessages("Introduce un número: ");
                input = Console.ReadLine();

                try
                {
                    num = Convert.ToInt32(input);
                    if (num < 10)
                    {
                        numList.Add(num);
                        PrintMessages("Número almacenado\n");
                    }
                    else
                    {
                        PrintMessages("El número introducido NO es menor de 10. NO se almacenará\n");
                    }

                }
                catch (Exception)
                {
                    PrintMessages("Has introducido una letra en vez de un número\n");
                }
            }
            numList.Sort();
            return numList;
        }
        public static void PrintMessages(string message)
        {
            Console.WriteLine(message);
        }
        public static void ShowList(List<int> numList)
        {
            PrintMessages("La lista de números ordenada es: ");
            foreach (var item in numList)
            {
                Console.Write(item + " ");
            }
        }
    }
}