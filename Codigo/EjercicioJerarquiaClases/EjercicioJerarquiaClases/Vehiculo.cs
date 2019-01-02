using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioJerarquiaClases
{
   public class Vehiculo
    {
       public enum ColorType { rojo, amarillo, verde, azul };
        private int numSerie;
        private string v;

        public int NumSerie { get => numSerie; set => numSerie = value; }

        public  Vehiculo( int numSerie, ColorType type)
        {
           
            NumSerie = numSerie;
            
        }

      
        public virtual void imprimir()
        {
            Console.WriteLine("color={rojo}, numSerie={123}");
        }

           
     
    }
}
