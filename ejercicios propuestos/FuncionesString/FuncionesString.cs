using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleString
{
    class Program
    {
        static void Main(string[] args)
        {
            String cadena = ("Esto es una cadena/");
            Console.Write(cadena);
            String cadena2 =("y esta otra cadena de texto");
            Console.WriteLine(cadena + cadena2);
            char c2 = cadena[2];
            Console.ReadLine();
            Console.WriteLine(c2);
            Console.ReadLine();
            Console.WriteLine("Hola Mundo".IndexOf('M'));
            Console.ReadLine();
            Console.WriteLine(cadena.Length);
            Console.ReadLine();
            Console.Write(cadena.Substring(cadena.Length - 1, 1));
            Console.ReadLine();
            Console.WriteLine(cadena.Substring(2, 6));
            Console.ReadLine();

        }
    }
}
