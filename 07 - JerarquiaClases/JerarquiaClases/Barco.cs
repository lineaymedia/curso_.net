using System;
namespace JerarquiaClases
{
    class Barco : Vehiculo
    {

        private int numHelices;
        private int eslora;



        public void DatosBarco(int numHelices, int eslora)
        {
            this.numHelices = numHelices;
            this.eslora = eslora;
        }

        public override void ImprimirVehiculo()
        {
            Console.WriteLine("Soy un barco de color {0}, mi número de serie es {1}, mi nuevo color es {2} tengo {3} hélices y mi eslora es {4}", color, numSerie, nuevocolor, numHelices, eslora);
        }


    }
}
