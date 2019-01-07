using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioJerarquiaClases
{
   public class Vehiculo
    {
       public enum Color { rojo, amarillo, verde, azul };
        private int numSerie;
       
        public Color Color {get=> color ; set => color = value;}
        public int NumSerie { get => numSerie; set => numSerie = value; }

        public  Vehiculo( int numSerie, Color color)
        {
            this.NumSerie = numSerie;
            this.Color = color;
           
            
        }

      
        public virtual string imprimir()
        {
           
            return "El color es: "+Color+ " y el num. serie es " +NumSerie;
        }

           
     
    }
}
