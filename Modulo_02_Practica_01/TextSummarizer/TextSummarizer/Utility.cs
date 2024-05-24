using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextSummarizer
{
    public class Utility
    {
        public static string GetInputText()
        {
            string input;

            do
            {
                Console.Write("A continuación introduzca un texto: ");
                input = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(input));
            return input.Trim();
        }
        public static int LetterCounter(string input)
        {
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    counter++;
                }
            }
            return counter ;
        }

        public static int GetCutIndex(string input)
        {
            int cutIndex = 35;
            int numSpaces = 0;

            for (int i = 0; i <= 35 + numSpaces && i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    cutIndex = i;
                    numSpaces++;
                }
            }
            return cutIndex;
        }
    }
}