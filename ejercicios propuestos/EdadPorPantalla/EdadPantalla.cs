using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdadPantalla
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM;
            string linea;
            Console.WriteLine("INGRESE SU EDAD EN AÑOS:");
            linea = Console.ReadLine();
            NUM = int.Parse(linea);
            Console.WriteLine("Su Edad: " + NUM);
            Console.WriteLine("Pulse una Tecla para salir del programa:");
            Console.ReadLine();
        }
    }
}
