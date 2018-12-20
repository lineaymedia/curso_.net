using System;

namespace Herencia
{
    class Persona
    {
        public string Nombre;
        public int Edad;

    }

    class Alumno : Persona
    {
        public static void Main()
         {
            Alumno Alumno1 = new Alumno("Juan", 20);

            public void ListaAlumnos()
            {
                Console.WriteLine("Alumno: " + Nombre + "Edad: " + Edad);

            }

           
            Console.ReadKey();
        }
    }
}
