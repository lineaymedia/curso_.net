using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SobrecargaMetodos;


namespace SobrecargaMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4 al cuadrado es {0}", Metodos.AlCuadrado(4));
            Console.ReadKey();
            Console.WriteLine("3.2 al cuadrado es {0}", Metodos.AlCuadrado(3.2));
            Console.ReadLine();
        }
    }
}
