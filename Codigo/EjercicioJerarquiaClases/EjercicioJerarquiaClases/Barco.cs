using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioJerarquiaClases
{
    public class Barco : Vehiculo
    {
        private int numHelices;
        private int eslora;

        public int NumHelices { get => numHelices; set => numHelices = value; }
        public int Eslora { get => eslora; set => eslora = value; }

        public Barco(Color color, int numSerie, int numHelices, int eslora) : base( color,  numSerie);
        {
         
          
            this.NumHelices = numHelices;
            this.Eslora = eslora
        }

        public override string imprimir()
        {
            return "El color es: "+Color+ " y el num. serie es " +NumSerie;
        }
    }
}
