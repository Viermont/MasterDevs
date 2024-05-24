using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TextSummarizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int numLetters;

            input = Utility.GetInputText();
            numLetters = Utility.LetterCounter(input);
            if (numLetters <= 35)
            {
                Console.WriteLine("Su texto: " + input);
            }
            else
            {
                Console.WriteLine("Su texto resumido: " + input.Substring(0, Utility.GetCutIndex(input)) + "...");
            }
        }
    }
}