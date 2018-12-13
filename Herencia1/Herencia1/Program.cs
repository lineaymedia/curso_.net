using System;

namespace Herencia1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("HERENCIA");
			Console.WriteLine("\nInstanciar Persona");
			Persona persona = new Persona("Pepe", "Garcia", 28, "Gijon");
			Console.WriteLine("\nInstanciar Empleado");
			Empleado empleado = new Empleado("Manuel", "Perez", "Google");

			// Herencia. Invocar metodos de clase base
			empleado.ImprimirDatosPersona();

			// Herencia. Sobreescritura
			persona.ImprimirNombre();
			empleado.ImprimirNombre();

			Console.ReadKey();
		}
	}
}
