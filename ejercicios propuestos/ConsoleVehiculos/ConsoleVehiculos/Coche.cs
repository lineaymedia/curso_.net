using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleVehiculos;

namespace ConsoleVehiculos
{

    public class Coche : Vehiculo
    {

        //Atributos de la clase Coche
        public int cilindrada;
        private int cilindrada1 = 90;
        private int cilindrada2 = 80;
        public int matricula = 874569;
        public string marca = "bmw";
        private static int length;
        private int azul;
        private int v1;
        private int v2;

        //Metodos de la clase Coche

        public void CocheDato()
        {
            if (cilindrada1 < 100) { Console.WriteLine("Tu coche no tiene la potencia adecuada"); }

            Console.WriteLine("\nEl color del coche es el {1} y su numero de serie es el siguiente: {2} ", (int)Vehiculos.Color, Vehiculo.NumSerie);

        }


        public Coche(Color color, int cilindrada, int numSerie)
        {
            this.Color1 = color;
            this.cilindrada = cilindrada;
            this.NumSerie = numSerie;

            Console.WriteLine("Se ejecuta el contructor de la clase Coche");
        }

        public Coche(int azul, int v1, int v2)
        {
            this.azul = azul;
            this.v1 = v1;
            this.v2 = v2;
        }

        // Sobrecarga del operador +
        public static Coche operator +(Coche coche1, Coche coche2)
    {
       Coche res(Coche.coche1.cilindrada1 + Coche.coche2.cilindrada2);
        return res;
    }


    public override void Imprimir( int matricula, string marca)
        {
            
            Console.WriteLine("\nImprimir Coche");
            Console.WriteLine("\nMatricula: " + matricula);
            Console.WriteLine("\nMarca del coche : " + marca);
            Console.ReadKey();

        }

        public static int SumarMatricula(int matricula)
        {
            int s2 = matricula + 1;
            int s = s2*9;
            return s;
        }


    }
}
}