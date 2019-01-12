using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerenciaAula
{
	class Program
	{
		static void Main(string[] args)
		{
			// Inicializacion de Aula mediante get y set.
			Aula a1 = new Aula();
			a1.Nombre = "Aula 1";
			a1.M2 = -10;	// Por la condicion que pusimos en el set, m2 sera 0.
			a1.ImprimirAula();

			// Inicializacion de Aula mediante constructor
			Aula a2 = new Aula("Aula 2", 20, true);
			a2.ImprimirAula();

			string nombreL1 = "Laboratorio 1";
			Laboratorio l1 = new Laboratorio(nombreL1, 10, 3);
			l1.ImprimirLaboratorio();

			Laboratorio l2 = new Laboratorio("Laboratorio 2", 20, true, 10);
			l2.ImprimirLaboratorio();

			Console.ReadLine();

		}
	}
}
