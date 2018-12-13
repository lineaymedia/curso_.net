using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("HERENCIA - CONSTRUCTORES");
			Console.WriteLine("\nInstanciar Circulo");
			Circulo circulo = new Circulo(2);

			Console.WriteLine("\nInstanciar Cilindro");
			Cilindro cilindro = new Cilindro(2, 5);

			Console.WriteLine("\nInstanciar Cilindro");
			Cilindro cilindro2 = new Cilindro(5);

			Console.WriteLine("\nPOLIMORFISMO");
			Circulo circulo2 = new Cilindro(10);
			circulo2.ImprimirCirculo();
			// circulo2.ImprimirCilindro();		// circulo2 solo puede acceder a los atributos y
												// metodos de la clase Circulo

			// si circulo2 invoca un método sobreescrito, se ejecuta el del objeto (cilindro)
			Console.WriteLine("Invocar Area desde circulo2: " + circulo2.Area());

			Console.ReadKey();
		}
	}
}
