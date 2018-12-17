using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    public class Personas
    {
        private string direccion;
        private string nombre;
        private string Direccion { get => direccion; set => direccion = value; }
        private string Localidad { get => localidad; set => localidad = value; }
        public string Nombre { get => Nombre; set => Nombre = value; }
        public int Nif { get => Nif; set => Nif = value; }
        public string Tipo { get => Tipo; set => Tipo = value; }

        private int nif;
        private string tipo;

        private string localidad;
    }
}
