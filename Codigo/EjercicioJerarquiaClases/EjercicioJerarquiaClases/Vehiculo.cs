using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioJerarquiaClases
{
   public class Vehiculo
    {
        private int numSerie;
        private Color color;

        public enum Color { rojo, amarillo, verde, azul };
       
       
        public Color Color1 {get=> color ; set => color = value;}
        public int NumSerie { get => numSerie; set => numSerie = value; }

        public  Vehiculo(Color color1, int numSerie )
        {
            this.NumSerie   = numSerie;
            this.Color1      = color;
            
           
            
        }
        public void Pinta(Color nuevocolor)
        {
            this.Color1 = nuevocolor;
        }
      
        public virtual string imprimir()
        {
           
            return "El color es: "+Color1+ " y el num. serie es " +NumSerie;
        }

           
     
    }
}
