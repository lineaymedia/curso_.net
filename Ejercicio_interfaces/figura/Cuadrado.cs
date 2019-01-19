using System;
namespace figura
{
    public class Cuadrado : IFigura
    {
        private double lado;

        //public double Lado { get => lado; set => lado = value; }

        public Cuadrado(double lado)
        {
            this.lado = lado * lado;
        }
        public void area()
        {
            Console.WriteLine("Area del cuadrado: {0}", lado);
            if (lado < 10)
            {
                Console.WriteLine("Es un cuadrado grande");
            }
            else
            {
                Console.WriteLine("El cuadrado es pequeño");
            }
        }
    }
}
