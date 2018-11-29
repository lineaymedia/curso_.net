using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases1
{
	class Program
	{
		static void Main(string[] args)
		{
			// Ejemplo Circulo - clase basica
			Console.WriteLine("Circulo - clase basica");
			Circulo c;
			c = new Circulo();      // equivalente a Circulo c = new Circulo();
			c.radio = 2.2;			// acceso a campo radio directo
			c.AsignarRadio(2.2);    // acceso a campo radio a través de método
			c.CalcularArea();
			c.ImprimirArea();

			// Ejemplo Alumno - static
			Console.WriteLine("\nAlumno - static");
			Alumno pepe = new Alumno();
			Alumno paco = new Alumno();
			pepe.AsignarNota(5);
			paco.AsignarNota(6.5);
			Console.WriteLine("Nota de corte ingenieros: {0}", Alumno.notaIngenieros);
			pepe.ImprimirResultado("Pepe");
			paco.ImprimirResultado("Paco");

			// Se modifica la variable static, afecta a todos los Alumnos
			Alumno.notaIngenieros = 7;
			Console.WriteLine("\nNota de corte ingenieros: {0}", Alumno.notaIngenieros);
			pepe.ImprimirResultado("Pepe");
			paco.ImprimirResultado("Paco");

			// Ejemplo Persona - encapsulacion
			Console.WriteLine("\nPersona - encapsulacion");
			Persona ana = new Persona();
			ana.nombre = "Ana";
			//ana.edad = 20;		// No se puede acceder a un atributo privado de la clase persona
			ana.ImprimirPersona();	// Edad tendra el valor por defecto
			ana.AsignarEdad(20);
			ana.ImprimirPersona();

			// Ejemplo sobrecarga
			Console.WriteLine("\nSobrecarga");
			Sobrecarga.Imprimir("Ejemplo de sobrecarga");
			Sobrecarga.Imprimir(1);
			Sobrecarga.Imprimir("Ejemplo", "facil");

			Console.ReadKey();
		}
	}
}
