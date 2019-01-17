using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticandoInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingresa el valor de la base del rectángulo o del lado del cuadrado");
            double Lado = double.Parse(Console.ReadLine());
            Console.WriteLine("Si es un rectángulo ingresa el valor de la altura, sino escribe 1");
            double Altura = double.Parse(Console.ReadLine()); 
                                  
            Rectangulo rectangulo = new Rectangulo(Altura, Lado);           
            Cuadrado cuadrado = new Cuadrado(Lado);

            cuadrado.Imprimir();
            rectangulo.Imprimir();
            
            Console.ReadLine();
        }
    }
}
