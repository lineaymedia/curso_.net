using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    public class Clientes : Personas
    {
        private int codigo;

        public int Codigo { get => codigo; set => codigo = value; }
    }
}
