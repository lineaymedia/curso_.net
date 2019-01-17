using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioJerarquiaClases
{
    class Program
    {
        static void Main(string[] args)
        {
           public int SumaCilindrada;

        Vehiculo vehiculo1 = new Vehiculo(12345, Vehiculo.Color.azul);




        Console.WriteLine("El vehículo tiene como número de serie:" + vehiculo.numSerie);
            Vehiculo1.imprimir("El vehículo es de color:" + vehiculo1.Color);
            Patinete patinete = new Patinete("azul", 6789);
        Console.WriteLine("El patinete es de color:" + patinete.Color + "y tiene de nº de serie" + patinete.NumSerie);
           Patinete.imprimir("El patinete es de color:" +patinete.Color + "y tiene de nº de serie"+patinete.NumSerie);
            
            Coche coche = new Coche(1900);
        coche.imprimir("La cilindrada de este coche"+ coche.Cilindrada);
            Coche coche2 = new Coche(2000);
        coche2.imprimir("La cilindrada de este coche" + coche2.Cilindrada);
            SumaCilindrada = coche.Cilindrada + coche2.Cilindrada;
            ConsoleWriteLine("La suma de las cilindradas de los dos coches es:"+SumaCilindrada);
        Barco barco = new Barco(2, 12);
        barco.imprimir("El barco tiene" +barco.NumHelices + "helices y su eslora es de" +barco.Eslora + "metros);
    }

    Persona p1 = new Persona("Juan", 48);
    Canario c1 = new Canario();
    ICantante[] cantantes = { p1, c1 };
    foreach(ICantante c in cantantes)
        {
            Console.WriteLine(c.Cantar());    }
    }
}
