using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    class Program
    {
        public class Persona
        {
            public const int totalpersonasensala = 12;
            public String Nombre;
            public String Apellido;
        }


        public static void Main()
        {
            Persona p1 = new Persona();
            p1.Nombre = "Nuria";
            p1.Apellido = "Casal";
            Console.WriteLine("Su nombre es {0}, y su apellido es {1}", p1.Nombre, p1.Apellido);
            Console.ReadLine();
            Console.WriteLine("Ella estaba en la sala, junto a otras {0} personas", Persona.totalpersonasensala);
            Console.ReadLine();
        }
    }
}


					
