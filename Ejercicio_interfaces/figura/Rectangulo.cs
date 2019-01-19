using System;
namespace figura
{
    public class Rectangulo : IFigura
    {
        private double lado;
        private double altura;

        public Rectangulo(double lado, double altura)
        {
            this.lado = lado;
            this.altura = altura;
        }

        public void area()
        {
            Console.WriteLine("El area del rectangulo es {0} ", lado * altura);
        }

    }
}
