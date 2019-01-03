using System;
namespace JerarquiaClases
{
    class Vehiculo
    {

        private string color;
        private int numSerie;
        public string nuevocolor;

        public enum Color
        {
            rojo,
            verde,
            azul,
            amarillo,
            turquesa
        };

        public void DatosVehiculo(string color, int numSerie)
        {
            this.color = color;
            this.numSerie = numSerie;
        }

        public void Pinta(string nuevocolor)
        {
            this.nuevocolor = nuevocolor;
        }

        public virtual void ImprimirVehiculo()
        {

            Console.WriteLine("Soy un vehículo de color {0}, mi número de serie es {1}, mi nuevo color es {2}", color, numSerie, nuevocolor);
        }


    }
}
