using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases2
{
	class Complejo
	{
		private int numero1;
		private int numero2;

		// Constructor, recibe un parámetro
		public Complejo(int numero1)
		{
			this.numero1 = numero1;
		}

		// Constructor, recibe dos parámetros
		public Complejo(int numero1, int numero2)
		{
			this.numero1 = numero1;
			this.numero2 = numero2;
		}

		// Destructor de Complejo
		~Complejo()
		{
			Console.WriteLine("El objeto complejo con los valores num1 = {0} y num2 = {1} se destruye", numero1, numero2);
		}

		// Sobrecarga del operador +
		public static Complejo operator +(Complejo c1, Complejo c2)
		{
			Complejo temporal = new Complejo(c1.numero1 + c2.numero1, c1.numero2 + c2.numero2);
			return temporal;
			//return new Complejo(c1.numero1 + c2.numero1, c1.numero2 + c2.numero2);
		}

		public void ImprimirComplejo()
		{
			Console.WriteLine("El valor de num1 es {0} y el de num2 es {1}", numero1, numero2);
		}
	}
}
