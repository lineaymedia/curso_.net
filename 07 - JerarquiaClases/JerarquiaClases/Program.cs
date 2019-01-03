using System;

namespace JerarquiaClases
{

    class Program
    {

        static void Main(string[] args)
        {




            Coche ferrari = new Coche();
            ferrari.DatosVehiculo(color, 1000);
            ferrari.Pinta("azul");
            ferrari.Cililndrada(4000);
            ferrari.ImprimirVehiculo();

            Coche porsche = new Coche();
            porsche.DatosVehiculo("rojo", 1000);
            porsche.Pinta("azul");
            porsche.Cililndrada(2000);
            porsche.ImprimirVehiculo();


            int c1 = porsche.Cilindrada;
            int c2 = ferrari.Cilindrada;

           

                Console.WriteLine("La suma de cilindradas es: " + c1 + c2);



            Barco christina = new Barco();
            christina.DatosVehiculo("azul", 2000);
            christina.Pinta("turquesa");
            christina.DatosBarco(4, 99);
            christina.ImprimirVehiculo();

            Patinete tonyhawk = new Patinete();
            tonyhawk.DatosVehiculo("verde", 500);
            tonyhawk.Pinta("amarillo");
            tonyhawk.ImprimirVehiculo();


            Vehiculo[] vehiculos = { ferrari, porsche, christina, tonyhawk };

            foreach (Vehiculo ..... in vehiculos)
            {
                Console.WriteLine(Vehiculo......);
            }
            Console.ReadKey();
        }

    }

}



