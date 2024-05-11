using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFormat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int alto;
            int ancho;

            do
            {
                Console.Write("Escriba el tamaño en pixels de su imagen.\nAlto: ");
                input = Console.ReadLine();
                try
                {
                    alto = Convert.ToInt32(input);
                    do
                    {
                        Console.Write("Ancho: ");
                        input = Console.ReadLine();
                        try
                        {
                            ancho = Convert.ToInt32(input);
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

            if (alto > ancho) Console.WriteLine("Su imágen de {0} x {1} pixels es vertical.", alto, ancho);
            else if (ancho > alto) Console.WriteLine("Su imágen de {0} x {1} pixels es horizontal.", alto, ancho);
            else Console.WriteLine("Su imágen de {0} x {1} pixels es cuadrada.", alto, ancho);
        }
    }
}
