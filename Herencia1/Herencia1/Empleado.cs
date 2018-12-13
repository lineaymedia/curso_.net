using System;

namespace Herencia1
{
	// clase derivada
	public class Empleado : Persona
	{
		String empresa;
		// hereda los campos de la clase persona: nombre, apellido, edad, ciudad

		public Empleado(String nombre, String apellido, String empresa)
		{
			this.empresa = empresa;
			this.nombre = nombre;
			this.apellido = apellido;
			Console.WriteLine("Se ejecuta el contructor de la clase Empleado");
		}

		public void ImprimirDatosEmpleado()
		{
			Console.WriteLine("\nImprimir Empleado");
			// nombre es public en clase base, clase derivada puede acceder
			Console.WriteLine("Nombre: " + nombre);
			// apellido es protected en clase base, la clase derivada puede acceder al dato
			Console.WriteLine("Apellido: " + apellido);
			// edad y ciudad son private en clase base, la clase derivada 
			// no puede acceder al dato
			//Console.WriteLine("Edad: " + edad);
			//Console.WriteLine("Ciudad: " + ciudad);
			Console.WriteLine("Empresa: " + empresa);
		}

		// Sobreescritura (override)
		public override void ImprimirNombre()
		{
			Console.WriteLine("\nEl nombre del empleado es: " + nombre + " " + apellido);
		}
	}
}
