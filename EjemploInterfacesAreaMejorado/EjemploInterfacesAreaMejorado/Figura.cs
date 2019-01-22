using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfacesAreaMejorado
{
	class Figura
	{
		private double lado;

		public Figura(double lado)
		{
			this.lado = lado;
		}

		public double Lado { get => lado; set => lado = value; }
	}
}
