using System;
namespace transporte
{
    // Creando la clase Coche
    public class Coche : Vehiculo
    {
        private int cilindrada;

        public int Cilindrada { get => cilindrada; set => cilindrada = value; }

        //public void Imprimir(string color, int NumSerie)
        //{
        //    Console.WriteLine("El color de tu coche es: " + color);
        //    Console.WriteLine("El numero de serie de tu coche es : " + NumSerie);
        //    Console.WriteLine("El numero de serie de tu coche es : " + Cilindrada);
        //}
    }
}
