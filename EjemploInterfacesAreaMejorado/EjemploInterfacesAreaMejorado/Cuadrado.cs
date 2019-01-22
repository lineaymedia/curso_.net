using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfacesAreaMejorado
{
	class Cuadrado : Figura, IFigura
	{
		public Cuadrado(double lado) : base(lado)
		{
		}

		public double Area()
		{
			return Lado * Lado;
		}
	}
}
