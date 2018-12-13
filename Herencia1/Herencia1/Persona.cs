using System;

namespace Herencia1
{
	// clase base
	public class Persona
	{
		public string nombre;
		protected string apellido;
		private int edad;
		string ciudad;      // privado, al omitir el modificador

		public Persona()
		{
			Console.WriteLine("Se ejecuta el contructor por defecto de la clase Persona");
		}

		public Persona(String nombre, String apellido, int edad, String ciudad)
		{
			this.nombre = nombre;
			this.apellido = apellido;
			this.edad = edad;
			this.ciudad = ciudad;
			Console.WriteLine("Se ejecuta el contructor de la clase Persona");
		}

		public void ImprimirDatosPersona()
		{
			Console.WriteLine("\nImprimir Persona");
			// desde la propia clase se puede acceder a todos los campos, independientemente
			// de su modificador
			Console.WriteLine("Nombre: " + nombre);
			Console.WriteLine("Apellido: " + apellido);
			Console.WriteLine("Edad: " + edad);
			Console.WriteLine("Ciudad: " + ciudad);
		}

		// Sobreescritura (virtual)
		public virtual void ImprimirNombre()
		{
			Console.WriteLine("\nEl nombre de la persona es: " + nombre + " " + apellido);
		}
	}
}
