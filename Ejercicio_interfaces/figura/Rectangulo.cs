using System;
namespace figura
{
    public class Rectangulo : IFigura
    {
        private double lado;
        private double altura;
        private double calculoRectangulo;

        public Rectangulo(double lado, double altura)
        {
            this.lado = lado;
            this.altura = altura;
            this.calculoRectangulo = lado * altura;
        }

        public void area()
        {
            Console.WriteLine("El area del rectangulo es {0} ", calculoRectangulo);

        }

    }
}
