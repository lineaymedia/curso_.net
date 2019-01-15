using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaceCantante
{
	class Program
	{
		static void Main(string[] args)
		{
			Persona p = new Persona("Juan", 30);
			Canario c = new Canario();

			Console.WriteLine("Juan canta: " + p.Cantar());
			Console.WriteLine("El canario canta: " + c.Cantar());

			ICantante[] cantantes = { p, c};
			foreach (ICantante cnt in cantantes)
			{
				Console.WriteLine(cnt.Cantar());
			}

			Console.ReadKey();
		}
	}
}
