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
            double Lado;
            Console.WriteLine("Si es un rectángulo ingresa el valor de la altura, sino escribe 1");
            double Altura;
            
           
           
            Rectangulo rectangulo = new Rectangulo(  Lado, Altura);
            ICalcularArea calcular = new Rectangulo( Lado, Altura);
            Cuadrado cuadrado = new Cuadrado(Lado);

            Console.WriteLine("El area del rectángulo es" + calcular.Area());
            Console.WriteLine("Si tu figura es un cuadrado, su area es" + calcular.Area());
            Console.ReadLine();
        }
    }
}
