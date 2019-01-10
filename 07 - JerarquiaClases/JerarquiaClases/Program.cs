using System;

namespace JerarquiaClases
{

    class Program
    {

        static void Main(string[] args)
        {
            // Creamos dos coches
            Coche ferrari = new Coche(Vehiculo.Color.rojo, 1234, 1200);
            Coche porsche = new Coche(Vehiculo.Color.azul, 2345, 1400);

            // Saco sus datos
            Console.WriteLine("Soy de color " + ferrari.ColorFabrica + ", mi número de serie es " + ferrari.NumSerie + ", y mi cilindrada es " + ferrari.Cilindrada);
            Console.WriteLine("Soy de color " + porsche.ColorFabrica + ", mi número de serie es " + porsche.NumSerie + ", y mi cilindrada es " + porsche.Cilindrada);

            // Le cambio el color
            ferrari.Pinta(Vehiculo.Color.verde);
            porsche.Pinta(Vehiculo.Color.amarillo);

            // Mostramos nuevo color
            Console.WriteLine("Soy de color " + ferrari.ColorFabrica);
            Console.WriteLine("Soy de color " + porsche.ColorFabrica);

             int SumaCilindradas (int c1, int c2)
            {
                return c1 + c2;
            }

            Console.WriteLine("Suma cilindradas: " + SumaCilindradas (ferrari.Cilindrada, porsche.Cilindrada));


            Console.ReadKey();
        }

    }

}



