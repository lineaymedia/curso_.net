using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Personas Persona1 = new Personas();
            Persona1.Direccion = "Calle Profesor Potter, 183";
            Persona1.Localidad = "Gijón";
            Persona1.Nombre = "Daniel Canteli";
            Persona1.Nif = "10887531K";
            Persona1.Tipo = "Empleado";
            Console.WriteLine("Los datos de la persona1 son: ");
            Persona1.Imprimir();
           

            Personas Persona2 = new Personas();
            Persona2.Direccion = "Calle Profesor Potter, 183";
            Persona2.Localidad = "Gijón";
            Persona2.Nombre = "Daniel Gayo";
            Persona2.Nif = "10887531K";
            Persona2.Tipo = "Empleado";
            Console.WriteLine("Los datos de la persona2 son: ");
            Persona2.Imprimir();
            Console.ReadKey();
        }
    }
}
