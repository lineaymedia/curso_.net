using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases2
{
	class Program
	{
		static void Main(string[] args)
		{
			// Constructores y sobrecarga de constructores
			Console.WriteLine("Complejo - constructor un parametro");
			Complejo c1 = new Complejo(2);	// El campo numero2 se inicializa a su valor por defecto
			c1.ImprimirComplejo();
			Console.WriteLine("Complejo - constructor dos parametros");
			Complejo c2 = new Complejo(3, 4);
			c2.ImprimirComplejo();
			//Complejo c3 = new Complejo();  // Error al quedar anulado el constructor por defecto

			// Sobrecarga del operador +
			Console.WriteLine("\nComplejo - sobrecarga operador +");
			Complejo c4 = c1 + c2;
			c4.ImprimirComplejo();

			// Propiedades de las clases 
			Console.WriteLine("\nPersona - propiedades de las clases");
			Persona ana = new Persona("Ana");
			ana.Edad = 20;
			ana.Sexo = "mujer";
			// Console.WriteLine("{0} tiene {1} años y es {2}", ana.Nombre, ana.Edad, ana.sexo);
			ana.ImprimirPersona();

			// Clase abstracta, no se puede instanciar
			//ClaseAbstracta abs = new ClaseAbstracta();

			Console.ReadKey();
		}
	}
}
