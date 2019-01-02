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
        private string nif;
        private string tipo;
        private string localidad;
        public string Direccion { get => direccion; set => direccion = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Nif { get => nif; set => nif = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public void Imprimir()
        {
            Console.WriteLine("Nombre:" + Nombre);
            Console.WriteLine("NIF:" + Nif);
            Console.WriteLine("Direccion:" + Direccion);
            Console.WriteLine("Localidad:" + Localidad);
            Console.WriteLine("Tipo:" + Tipo);
        }
    }
   
}
