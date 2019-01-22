using System;


namespace AreaFiguras
{
    public class Cuadrado : IFigura // obliga a implementar la interface IFigura
    {
        private float lado; // declara el atributo lado

        public float Lado { get => lado; set => lado = value; } // permite acceso a lado con get y set

        public Cuadrado(float lado)
        {
            this.Lado = lado;
        }

        public double Area()
        {
            return lado * lado;
        }

        public void Imprimir()
        {
        Console.WriteLine("El área del cuadrado es: " + Area());
        }




    }
}
