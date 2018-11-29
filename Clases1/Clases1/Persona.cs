using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases1
{
	class Persona
	{
		public string nombre;
		private int edad;

		public void ImprimirPersona()
		{
			Console.WriteLine("Mi nombre es {0} y tengo {1} años", nombre, edad);
		}

		public void AsignarEdad (int edad)
		{
			this.edad = edad;
		}
	}
}
