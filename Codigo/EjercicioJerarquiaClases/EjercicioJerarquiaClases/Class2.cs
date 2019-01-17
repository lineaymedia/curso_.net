using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioJerarquiaClases
{
    class Canario : ICantante
    {
        public string Cantar()
        {
            return "pio pio";
        }
        public string Bailar()
        {
            return "el baile de los pajaritos";
        }
    }
}
