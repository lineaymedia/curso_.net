using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
	class Program
	{
		static void Main(string[] args)
		{
			Boxer p1 = new Boxer();
			Boxer p2 = new Boxer();
			PastorAleman p3 = new PastorAleman();
			Labrador p4 = new Labrador();
			Labrador p5 = new Labrador();

			Perro[] perros = { p1, p2, p3, p4, p5 };
			foreach (Perro p in perros)
			{
				Console.WriteLine(p.Ladrar());
			}

			Console.ReadKey();
		}
	}
}
