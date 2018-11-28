using System;

namespace Tipos
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("TIPOS SIMPLES");
			// Ejemplo de tipos simples
			sbyte sb = 1;
			short sh = -2;
			int i = 10;     // equivalente a System.Int32 i = 10;
			long l = 12L;   // letra L o l --> long
			Console.WriteLine("sbyte es {0} \nshort es {1} \nint es {2} \nlong es {3}", sb, sh, i, l);

			byte by = 3;
			ushort us = 4;
			uint ui = 6;
			ulong ul = 5;
			Console.WriteLine("byte es {0} \nushort es {1} \nuint es {2} \nulong es {3}", by, us, ui, ul);

			float f = 7.0F;     // letra F o f --> float
			double dou = 5.89;  // equivalente a double dou = 5.89d;
			decimal de = 6.56M; // letra M o m --> decimal
			Console.WriteLine("float es {0} \ndouble es {1} \ndecimal es {2}", f, dou, de);

			bool b = true;
			char c = 'a';
			Console.WriteLine("bool es {0} \nchar es {1}", b, c);

			Console.WriteLine("\n\nENUMERADOS");
			int d1 = (int)Dias.Lunes;				// Conversion explicita con casting
			int d2 = Convert.ToInt32(Dias.Martes);	// Conversion explicita con Convert
			Console.WriteLine("Lunes = {0}, Martes={1}", d1, d2);
			Console.WriteLine("Lunes: " + d1);

			int c1 = (int)Colores.Rojo;
			int c2 = (int)Colores.Verde;
			int c3 = (int)Colores.Azul;
			Console.WriteLine("Rojo = {0}, Verde={1}, Azul={2}", c1, c2, c3);

			Console.ReadKey();
		}

		// Ejemplo de enumerado de tipo int
		enum Dias
		{
			Lunes = 1,
			Martes = 2,
			Miercoles = 3,
			Jueves = 4,
			Viernes = 5,
			Sabado = 6,
			Domingo = 7
		};

		// Ejemplo de enumerado de tipo byte con valores por defecto
		enum Colores : byte
		{
			Rojo,
			Verde,
			Azul
		};		
	}
}
