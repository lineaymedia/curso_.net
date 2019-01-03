using System;
namespace JerarquiaClases
{
    class Patinete : Vehiculo
    {


        public override void ImprimirVehiculo()
        {
            Console.WriteLine("Soy un patinete de color {0}, mi número de serie es {1}, mi nuevo color es {2}", color, numSerie, nuevocolor);
        }


    }
}
