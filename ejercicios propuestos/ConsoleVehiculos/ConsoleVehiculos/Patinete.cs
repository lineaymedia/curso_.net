using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleVehiculos;

namespace ConsoleVehiculos
{
    class Patinete : Vehiculo
    {
        //Atributos de la clase Patinete 

        public int ruedas = 4;
        private int verde;
        private int v;

        public Patinete(int verde, int v)
        {
            this.verde = verde;
            this.v = v;
        }

        //Metodos de la clase Coche

        public Patinete (ConsoleVehiculos.Vehiculo.Color color, int ConsoleVehiculos.Vehiculo.numSerie)
        {
           
            Console.WriteLine("\nEl color del patinete es el {1} y su numero de serie es el siguiente: {2} ", ConsoleVehiculos.Vehiculo.Color, ConsoleVehiculos.Vehiculo.numSerie);

        }

        public override void Imprimir(int ruedas)
        {
            Console.WriteLine("\nImprimir Patinete");
            Console.WriteLine("\nEste patinete tiene las siguientes ruedas: " + ruedas);
            Console.ReadKey();

        }
    }
}




