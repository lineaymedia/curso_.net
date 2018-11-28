using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("OPERADORES");
	
			int i = 0;
			// Postincremento y preincremento
			Console.WriteLine("Operadores unarios");
			Console.WriteLine("Valor i: " + i);
			Console.WriteLine("Valor i despues de i++: " + i++);
			Console.WriteLine("Valor i: " + i);
			Console.WriteLine("Valor i despues de ++i: " + ++i);
			Console.WriteLine("Valor i: " + i);

			// Operador ternario
			Console.WriteLine("\nOperador ternario");
			int j = i > 0 ? 100 : 0;
			Console.WriteLine("Valor j: " + j);

			// Operador Typeof
			Console.WriteLine("\nOperador typeof");
			Type t1 = typeof(Program);
			Type t2 = i.GetType();
			Console.WriteLine("Tipo de Program: " + t1);
			Console.WriteLine("Tipo de i: " + t2);

			// Operador is
			Console.WriteLine("\nOperador is");
			Program p = new Program();
			Console.WriteLine("¿3 * 5 es int? " +  (3*5 is int));
			Console.WriteLine("¿p es Program? " + (p is Program));
			Console.WriteLine("¿3 * 5 es Program? " + (3*5 is Program));

			// Operador as
			object o1 = 123;
			object o2 = "Hola mundo";
			string so1 = o1 as string; // equivalente a string so11 = o1 is string ? (string)o1 : null;
			string so2 = o2 as string;
			Console.WriteLine("Type de o1: " + so1);
			Console.WriteLine("Type de o2: " + so2);

			Console.ReadKey();
		}
	}
}
