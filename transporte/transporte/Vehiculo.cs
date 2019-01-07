using System;
namespace transporte
{
    enum Color
    {
        Rojo = 1,
        Verde = 2,
        Azul = 3,
        Amarillo = 4
    }

    public class Vehiculo
    {

        private int numSerie;
        private Color color;

        public int NumSerie { get => numSerie; set => numSerie = value; }
        internal Color Color { get => color; set => color = value; }

        //Color colores = (Color)Convert.ToInt32(Console.ReadLine());
        //Color color = (Color)int.Parse(Console.ReadLine());
        //
        //{
        //    switch (Color)
        //    {
        //        case Color.Rojo:
        //            return "Rojo";

        //        case Color.Verde:
        //            return "Verde";

        //        case Color.Azul:
        //            return "Azul";

        //        case Color.Amarillo:
        //            return "Amarillo";

        //        default:
        //            return "Sin color";

        //    }
        //}
        public void Imprimir(string color, int NumSerie)
        {
            Console.WriteLine("El color de tu coche es: " + color);
            Console.WriteLine("El numero de serie de tu coche es : " + NumSerie);
        }
    }
}

