using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaceArea
{
	class Rectangulo : IFigura
	{
		private double lado;
		private double altura;

		public Rectangulo(double lado, double altura)
		{
			this.lado = lado;
			this.altura = altura;
		}

		public double Area()
		{
			return lado * altura;
		}
	}
}
