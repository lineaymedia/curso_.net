using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    public class Proveedores : Personas
    {
        private int codigoProveedor;

        public int CodigoProveedor { get => codigoProveedor; set => codigoProveedor = value; }
    }
}
