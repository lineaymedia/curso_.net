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

       public Barco (int numHelices,  int eslora)
        {
            NumHelices = numHelices;
            Eslora = eslora;
        }

        public override void imprimir()
        {
            Console.WriteLine("color={azul},numSerie={345},numHelices={2}, eslora{2}");
        }
    }
}
