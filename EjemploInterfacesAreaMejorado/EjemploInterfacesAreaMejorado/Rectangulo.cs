using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfacesAreaMejorado
{
	class Rectangulo : Figura, IFigura
	{
		private double altura;

		public Rectangulo(double lado, double altura) : base (lado)
		{
			this.altura = altura;
		}

		public double Area()
		{
			return Lado * altura;
		}
	}
}
