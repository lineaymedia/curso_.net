using System;

namespace AreaFiguras
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Calcularemos el área de un cuadrado(1) o de un rectángulo(2)?");
            int eleccion = int.Parse(Console.ReadLine());


            switch (eleccion)
            {

            case 1:
                Console.WriteLine("Ingresa el lado del cuadrado");
                double Lado = double.Parse(Console.ReadLine());
                Cuadrado cuadrado1 = new Cuadrado((float)Lado);
                cuadrado1.Imprimir();
                break;
                
            case 2:
                Console.WriteLine("Ingresa el lado del rectángulo");
                double Lado = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa la altura del rectángulo");
                double Altura = double.Parse(Console.ReadLine());
                Rectangulo rectangulo1 = new Rectangulo((float)Lado, (float)Altura);
                rectangulo1.Imprimir();
                break;
                
                default:
                Console.WriteLine("Número incorrecto debes seleccionar (1) para cuadradro, (2) para rectángulo");
                    break;


            }

        }
    }
}
