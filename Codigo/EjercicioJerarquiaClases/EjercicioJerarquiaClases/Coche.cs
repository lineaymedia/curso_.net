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
        
        public override string imprimir()
        {
             return "La cilindrada es: "+Cilindrada;
        }
    }
}
