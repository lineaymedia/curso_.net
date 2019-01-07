using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleVehiculos;

namespace ConsoleVehiculos
{
    public class Barco : Vehiculo
    {
        public static int SumarBarco(int x1, int x2)
        {
            int s = x1 + x2;
            return s;
        }

        //Atributos de la clase Barco
        private int numHelices = 8;
        private int eslora = 20;
        string descripcionBarco = "Barco de categoria";

        //Métodos de la clase Barco
        
        Barco barco2 = new Barco((int)Vehiculo.Color.Rojo, 8, 5584585011);
        private long v;

        public Barco(ConsoleVehiculos.Vehiculo.Color color, int numHelices, ConsoleVehiculos.Vehiculo.numSerie) {
            int resultado = numHelices * eslora;
            Console.WriteLine("\nLas elices si son dobles por metro en total serian " + resultado);
            Console.ReadLine();
            Console.WriteLine("\nLas elices por defecto serian {1}, el total de eslora disponible son {2} metros y el color del barco es el {3} ", numHelices, eslora, ConsoleVehiculos.Vehiculo. Color);

        }

        public Barco(Color color, int numSerie, long v) : base(color, numSerie)
        {
            this.v = v;
        }

        public override void Imprimir(string descripcion, int matricula)
        {
            matricula = "874569";
                    
            Console.WriteLine("\nImprimir Barco");
            Console.WriteLine("\nColor: " + ConsoleVehiculos.Vehiculo.Color);
            Console.WriteLine("\nNumero de serie: " + ConsoleVehiculos.Vehiculo.NumSerie);
            Console.WriteLine("\nNumero de Helices: " + ConsoleVehiculos.Vehiculo.numHelices);
            Console.WriteLine("\nDescripción: " + descripcionBarco);
            Console.WriteLine("\nMatricula: " + matricula);
            Console.WriteLine("\nEslora: " + eslora);
            Console.ReadKey();

        }




    }
}
