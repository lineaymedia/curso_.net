using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaMetodos
{
    class Metodos
    {
        private static double AlCuadrado(int a)
        {
            return a * a;
        }

       public static double AlCuadrado(double a)
        {
            return a * a;
        }
        

    }
}
