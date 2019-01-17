using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioJerarquiaClases
{
    class Persona : ICantante
    {
        private string nombre;
        private int edad;
        public string Cantar()
        {
            return "Asturias patria querida";
        }
        public string Bailar()
        {
            return "cha cha cha";
        }
    }
}
