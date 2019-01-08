using System;
namespace transporte
{
    // Creando la clase Barco
    public class Barco : Vehiculo
    {
        private int numHelices;
        private int eslora;

        public int NumHelices { get => numHelices; set => numHelices = value; }
        public int Eslora { get => eslora; set => eslora = value; }
        //public void Imprimir(string color, int NumSerie)
        //{
        //    Console.WriteLine("El color de tu barco es: " + color);
        //    Console.WriteLine("El numero de serie de tu barco es : " + NumSerie);
        //    Console.WriteLine("El numero de serie de tu barco es : " + NumHelices);
        //    Console.WriteLine("El numero de serie de tu barco es : " + Eslora);
        //}
    }
}
