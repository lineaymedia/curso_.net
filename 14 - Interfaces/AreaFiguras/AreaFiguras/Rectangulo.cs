using System;
namespace AreaFiguras
{
    public class Rectangulo : IFigura
    {
        private float lado; // declara el atributo lado
        private float altura; // declara el atributo altura

        public float Lado { get => lado; set => lado = value; } // permite acceso a lado con get y set
        public float Altura { get => altura; set => altura = value; } // permite acceso a altura con get y set

        public Rectangulo(float lado, float altura)
        {
            this.Lado = lado;
            this.Altura = altura;
        }

        public double Area()
        {
            return lado * altura;
        }

        public void Imprimir()
        {
            Console.WriteLine("El área del rectángulo es: " + Area());
        }
    }
}
