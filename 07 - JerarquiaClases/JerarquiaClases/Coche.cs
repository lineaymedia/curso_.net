using System;
using System.Drawing;

namespace JerarquiaClases
{
    class Coche : Vehiculo
    {

        private int cilindrada;


        public int Cilindrada { get => cilindrada; set => cilindrada = value; }

        public Coche(Color color, int numSerie, int cilindrada) : base(color, numSerie)
        {

            this.cilindrada = cilindrada;
        }


        public override string Imprimir()
        {
            return "Soy un coche de color " + ColorFabrica + ", mi número de serie es " + NumSerie + " y mi cilindrada es " + cilindrada;
        }


    }
}
