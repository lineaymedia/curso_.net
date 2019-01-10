using System;
namespace JerarquiaClases
{
    class Patinete : Vehiculo
    {

        public Patinete (Color color, int numSerie) :base (color, numSerie)
        {

        }

        public override string Imprimir()
        {
            return "Soy un patinete de color " + ColorFabrica + ", mi número de serie es " + NumSerie;
        }


    }
}
