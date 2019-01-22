using System;

namespace EjemploInterfaceArea
{
	class Program
	{
		static void Main(string[] args)
		{
			Cuadrado c1 = new Cuadrado(2);
			Cuadrado c2 = new Cuadrado(4);
			Rectangulo r1 = new Rectangulo(2.2, 3);
			Rectangulo r2 = new Rectangulo(3.4, 1.8);

			IFigura[] figuras = { c1, c2, r1, r2 };

			foreach (IFigura f in figuras)
			{
				Console.WriteLine(" El area es: " + f.Area());
			}

			Console.ReadKey();
		}
	}
}
