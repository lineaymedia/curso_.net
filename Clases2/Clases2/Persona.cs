using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases2
{
	class Persona
	{
		string nombre;
		int edad;
		string sexo;

		public Persona(string str)
		{
			nombre = str;
		}

		// edad es una propiedad de lectura y escritura
		public int Edad
		{
			get
			{
				return edad;
			}
			set
			{
				edad = value;
			}
		}

		// nombre es una propiedad de solo lectura
		public string Nombre
		{
			get
			{
				return nombre;
			}
		}



		// sexo es una propiedad de solo escritura, se puede acceder a ella desde dentro de la clase pero no desde fuera
		public string Sexo
		{
			set
			{
				sexo =  value;
			}
		}

		public void ImprimirPersona()
		{
			Console.WriteLine("{0} tiene {1} años y es {2}", nombre, edad, sexo);
		}
	}
}
