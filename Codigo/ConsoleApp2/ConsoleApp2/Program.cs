using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.WriteLine("Introduce tu nombre, por favor");
           
            nombre = Console.ReadLine();
            Console.WriteLine("Tu nombre es:" + nombre);
            Console.ReadKey();
        }
    }
}
