using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioJerarquiaClases
{
    public class Patinete : Vehiculo
    {
        public override void imprimir()
        {
            Console.WriteLine("color={azul},numSerie={987}");
        }
    }
}
