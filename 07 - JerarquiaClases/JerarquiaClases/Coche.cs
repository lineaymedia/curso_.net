using System;
namespace JerarquiaClases
{
    class Coche : Vehiculo
    {

        private int cilindrada;


        public void Cilindrada(int cilindrada)
        {
            this.cilindrada = cilindrada;
        }


        public override void ImprimirVehiculo()
        {
            Console.WriteLine("Soy un coche de color {0}, mi número de serie es {1} y mi cilindrada es {2} y la suma de cilindradas es {3}", color, numSerie, cilindrada, sumacilindrada);
        }


    }
}
