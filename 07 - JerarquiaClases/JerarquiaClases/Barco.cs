using System;
namespace JerarquiaClases
{
    class Barco : Vehiculo
    {

        private int numHelices;
        private int eslora;


        public int NumHelices { get => numHelices; set => numHelices = value; }
        public int Eslora { get => eslora; set => eslora = value; }


        public Barco(Color color, int numSerie, int numHelices , int eslora) : base(color, numSerie)
        {

            this.numHelices = numHelices;
            this.eslora = eslora;
        }

        public override string Imprimir()
        {
            return "Soy un barco de color " + ColorFabrica + ", mi número de serie es " + NumSerie + ", tengo " + NumHelices + " hélices y mi eslora es " + Eslora;
        }


    }
}
