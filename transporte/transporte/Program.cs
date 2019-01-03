using System;

namespace transporte
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Vamos a construir nuestro Coche");
            Console.WriteLine("Selector de color");

            Vehiculo vehiculo1 = new Vehiculo();

            Console.WriteLine("Numero de serie: ");
            vehiculo1.NumSerie = int.Parse(Console.ReadLine());
            Console.WriteLine("El numeor de serie es: {0}", vehiculo1.NumSerie);

        }

    }

    enum Color
    {
        Rojo,
        Verde,
        Azul,
        Amarillo
    }

    // Creando la clase Vehiculo
    public class Vehiculo
    {
        //Creando el enumerado de colores
        static void ImprimirColor(Color color)
        {
            switch (color)
            {
                case Color.Rojo:
                    Console.WriteLine("Rojo");
                    break;
                case Color.Verde:
                    Console.WriteLine("Verde");
                    break;
                case Color.Azul:
                    Console.WriteLine("Azul");
                    break;
                case Color.Amarillo:
                    Console.WriteLine("Amarillo");
                    break;
                default:
                    Console.WriteLine("Color sin determinar");
                    break;
            }
        }

        private int numSerie;

        public int NumSerie
        {
            get
            {
                return this.numSerie;
            }
            set
            {
                this.numSerie = value;
            }
        }
    }
}
