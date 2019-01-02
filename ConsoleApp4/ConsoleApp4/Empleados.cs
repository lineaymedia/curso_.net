using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
   public class Empleados : Personas
    {
        private string categoria;

        public string Categoria { get => categoria; set => categoria = value; }
    }
}
