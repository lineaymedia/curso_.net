using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleVehiculos;

namespace ConsoleVehiculos
{
    public class Vehiculo
    {
        // atributos de la clase

        public enum Color : byte
        {
            Rojo,
            Verde,
            Azul
        };

        Color color = Color.Rojo;

        public enum Color2 { Red, Green, Blue }

        Color c = (Color)(new Random()).Next(0, 3);
      

    private Color nuevoColor = Color.Azul;
        private int numSerie = 558452541;
        private string descripcion = "Vehiculo en muy buen estado";

        public int NumSerie { get => numSerie; set => numSerie = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        protected Color NuevoColor { get => nuevoColor; set => nuevoColor = value; }
        public Color Color1 { get => color; set => color = value; }

        //metodos de la clase
        //lo he cambiado de public a protected para facilitar el acceso 
        /* protected void MetodoVehiculo(Color color, int numSerie)
         {
             Console.WriteLine("Los colores disponibles son:{1},{2},{3}", Color.Azul, Color.Azul, Color.Verde);
             numSerie = 256842;
             Console.WriteLine("Usted eligió {1} y su numero de serie se corresponde con {2}", color, numSerie);
         }*/

        public Vehiculo(Color color, int numSerie)
        {
            this.Color1 = color;
            this.NumSerie= numSerie;
           
            Console.WriteLine("Se ejecuta el contructor de la clase Vehiculo");
        }

        
        private void Pinta(Color nuevoColor)
        {
            nuevoColor = Color.Verde;
            Console.WriteLine("El nuevo color es {1}", nuevoColor);
        }


        public virtual void Imprimir(string descripcion)
        {

            Console.WriteLine("\nImprimir Vehiculo");
            Console.WriteLine("\nColor: " + NuevoColor);
            Console.WriteLine("\nNumero de serie: " + NumSerie);
            Console.WriteLine("\nDescripción: " + descripcion);
        }

        


    }
}
