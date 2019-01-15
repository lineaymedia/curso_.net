using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaceCantante
{
	class Persona : ICantante
	{
		string nombre;
		int edad;

		public Persona(string nombre, int edad)
		{
			this.nombre = nombre;
			this.edad = edad;
		}

		public string Imprimir()
		{
			return "Soy " + nombre + " y tengo " + edad + " años";
		}

		public string Cantar()
		{
			return "Asturias Patria Queridaaaa";
		}
	}
}
