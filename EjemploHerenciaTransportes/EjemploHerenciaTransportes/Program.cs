using System;

namespace EjemploHerenciaTransportes
{
	class Program
	{
		static void Main(string[] args)
		{
			//Vehiculo v1 = new Vehiculo(Color.Azul, 10);

			Coche c1 = new Coche(Color.Rojo, 20, 100);
			Coche c2 = new Coche(Color.Verde, 30, 200);
			// Suma de coches
			Coche c3 = c1 + c2;

			Barco b1 = new Barco(Color.Azul, 40, 1, 20);
			Barco b2 = new Barco(Color.Rojo, 50, 2, 30);
			//Barco b3 = b1 + b2;

			Patinete p1 = new Patinete(Color.Verde, 60);

			Vehiculo[] vehiculos = { c1, c2, c3, b1, b2, p1 };

			foreach (Vehiculo v in vehiculos)
			{
				Console.WriteLine(v.Imprimir());
				Console.WriteLine(v.Conduccion());
			}

			Vehiculo.ImprimirStatic();

			Console.ReadKey();

		}
	}
}
