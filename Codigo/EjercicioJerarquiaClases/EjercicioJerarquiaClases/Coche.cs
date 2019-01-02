using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioJerarquiaClases
{
    public class Coche : Vehiculo
    {
        private int cilindrada;
        public int Cilindrada { get => cilindrada; set => cilindrada = value; }
        
        public override void imprimir()
        {
            Console.WriteLine("color={rojo}, numSerie={567878}, cilindrada{1400}");
        }
    }
}
