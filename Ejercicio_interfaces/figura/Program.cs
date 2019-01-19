using System;

namespace figura
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calculamos el area del Cuadrado");
            Console.WriteLine("Introduce un numero");
            Cuadrado miCuadrado = new Cuadrado(double.Parse(Console.ReadLine()));
            miCuadrado.area();
            //coche1.NumSerie = int.Parse(Console.ReadLine());
            //Console.WriteLine("Area de mi cuadrado {0} ", miCuadrado);
            Console.WriteLine("Area del rectangulo con valores fijos 10 * 5 ");
            Rectangulo miRectangulo = new Rectangulo(10,5);
            miRectangulo.area();
        }
    }
}
