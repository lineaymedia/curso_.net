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
        protected Color nuevoColor = Color.Azul;
        public int numSerie = 558452541;
        public string descripcion = "Vehiculo en muy buen estado";

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
            this.color = color;
            this.numSerie= numSerie;
           
            Console.WriteLine("Se ejecuta el contructor de la clase Vehiculo");
        }

        //public
        private void Pinta(Color nuevoColor)
        {
            nuevoColor = Color.Verde;
            Console.WriteLine("El nuevo color es {1}", nuevoColor);
        }


        public void Imprimir(string descripcion)
        {

            Console.WriteLine("\nImprimir Vehiculo");
            Console.WriteLine("\nColor: " + nuevoColor);
            Console.WriteLine("\nNumero de serie: " + numSerie);
            Console.WriteLine("\nDescripción: " + descripcion);
        }

        


    }
}
