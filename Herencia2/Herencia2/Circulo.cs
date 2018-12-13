using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
	//sealed public class Circulo // impide que otras clases hereden de Circulo
	public class Circulo
	{
		public const double PI = 3.141592;
		protected double radio;

		public Circulo(double radio)
		{
			this.radio = radio;
			Console.WriteLine("Se ejecuta el contructor de la clase Circulo");
		}

		public virtual double Area()
		{
			Console.WriteLine("Calculando el area del circulo");
			return PI * radio * radio;
		}

		public void ImprimirCirculo()
		{
			Console.WriteLine("El radio del circulo es: " + radio);
		}
	}
}


