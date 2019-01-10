using System;
namespace JerarquiaClases
{
    class Vehiculo
    {

        private Color color;
        private int numSerie;

        public enum Color
        {
            rojo,
            verde,
            azul,
            amarillo,
            turquesa
        }

        public Color ColorFabrica { get => color; set => color = value; }

        public int NumSerie { get => numSerie; set => numSerie = value; }


        public Vehiculo(Color color, int numSerie)
        {
            this.color = color;
            this.numSerie = numSerie;
        }


        public void Pinta(Color nuevoColor)
        {

            this.color = nuevoColor;
        }

        public virtual string Imprimir()
        {
            return "Soy un vehículo de color " + ColorFabrica + ", mi número de serie es " + NumSerie;
        }


    }
}
