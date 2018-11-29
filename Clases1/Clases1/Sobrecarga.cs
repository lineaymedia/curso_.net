using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases1
{
	class Sobrecarga
	{
		public static void Imprimir(string cadena)
		{
			Console.WriteLine("La cadena es {0}", cadena);
		}
		public static void Imprimir(int n)
		{
			Console.WriteLine("El entero es {0}", n);
		}

		public static void Imprimir(string cadena1, string cadena2)
		{
			Console.WriteLine("Las cadenas son {0} y {1}", cadena1, cadena2);
		}
	}
}
